-- Correcciones de errores / Mantenimiento
select * from transacciones

-- Esto daba error al crear un cliente, ya que en el script no existía la transacción 09.
INSERT INTO transacciones (transaccion, nombre, tabla, campo_id, serie)
VALUES ('09', 'Clientes', 'clientes', 'cod_cte', 'C');
GO

-- El formulario para agregar clientes te genera un ID, pero aquí, estaba en IDENTITY y falla.
DROP TABLE clientes;
GO

CREATE TABLE clientes
(
    cod_cte CHAR(10) NOT NULL PRIMARY KEY, -- Cambiado de INT IDENTITY a CHAR(10)
    razon_social VARCHAR(250),
    nombre VARCHAR(150),
    rfc VARCHAR(20),
    ap_paterno VARCHAR(80),
    ap_materno VARCHAR(80),
    telefono CHAR(15),
    extension CHAR(8),
    telefono2 CHAR(15),
    celular CHAR(20),
    calle VARCHAR(100),
    calle_num CHAR(10),
    calle_entre1 VARCHAR(100),
    calle_entre2 VARCHAR(100),
    colonia VARCHAR(150), 
    cod_postal CHAR(15),
    status CHAR(3),
    usuario CHAR(10)
)
GO

-- Actualizar direccionCompleta
ALTER FUNCTION dbo.direccionCompleta(@codigo CHAR(10), @tipo CHAR(5))
RETURNS VARCHAR(500)
AS
BEGIN
    DECLARE @direccion VARCHAR(500)
    IF @tipo = 'C'
    BEGIN
        SELECT @direccion = CASE WHEN calle <> '' THEN
                                  'Calle ' + calle + ' ' + RTRIM(calle_num)   
                                  + ' Entre ' + calle_entre1 +  ' Y ' + LTRIM(RTRIM(calle_entre2)) 
                                  + ' Col. ' + LTRIM(RTRIM(colonia)) + ' C.P. ' + LTRIM(RTRIM(cod_postal))  
                            END
        FROM clientes
        WHERE cod_cte = @codigo
    END
	IF @tipo = 'P'
	BEGIN
    	SELECT  @direccion = CASE WHEN calle <> '' THEN
										  'Calle ' + calle + ' ' + RTRIM(calle_num)   
										  + ' Entre ' + calle_entre1 +  ' Y ' + LTRIM(RTRIM(calle_entre2)) 
										  + ' Col. ' + LTRIM(RTRIM(colonia)) + ' C.P. ' + LTRIM(RTRIM(cod_postal))  
									
									END
			FROM proveedores 
			WHERE cod_prv = @codigo
    END
	RETURN ISNULL(@direccion,'')	
END
GO

-- Actualizar nombreCompleto
ALTER FUNCTION dbo.nombreCompleto(@codigo CHAR(10), @tipo CHAR(5))
RETURNS VARCHAR(500)
AS
BEGIN
    DECLARE @nombre VARCHAR(500)
    IF @tipo = 'C'
    BEGIN
        SELECT @nombre = nombre + ' ' + ap_paterno + ' ' + ap_materno  
        FROM clientes 
        WHERE cod_cte = @codigo
    END
	IF @tipo = 'P'
	BEGIN
    	SELECT @nombre = nombre + ' ' + ap_paterno + ' ' +ap_materno  
		FROM proveedores 
		WHERE cod_prv = @codigo
    END		
		RETURN ISNULL(@nombre,'')
END
GO

