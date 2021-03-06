USE master
GO
DROP DATABASE cuentasxpagar
GO
CREATE DATABASE cuentasxpagar
GO
    USE cuentasxpagar
GO
    CREATE TABLE Login (
        id_user INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
        username VARCHAR(60),
        password VARCHAR(1000),
        privilegio VARCHAR(10)
    )
GO
    CREATE TABLE ConceptosDePago (
        id_pago INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
        descripcion VARCHAR(1000),
        estado VARCHAR(100)
    )
GO
    CREATE TABLE Proveedores (
        id_proveedor INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
        id_pago INT NOT NULL FOREIGN KEY REFERENCES ConceptosDePago(id_pago),
        nombre VARCHAR(80),
        cedula_RNC CHAR(15),
        tipo_de_persona VARCHAR(15),
        balance FLOAT,
        estado VARCHAR(100)
    )
GO
    CREATE TABLE DocumentosXPagar (
        id_documento INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
        id_proveedor INT NOT NULL FOREIGN KEY REFERENCES Proveedores(id_proveedor),
        no_factura INT,
        fecha_documento DATE,
        fecha_de_registro DATE,
        fecha_de_vencimiento DATE,
        monto FLOAT,
        estado VARCHAR(30)
    )
GO
    CREATE TABLE GestionDePago (
        id_solicitud INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
        id_proveedor INT NOT NULL FOREIGN KEY REFERENCES Proveedores(id_proveedor),
        descripcion VARCHAR(1000),
        fecha_de_pago DATE,
        monto FLOAT
    )
GO
    CREATE TABLE Parametros (
        id_parametro INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
        mes_de_proceso CHAR(20),
        anio_de_proceso CHAR(10),
        cierre_ejecutado VARCHAR(50)
    )
GO
    CREATE TABLE Cierre (
        id_cierre INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
        id_parametros INT NOT NULL FOREIGN KEY REFERENCES Parametros(id_parametro),
        monto FLOAT
    ) 
GO
	CREATE TABLE Meses (
		id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
		nombre VARCHAR(20)
	)
GO
	CREATE TABLE Anios (
		id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
		nombre VARCHAR(20)
	)
GO
	CREATE TABLE CierreEjecutado (
		id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
		opcion VARCHAR(20)
	)

-- Default data
INSERT INTO
    Login(username, password, privilegio)
VALUES
    ('admin', 'admin1234', 'admin')
GO
INSERT INTO
	Meses(nombre)
VALUES
	(''),
	('Enero'),
	('Febrero'),
	('Marzo'),
	('Abril'),
	('Mayo'),
	('Junio'),
	('Julio'),
	('Agosto'),
	('Septiembre'),
	('Octubre'),
	('Noviembre'),
	('Diciembre')
GO
INSERT INTO
	Anios(nombre)
VALUES
	(''),
	('2022'),
	('2023'),
	('2024'),
	('2025'),
	('2026'),
	('2027'),
	('2028'),
	('2029'),
	('2030'),
	('2031')
GO
INSERT INTO
	CierreEjecutado(opcion)
VALUES
	(''),
	('Ejecutado'),
	('No Ejecutado')