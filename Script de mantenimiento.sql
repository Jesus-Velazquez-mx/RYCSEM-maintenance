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