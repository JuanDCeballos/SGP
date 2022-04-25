CREATE DATABASE SGP

USE SGP

CREATE TABLE Genero (
	IdGenero INT IDENTITY(1,1) PRIMARY KEY,
	ValGenero VARCHAR(50)
);

CREATE TABLE TipoDocumento (
	IdTipoDoc INT IDENTITY(1,1) PRIMARY KEY,
	ValTipoDoc VARCHAR(50)
);

CREATE TABLE Rol (
	IdRol INT IDENTITY(1,1) PRIMARY KEY,
	ValRol VARCHAR(50)
);

CREATE TABLE Programa (
	IdPrograma INT IDENTITY(1,1) PRIMARY KEY,
	ValPrograma VARCHAR(50),
	Pensum VARCHAR (50)
);

CREATE TABLE Usuario (
	IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(100),
	Apellido VARCHAR(100),
	Genero INT FOREIGN KEY REFERENCES Genero(IdGenero),
	TipoDoc INT FOREIGN KEY REFERENCES TipoDocumento(IdTipoDoc),
	Documento VARCHAR(50),
	IdPrograma INT FOREIGN KEY REFERENCES ProgramaUsuario(IdProgramaUsuario),
	Email VARCHAR(200),
	Telefono INT,
	Rol INT FOREIGN KEY REFERENCES Rol(IdRol),
	Direccion VARCHAR(200),
	Pw VARCHAR(200),
	Egresado BIT
);

CREATE TABLE Entrevista (
	IdEntrevista INT IDENTITY(1,1) PRIMARY KEY,
	FechaEntrevista DATE,
	Estado VARCHAR(50),
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario)
);

CREATE TABLE Pagos (
	IdPago INT IDENTITY(1,1) PRIMARY KEY,
	Fecha DATE,
	Valor INT,
	ComprobantePago VARCHAR(200),
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario)
);

CREATE TABLE ProgramaUsuario (
	IdProgramaUsuario INT IDENTITY(1,1) PRIMARY KEY
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
	IdPrograma INT FOREIGN KEY REFERENCES Programa(IdPrograma)
);

CREATE TABLE Modulo (
	IdModulo INT IDENTITY(1,1) PRIMARY KEY,
	ValModulo VARCHAR(100),
	Creditos INT,
	IdPrograma INT FOREIGN KEY REFERENCES Programa(IdPrograma)
);

CREATE TABLE Homologacion (
	IdHomologacion INT IDENTITY(1,1) PRIMARY KEY,
	FechaHomologacion DATE,
	Universidad VARCHAR(200),
	Nota FLOAT,
	IdPrograma INT FOREIGN KEY REFERENCES Programa(IdPrograma),
	IdModulo INT FOREIGN KEY REFERENCES Modulo(IdModulo),
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario)
);

CREATE TABLE Programacion (
	IdProgramacion INT IDENTITY(1,1) PRIMARY KEY,
	FechaInicio DATE,
	FechaFin DATE,
	Bloque INT,
	Salon VARCHAR(50),
	Semestre VARCHAR(50),
	IdModulo INT FOREIGN KEY REFERENCES Modulo(IdModulo)
);