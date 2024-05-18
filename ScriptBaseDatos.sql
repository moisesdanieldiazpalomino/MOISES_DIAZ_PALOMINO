CREATE DATABASE colegio
GO 

USE colegio
GO

-------------------------------------------------
---------------CREACIÓN DE TABLAS ---------------
-------------------------------------------------
--CREACIÓN TABLA ALUMNOS---
CREATE TABLE alumnos(
codigo INT PRIMARY KEY IDENTITY(1,1),
nombres VARCHAR(100) not null,
apellidos VARCHAR(100) not null,
dni CHAR(8) not null,
fecha_nacimiento DATE not null,
direccion VARCHAR(250),
estado BIT DEFAULT '1',
fecha_registro DATETIME DEFAULT GETDATE()
)
GO 

--CREACIÓN TABLA CURSOS---
CREATE TABLE cursos(
codigo INT PRIMARY KEY IDENTITY(1,1),
descripcion VARCHAR(100) not null,
estado BIT DEFAULT '1'

)
GO

--CREACIÓN TABLA PROFESORES---
CREATE TABLE profesores(
codigo INT PRIMARY KEY IDENTITY(1,1),
nombres VARCHAR(100) not null,
apellidos VARCHAR(100) not null,
dni CHAR(8) not null,
direccion VARCHAR(250),
estado BIT DEFAULT '1'

)
GO

--CREACIÓN TABLA NOTAS---
CREATE TABLE notas(
codigo INT PRIMARY KEY IDENTITY(1,1),
nota INT CHECK( nota>=0 AND nota <=20),
codigo_alumno INT FOREIGN KEY REFERENCES alumnos(codigo),
codigo_curso INT FOREIGN KEY REFERENCES cursos(codigo),
fecha_registro DATETIME DEFAULT GETDATE()

)
GO

-------------------------------------------------
----CREACIÓN DE PROCEDIMIENTOS ALMACENADOS-------
-------------------------------------------------

-- PROCEDIMIENTO ALMACENADO LISTAR ALUMNOS---
CREATE PROCEDURE SP_LISTAR_ALUMNOS
AS
BEGIN
	SELECT * FROM alumnos ORDER BY codigo DESC
END
GO

-- PROCEDIMIENTO ALMACENADO REGISTRAR ALUMNOS---
CREATE PROCEDURE SP_REGISTRAR_ALUMNOS
(
@nombres VARCHAR(100),
@apellidos VARCHAR(100),
@dni CHAR(8),
@fecha_nacimiento DATE,
@direccion VARCHAR(250),
@mensaje VARCHAR(250) OUTPUT,
@resultado INT OUT
)
AS
BEGIN
	SET @resultado=0
	IF NOT EXISTS(SELECT * FROM alumnos WHERE dni=@dni)
		BEGIN
			INSERT INTO alumnos(nombres,apellidos,dni,fecha_nacimiento,direccion) VALUES
			(@nombres,@apellidos,@dni,@fecha_nacimiento,@direccion)

			SET @resultado= SCOPE_IDENTITY()
		END
	ELSE
		SET @mensaje= 'El alumno ya existe'
END
GO

-- PROCEDIMIENTO ALMACENADO EDITAR ALUMNOS---
CREATE PROCEDURE SP_EDITAR_ALUMNOS
(
@codigo INT,
@nombres VARCHAR(100),
@apellidos VARCHAR(100),
@dni CHAR(8),
@fecha_nacimiento DATE,
@direccion VARCHAR(250),
@mensaje VARCHAR(250) OUTPUT,
@resultado INT OUT
)
AS
BEGIN
	SET @resultado=0
	IF NOT EXISTS(SELECT * FROM alumnos WHERE dni=@dni AND codigo!=@codigo)
		BEGIN
			UPDATE ALUMNOS SET
			nombres=@nombres,
			apellidos=@apellidos,
			dni=@dni,
			fecha_nacimiento=@fecha_nacimiento,
			direccion=@direccion
			WHERE codigo=@codigo

			SET @Resultado=1
		END
	ELSE
		SET @mensaje= 'El alumno no existe'
END
GO

-- PROCEDIMIENTO ALMACENADO LISTAR ALUMNOS---
CREATE PROCEDURE SP_LISTAR_CURSOS
AS
BEGIN
	SELECT codigo,descripcion FROM cursos ORDER BY codigo DESC
END
GO

-- PROCEDIMIENTO ALMACENADO REGISTRAR NOTAS---
CREATE PROCEDURE SP_REGISTRAR_NOTAS(
@nota INT,
@codigo_alumno INT,
@codigo_curso INT,
@mensaje VARCHAR(250) OUTPUT,
@resultado INT OUT
)
AS
BEGIN
	SET @resultado=0
	IF  EXISTS(SELECT * FROM alumnos WHERE codigo=@codigo_alumno)
		BEGIN
			INSERT INTO notas(nota,codigo_alumno,codigo_curso) VALUES
			(@nota,@codigo_alumno,@codigo_curso)

			SET @resultado= SCOPE_IDENTITY()
		END
	ELSE
		SET @mensaje= 'El alumno no existe'
END
GO