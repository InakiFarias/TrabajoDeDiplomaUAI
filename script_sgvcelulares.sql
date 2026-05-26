CREATE DATABASE bd_sgvcelulares;
USE bd_sgvcelulares;

CREATE TABLE usuarios (
    dni VARCHAR(8) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    correo VARCHAR(50) NOT NULL,
    nombreUsuario VARCHAR(50) NOT NULL,
    password VARCHAR(64) NOT NULL,
    bloqueo BIT NOT NULL,
    activo BIT NOT NULL,
    CONSTRAINT PK_usuarios PRIMARY KEY (dni)
);

CREATE TABLE bitacora (
    idBitacora INT IDENTITY(1,1) NOT NULL,
    dni VARCHAR(8) NOT NULL,
    fecha DATETIME NOT NULL,
    modulo VARCHAR(50) NOT NULL,
    evento VARCHAR(50) NOT NULL,
    criticidad TINYINT NOT NULL,
    CONSTRAINT PK_bitacora PRIMARY KEY (idBitacora),
    CONSTRAINT FK_bitacora_usuarios FOREIGN KEY (dni) REFERENCES usuarios(dni)
);

select * from usuarios;
select * from bitacora;