ALTER PROC [dbo].[Buscador] @Tabla varchar(30),  @Trans char(5) 
AS
BEGIN
	-- Aumentamos el tamaño de 'codigo' a char(10) para que quepan folios como 'C0001'
	DECLARE @Datos TABLE (
		codigo CHAR(10), 
		nombre VARCHAR(200), 
		fecha SMALLDATETIME,
		visible_f BIT, 
		monto MONEY, 
		visible_m BIT, 
		status CHAR(5)
	)
	DECLARE @Columnas TABLE(columna CHAR(1), nombre VARCHAR(100))
	DECLARE @SQL NVARCHAR(MAX)

	IF @Tabla = 'articulos'
	BEGIN
		INSERT INTO @Datos
		SELECT cod_art, descripcion, GETDATE(), 0, precio, 1, status 
		FROM articulos WITH(NOLOCK)

		INSERT INTO @Columnas VALUES(1, 'Artículo')
		INSERT INTO @Columnas VALUES(2, 'Descripción')
		INSERT INTO @Columnas VALUES(3, 'Precio')
	END

	IF @Tabla = 'clientes'
	BEGIN
		INSERT INTO @Datos
		SELECT cod_cte, razon_social, GETDATE(), 0, 0, 0, status 
		FROM clientes WITH(NOLOCK)
		WHERE status = 'V'

		INSERT INTO @Columnas VALUES(1, 'Cliente')
		INSERT INTO @Columnas VALUES(2, 'Razón social')
		INSERT INTO @Columnas VALUES(3, ' ')
	END

	IF @Tabla = 'proveedores'
	BEGIN
		INSERT INTO @Datos
		SELECT cod_prv, razon_social, GETDATE(), 0, 0, 0, status 
		FROM proveedores WITH(NOLOCK)
		WHERE status = 'V'

		INSERT INTO @Columnas VALUES(1, 'Proveedor')
		INSERT INTO @Columnas VALUES(2, 'Razón social')
		INSERT INTO @Columnas VALUES(3, ' ')
	END

	IF @Tabla = 'operaciones_inventario'
	BEGIN
		SET @SQL = 'SELECT oi.folio, t.nombre, oi.fecha, 1, SUM(moi.cantidad), 1, oi.status 
		FROM operaciones_inventario oi WITH(NOLOCK)
		INNER JOIN transacciones t WITH(NOLOCK) ON t.transaccion = oi.transaccion
		INNER JOIN moperaciones_inventario moi WITH(NOLOCK) ON moi.folio = oi.folio AND moi.transaccion = oi.transaccion
		WHERE oi.status = ''V'''

		IF @Trans <> ''
			SET @SQL = @SQL + ' AND oi.transaccion = ''' + @Trans + ''''
		
		SET @SQL = @SQL + ' GROUP BY oi.folio, t.nombre, oi.fecha, oi.status'

		INSERT INTO @Datos
		EXEC sp_sqlexec @SQL

		INSERT INTO @Columnas VALUES(1, 'Folio')
		INSERT INTO @Columnas VALUES(2, 'Transacción')
		INSERT INTO @Columnas VALUES(3, 'Cantidad')
	END

	SELECT * FROM @Datos
	SELECT * FROM @Columnas
END
GO

-- Creación del SP 'AyDInventario' para que se puedan gestionar los productos
CREATE PROC [dbo].[AyDInventario]
    @Trans CHAR(10),
    @CodArt CHAR(10),
    @Cant DECIMAL(19, 4),
    @msg NVARCHAR(MAX) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @folio CHAR(10);
    SET @msg = ''; -- Inicializamos vacío para indicar éxito al VB

    -- 1. Generar el folio automáticamente usando tu SP existente
    -- Esto es necesario porque tu código VB no lo envía como parámetro
    EXEC dbo.generaFolio @Trans, @folio OUTPUT, @msg OUTPUT;

    -- Si hubo un error al generar el folio, salimos y devolvemos el error en @msg
    IF @msg <> '' RETURN;

    BEGIN TRY
        -- 2. Insertar en el encabezado de inventario
        -- Usamos usuario '1' por defecto ya que la interfaz no lo proporciona
        INSERT INTO operaciones_inventario (folio, transaccion, fecha, usuario, status)
        VALUES (@folio, @Trans, GETDATE(), '1', 'V');

        -- 3. Insertar el detalle del movimiento
        INSERT INTO moperaciones_inventario (folio, transaccion, cod_art, cantidad)
        VALUES (@folio, @Trans, @CodArt, @Cant);
    END TRY
    BEGIN CATCH
        SET @msg = 'Error en SQL: ' + ERROR_MESSAGE();
    END CATCH
END
GO

USE RYCSEM;
GO

-- Inserción de un proveedor de prueba
INSERT INTO proveedores (
    razon_social, 
    rfc, 
    telefono, 
    status, 
    usuario
)
VALUES (
    'Proveedor de Prueba S.A. de C.V.', -- razon_social
    'XAXX010101000',                -- rfc genérico
    '5551234567',                   -- telefono
    'V',                            -- status (V = Vigente)
    '1'                             -- usuario que lo registra
);
GO

USE RYCSEM;
GO

-- 1. Inserción de un TIPO de artículo (Ej. Smartphone, Tablet, Accesorio)
INSERT INTO tipos (tipo, nombre)
VALUES ('T0001', 'Smartphone');
GO

-- 2. Inserción de un MODELO de celular
INSERT INTO modelos (modelo, nombre)
VALUES ('M0001', 'iPhone 15 Pro');
GO