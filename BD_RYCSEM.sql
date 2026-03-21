
CREATE DATABASE RYCSEM
GO
USE RYCSEM;
GO

CREATE TABLE clientes
(
	cod_cte INT IDENTITY(1,1) PRIMARY KEY,
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

CREATE TABLE proveedores
(
	cod_prv INT IDENTITY(1,1) PRIMARY KEY,
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

CREATE TABLE articulos
(
	cod_art CHAR(10) NOT NULL PRIMARY KEY,
	descripcion VARCHAR(200),
	costo MONEY,
	precio MONEY,
	observaciones VARCHAR(500),
	status CHAR(3),
	imagen VARBINARY(MAX),
	nombre_imagen VARCHAR(200),
	usuario CHAR(10)
)

GO
CREATE TABLE transacciones
(
	transaccion CHAR(10) not null primary key,
	nombre VARCHAR(50),
	tabla VARCHAR(50),
	campo_id VARCHAR(50),
	serie char(1)
)
GO
CREATE TABLE dbo.usuarios
(
	usuario CHAR(10) NOT NULL PRIMARY KEY ,
	nombre VARCHAR(150) NULL,
	ap_paterno VARCHAR(80) NULL,
	ap_Materno VARCHAR(80) NULL,
	contrasena VARCHAR(20) NULL
)

GO
/*
select dbo.Encriptado('123')
select usuario, nombre, clave_secreta, dbo.Encriptado('123') from usuarios where usuario = '1'
*/

CREATE FUNCTION [dbo].[Encriptado](@C varchar(10)) 
RETURNS char(10)
AS
BEGIN
	declare @contraseña nvarchar(10)
	set @contraseña = ''
	if @c = '1234567890'
		return @C
	declare @cadena nvarchar(10)
	set @cadena = '[]{}#%&/()'
	declare @car char(1), @i tinyint, @v int
	set @i = 1
	while @i <= len(@c)
		begin
			set @v = ascii(substring(@cadena,@i,1)) + ascii(substring(@c,@i,1)) + @i - 1
			while @v > 255
				begin
					set @v = @v -255
				end
			set @car = char(@v)
			if @car = '' and @i = len(@c) 
				set @car = '%'
			set @contraseña = @contraseña + @car
			set @i = @i + 1
		end
	return isnull(@contraseña,'')
END

GO

insert into usuarios
values('1', 'Administrador', '', '', dbo.Encriptado('12345'))
select * from usuarios

/*	CREA USUARIOS

	DECLARE @c VARCHAR(10)
	SELECT @c = dbo.Encriptado('123')
	INSERT INTO usuarios (usuario, nombre, ap_paterno, ap_Materno, contrasena)
		VALUES ('1','Ricardo', 'Luna', 'Poon', @c);
GO
	DECLARE @c VARCHAR(10)
	SELECT @c = dbo.Encriptado('123')
	INSERT INTO usuarios (usuario, nombre, ap_paterno, ap_Materno, contrasena)
			VALUES ('2','Catalina', 'Sosa', 'Ochoa', @c);
*/

GO   
INSERT INTO transacciones(transaccion, nombre, tabla, campo_id, serie)
	VALUES ('01', 'Alta Articulos', 'articulos','cod_art','A');
GO
INSERT INTO transacciones (transaccion, nombre, tabla, campo_id, serie)
	VALUES ('02', 'Aumento de inventario', 'operaciones_inventario', 'folio', 'I');
GO

INSERT INTO transacciones (transaccion, nombre, tabla, campo_id, serie)
	VALUES ('03', 'Disminución de inventario', 'operaciones_inventario', 'folio', 'D'); 
GO
CREATE TABLE status
(
	status CHAR(3) NOT NULL PRIMARY KEY,
	abreviatura CHAR(3),
	descripcion VARCHAR(50)
)
GO
CREATE TABLE [dbo].[operaciones_inventario](
	[folio] [char](10) NOT NULL,
	[transaccion] [char](10) NULL,
	[fecha] [smalldatetime] NULL,
	[usuario] [char](10) NULL,
	[status] [char](1) NULL
)

GO
CREATE TABLE [dbo].[moperaciones_inventario](
	[id] [bigint] IDENTITY(-2147483648,1) NOT NULL primary key,
	[folio] [char](10) NULL,
	[transaccion] [char](10) NULL,
	[cod_art] [char](10) NULL,
	[cantidad] [decimal](19, 4) NULL
)
GO
INSERT INTO status (status, abreviatura, descripcion)
	VALUES ('V', 'VIG', 'VIGENTE');
GO
INSERT INTO status (status, abreviatura, descripcion)
	VALUES ('C', 'CAN', 'CANCELADO');
GO
INSERT INTO status (status, abreviatura, descripcion)
	VALUES ('S', 'SUS', 'SUSPENDIDO');

GO        
/*
SELECT dbo.direccionCompleta(1,'P')
*/

	CREATE FUNCTION dbo.direccionCompleta(@codigo INT, @tipo CHAR(5))
	RETURNS VARCHAR(500)
	BEGIN
	DECLARE @direccion VARCHAR(500)

	IF @tipo = 'C'
	BEGIN
    	SELECT  @direccion = CASE WHEN calle <> '' THEN
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

	/*
	SELECT dbo.nombreCompleto(1, 'P')
	*/
	CREATE FUNCTION dbo.nombreCompleto(@codigo INT, @tipo CHAR(5))
	RETURNS VARCHAR(500)
	BEGIN
	DECLARE @nombre VARCHAR(500)

	IF @tipo = 'C'
	BEGIN
    	SELECT @nombre = nombre + ' ' + ap_paterno + ' ' +ap_materno  
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


/*

	DECLARE @folio_ CHAR(10), @m_ NVARCHAR(MAX)
	EXEC  GENERAFOLIO '01',@folio_ output , @M_ OUTPUT
	SELECT @folio_ , @M_ AS ERRORES

*/
CREATE PROC [dbo].[generaFolio] @trans CHAR(5),@folio CHAR(10) OUTPUT , @msg NVARCHAR(MAX) OUTPUT
AS
BEGIN
	DECLARE @ultFolio CHAR(20), @tabla VARCHAR(50), @campo_id VARCHAR(50), @sql NVARCHAR(MAX),  @serie CHAR(1),@count INT 
	DECLARE @folios TABLE(folio INT)

	SET @msg = ''
	SET @count = 0	
	SELECT @tabla = tabla , @campo_id = campo_id, @serie = serie 
	FROM transacciones WITH(NOLOCK) WHERE transaccion = @trans 
	
	IF @tabla IS NULL
	BEGIN 
		SET @msg = 'No se encontró tabla para la transacción ' + @trans 
		RETURN
	END
	IF @campo_id IS NULL
	BEGIN
    	SET @msg = 'Campo en tabla de transacción ' + @trans + ' no registrado '
		RETURN
    END	
	IF @serie IS NULL
	BEGIN
    	SET @msg = 'No se ha definido una serie para la transacción ' + @trans 
		RETURN
    END	

	--SABER SI NO HAY DATOS PARA OBTENER EL PRIMER FOLIO
	SELECT @sql = ' SELECT @count = COUNT(*) FROM ' + @tabla	
	EXEC sp_executeSql	@sql, N'@count int  output',   @count = @count  output

	IF @count  = 0
		BEGIN
				SELECT @ultFolio = 1
		END	
	ELSE
		BEGIN
    		SELECT @sql = ' SELECT SUBSTRING(CAST( ' + @campo_id + ' AS CHAR(10)),  2, LEN(CAST(' + @campo_id + ' AS CHAR(10)) )) FROM ' + @tabla 

			--SELECT @sql --LUNA 
			INSERT INTO @folios
			EXEC sp_executeSql	@sql, N'@campo_id VARCHAR(50)', @campo_id  = @campo_id

			--SELECT *FROM @folios ---LUNA
			SELECT TOP 1 @ultFolio = folio + 1 FROM @folios ORDER BY folio DESC  
		END
	SELECT @folio =  UPPER(@serie) + REPLICATE('0',  4 - LEN(@ultFolio)) + @ultFolio	
    RETURN
END

GO

CREATE proc dbo.Login @usuario char(5), @clave varchar(10)
as
begin
	select usuario, nombre 
	from usuarios
	where usuario = @usuario and contrasena = dbo.encriptado(@clave)
end	

GO



/*
Exec dbo.Buscador 'operaciones_inventario', '02'
*/
CREATE proc [dbo].[Buscador] @Tabla varchar(30),  @Trans char(5) 
AS
Begin

	Declare @Datos table (codigo char(5), nombre varchar(200), fecha smalldatetime,
	visible_f bit, monto money, visible_m bit, status char(5))
	Declare @Columnas table(columna char(1), nombre varchar(100))
	Declare @SQL nvarchar(max)

	If @Tabla = 'articulos'
	BEGIN
		insert into @Datos
		select cod_art, descripcion, getdate(), 0 , precio, 1, status 
		from articulos with(nolock)

		Insert into @Columnas
		VALUES(1, 'Artículo')
		Insert into @Columnas
		VALUES(2, 'Descripción')
		Insert into @Columnas
		VALUES(3, 'Precio')
	
	END

	If @Tabla = 'clientes'
	BEGIN
		Insert into @Datos
		select cod_cte, razon_social, getdate(), 0, 0, 0, status 
		from clientes with(nolock)
		where status = 'V'

		Insert into @Columnas
		VALUES(1, 'Cliente')
		Insert into @Columnas
		VALUES(2, 'Razón social')
		Insert into @Columnas
		VALUES(3, ' ')
	END

	If @Tabla = 'proveedores'
	BEGIN
		Insert into @Datos
		select cod_prv, razon_social, getdate(), 0, 0, 0, status 
		from proveedores with(nolock)
		where status = 'V'

		Insert into @Columnas
		VALUES(1, 'Proveedor')
		Insert into @Columnas
		VALUES(2, 'Razón social')
		Insert into @Columnas
		VALUES(3, ' ')
	END
	Print @Tabla
    If @Tabla = 'operaciones_inventario'
	BEGIN
		
		Set @SQL = 'select oi.folio, t.nombre, oi.fecha, 1, sum(moi.cantidad), 1, oi.status 
		from operaciones_inventario oi with(nolock)
		inner join transacciones t with(nolock) on t.transaccion = oi.transaccion
		inner join moperaciones_inventario moi with(nolock) on moi.folio = oi.folio and moi.transaccion = oi.transaccion
		where status = ''V'''

		if @Trans <> ''
			Set @SQL = @SQL + ' and oi.transaccion = ''' + @Trans + ''''
		
		Set @SQL = @SQL + ' group by oi.folio, t.nombre, oi.fecha, oi.status'

		Insert into @Datos
		Exec sp_sqlexec @SQl

		Insert into @Columnas
		VALUES(1, 'Folio')
		Insert into @Columnas
		VALUES(2, 'Transacción')
		Insert into @Columnas
		VALUES(3, 'Cantidad')
	END

	select * from @Datos
	select * from @Columnas

End

GO

/*
Set dateformat dmy;
Exec dbo.FI003_Datos 'A0002', '04/03/2018 00:00', '04/03/2018 23:59', '', 0
*/
CREATE procedure [dbo].[FI003_Datos] @Art char(10), @FI smalldatetime, @FF smalldatetime, @Filtro varchar(200), @Actual bit as 
BEGIN
--Consulta de inventario
	set dateformat dmy;
	Declare @Inventario table(cod_art char(10), descripcion varchar(200), existencia money, precio money)
	Declare @Sql nvarchar(max)
	Declare @Ope char(10)
	Declare @Parametros nvarchar(500)
	Set @Ope = ' WHERE'
	Set @Parametros = ''

	Set @Sql = 'select  MOI.cod_art, A.descripcion, case when OI.transaccion = ''03'' then MOI.cantidad * -1 else MOI.cantidad end, A.precio
	from operaciones_inventario OI WITH(NOLOCK)
	inner join moperaciones_inventario MOI WITH(NOLOCK) ON OI.folio = MOI.folio and OI.transaccion = MOI.transaccion
	inner join articulos A WITH(NOLOCK) ON A.cod_art = MOI.cod_art '

	if @Filtro <> ''
	BEGIN
		Set @Sql = @Sql + @Filtro
		Set @Ope = ' AND'
	END

	if @Art <> ''
	BEGIN
		Set @Sql = @Sql + @Ope + ' MOI.cod_art = ''' + @Art + ''''
		Set @Ope = ' AND'
	END

	Set @Sql = @Sql + @Ope + ' OI.status = ''V'''
	Set @Ope = ' AND'

	if @Actual = 0 
		BEGIN
			Set @Sql = @Sql + @Ope + ' OI.fecha between ''' + convert(varchar(10), @FI, 103) + ' 00:00'' and ''' + convert(varchar(10), @FF, 103)  + ' 23:59'''
		END
print @Sql
	insert into @Inventario
	Exec sp_sqlexec @Sql 

	select cod_art, descripcion, sum(existencia) as existencia, precio from @Inventario 
	Group by cod_art, descripcion, precio
END

GO

alter table articulos add  modelo char(10)
GO

alter table articulos add tipo char(10)

GO

alter table articulos add porc_ganancia decimal(19,4)

GO

create table modelos (
modelo char(10), 
nombre varchar(250)
)

GO

create table tipos (
tipo char(10), 
nombre varchar(250)
)

GO

CREATE FUNCTION [dbo].[ObtenerValor](@codigo char(10), @trans CHAR(10))
	RETURNS money
	BEGIN
	DECLARE @valor money

	IF @trans = '01'
	BEGIN
    	SELECT @valor = sum(case when transaccion = '02' then cantidad else (cantidad * -1) end) 
		FROM moperaciones_inventario with(nolock)
		WHERE cod_art = @codigo
    END

	IF @trans = 'iva'
		Set @valor = 0--0.16
	
	--IF @trans = '08'
	--BEGIN
 --   	SELECT @Valor = SUM(importe)
	--	FROM abonos_proveedores 
	--	WHERE folio_aplicado = @codigo and transaccion_aplicado = @Trans
	--END
	IF @trans = 'I' --Ingreso
	Begin
		select @valor = sum(monto) 
		from movimientos_caja with(nolock)
		where turnoid = @codigo and tipo = 'I'
	End

	IF @trans = 'E' --Egreso
	Begin
		select @valor = sum(monto) 
		from movimientos_caja with(nolock)
		where turnoid = @codigo and tipo = 'E'
	End

	IF @trans = 'F'--Fondo
	Begin
		select @valor = sum(monto) 
		from turnos with(nolock)
		where turnoid = @codigo 
	End

	--IF @trans = 'VE' --Venta efectivo
	--Begin
	--	select @valor = sum(dfp.monto) from notas_venta nv with(nolock)
	--	inner join documentos_formas_pago dfp with(nolock) on nv.folio = dfp.folio
	--	where dfp.forma_pago = '01' and nv.folio in (select h.folio from historico_ventas_turno h with(nolock)
	--	where h.turnoid = @codigo AND status = 'V')
	--End


	--IF @trans = 'VT' --Venta tarjeta
	--Begin
	--	select @valor = sum(dfp.monto) from notas_venta nv with(nolock)
	--	inner join documentos_formas_pago dfp with(nolock) on nv.folio = dfp.folio
	--	where dfp.forma_pago <> '01' and nv.folio in (select h.folio from historico_ventas_turno h with(nolock)
	--	where h.turnoid = @codigo AND status = 'V')
	--End

	--IF @trans = 'PE' --Pago Efectivo 
	--Begin
	--	select @valor = sum(monto)
	--	from documentos_formas_pago with(nolock)
	--	where forma_pago = '01' and folio = @codigo
	--End

	--IF @trans = 'PT' --Pago Tarjeta 
	--Begin
	--	select @valor = sum(monto)
	--	from documentos_formas_pago with(nolock)
	--	where forma_pago <> '01' and folio = @codigo
	--End
	
	RETURN ISNULL(@valor,0)
	END

GO
CREATE TABLE [dbo].[movimientos_caja](
	[folio] [char](10) NOT NULL,
	[transaccion] [char](10) NOT NULL,
	[tipo] [char](2) NOT NULL,
	[monto] [decimal](19, 4) NULL,
	[fecha] [smalldatetime] NULL,
	[turnoid] [int] NULL,
	[usuario] [char](10) NULL,
	[notas] [varchar](300) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[movimientos_caja] ADD  DEFAULT ('') FOR [tipo]
GO

create table turnos(
turnoid int identity(1,1) not null,
usuario char(10) not null,
fecha_inicial datetime,
fecha_final datetime,
monto decimal, 
activo bit)
 GO

create table condiciones_pago(
condicion char(5) not null,
nombre varchar(250),
status char(3)
)