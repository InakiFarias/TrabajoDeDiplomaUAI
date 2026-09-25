/*
    Sistema de Gestión de Biblioteca (SGB)
    Script 01 - Infraestructura de seguridad
    Crea la base de datos y las tablas de idiomas, dígitos verificadores,
    permisos (composite), usuarios y bitácora, con la carga inicial mínima.
    Las tablas del negocio se crean en 02_negocio.sql.
*/

IF DB_ID('bd_sgb') IS NULL
    CREATE DATABASE bd_sgb;
GO

USE bd_sgb;
GO

-- =====================================================================
-- Idiomas
-- =====================================================================
CREATE TABLE idioma (
    idIdioma varchar(8)  NOT NULL,
    nombre   varchar(50) NOT NULL,
    CONSTRAINT PK_idioma PRIMARY KEY (idIdioma)
);
GO

-- =====================================================================
-- Dígitos verificadores
-- =====================================================================
CREATE TABLE dvv (
    nombreTabla varchar(50) NOT NULL,
    valor       varchar(64) NOT NULL,
    CONSTRAINT PK_dvv PRIMARY KEY (nombreTabla)
);
GO

CREATE TABLE dvh (
    nombreTabla varchar(50) NOT NULL,
    idRegistro  varchar(50) NOT NULL,
    valor       varchar(64) NOT NULL,
    CONSTRAINT PK_dvh PRIMARY KEY (nombreTabla, idRegistro)
);
GO

-- =====================================================================
-- Permisos (composite)
-- =====================================================================
CREATE TABLE rol (
    idRol  int IDENTITY(1,1) NOT NULL,
    nombre varchar(50)       NOT NULL,
    CONSTRAINT PK_rol PRIMARY KEY (idRol)
);
GO

CREATE TABLE familia (
    idFamilia int IDENTITY(1,1) NOT NULL,
    nombre    varchar(50)       NOT NULL,
    CONSTRAINT PK_familia PRIMARY KEY (idFamilia)
);
GO

CREATE TABLE permiso (
    idPermiso int IDENTITY(1,1) NOT NULL,
    nombre    varchar(50)       NOT NULL,
    CONSTRAINT PK_permiso PRIMARY KEY (idPermiso)
);
GO

CREATE TABLE rol_familia (
    idRol     int NOT NULL,
    idFamilia int NOT NULL,
    CONSTRAINT PK_rol_familia PRIMARY KEY (idRol, idFamilia),
    CONSTRAINT FK_rol_familia_rol     FOREIGN KEY (idRol)     REFERENCES rol(idRol),
    CONSTRAINT FK_rol_familia_familia FOREIGN KEY (idFamilia) REFERENCES familia(idFamilia)
);
GO

CREATE TABLE familia_familia (
    idFamiliaPadre int NOT NULL,
    idFamiliaHija  int NOT NULL,
    CONSTRAINT PK_familia_familia PRIMARY KEY (idFamiliaPadre, idFamiliaHija),
    CONSTRAINT FK_ff_padre FOREIGN KEY (idFamiliaPadre) REFERENCES familia(idFamilia),
    CONSTRAINT FK_ff_hija  FOREIGN KEY (idFamiliaHija)  REFERENCES familia(idFamilia)
);
GO

CREATE TABLE permiso_familia (
    idFamilia int NOT NULL,
    idPermiso int NOT NULL,
    CONSTRAINT PK_permiso_familia PRIMARY KEY (idFamilia, idPermiso),
    CONSTRAINT FK_permiso_familia_familia FOREIGN KEY (idFamilia) REFERENCES familia(idFamilia),
    CONSTRAINT FK_permiso_familia_permiso FOREIGN KEY (idPermiso) REFERENCES permiso(idPermiso)
);
GO

CREATE TABLE rol_permiso (
    idRol     int NOT NULL,
    idPermiso int NOT NULL,
    CONSTRAINT PK_rol_permiso PRIMARY KEY (idRol, idPermiso),
    CONSTRAINT FK_rol_permiso_rol     FOREIGN KEY (idRol)     REFERENCES rol(idRol),
    CONSTRAINT FK_rol_permiso_permiso FOREIGN KEY (idPermiso) REFERENCES permiso(idPermiso)
);
GO

-- =====================================================================
-- Usuarios y bitácora
-- =====================================================================
CREATE TABLE usuario (
    dni           varchar(8)  NOT NULL,
    nombre        varchar(50) NOT NULL,
    apellido      varchar(50) NOT NULL,
    correo        varchar(50) NOT NULL,
    nombreUsuario varchar(50) NOT NULL,
    password      varchar(64) NOT NULL,
    bloqueo       bit         NOT NULL,
    activo        bit         NOT NULL,
    cantIntentos  tinyint     NOT NULL,
    idRol         int         NOT NULL,
    idIdioma      varchar(8)  NOT NULL,
    CONSTRAINT PK_usuario PRIMARY KEY (dni),
    CONSTRAINT FK_usuario_rol    FOREIGN KEY (idRol)    REFERENCES rol(idRol),
    CONSTRAINT FK_usuario_idioma FOREIGN KEY (idIdioma) REFERENCES idioma(idIdioma)
);
GO

CREATE TABLE bitacora (
    idBitacora int IDENTITY(1,1) NOT NULL,
    dni        varchar(8)  NOT NULL,
    fecha      datetime    NOT NULL,
    modulo     varchar(50) NOT NULL,
    evento     varchar(50) NOT NULL,
    criticidad tinyint     NOT NULL,
    CONSTRAINT PK_bitacora PRIMARY KEY (idBitacora),
    CONSTRAINT FK_bitacora_usuario FOREIGN KEY (dni) REFERENCES usuario(dni)
);
GO

-- =====================================================================
-- Carga inicial
-- =====================================================================
INSERT INTO idioma (idIdioma, nombre)
VALUES
    (N'es-AR', N'Español (Argentina)'),
    (N'en-US', N'English (United States)');

INSERT INTO permiso (nombre)
VALUES
    (N'Crear Usuario'),
    (N'Modificar Usuario'),
    (N'Desbloquear Usuario'),
    (N'Activar Usuario'),
    (N'Desactivar Usuario'),
    (N'Consultar Bitácora'),
    (N'Exportar Bitácora'),
    (N'Crear Rol'),
    (N'Crear Familia'),
    (N'Realizar Backup'),
    (N'Realizar Restore'),
    (N'Eliminar Rol'),
    (N'Eliminar Familia');

INSERT INTO rol (nombre)
VALUES (N'Administrador');

-- Usuario administrador inicial (contraseña: Admin!123, hash SHA-256)
INSERT INTO usuario
    (dni, nombre, apellido, correo, nombreUsuario, password,
     bloqueo, activo, cantIntentos, idRol, idIdioma)
VALUES
    (N'12345678', N'Administrador', N'Sistema', N'admin@sgb.com', N'admin',
     LOWER(CONVERT(varchar(64), HASHBYTES('SHA2_256', 'Admin!123'), 2)),
     0, 1, 0, 1, N'es-AR');

-- Asignar todos los permisos al rol Administrador
INSERT INTO rol_permiso (idRol, idPermiso)
SELECT 1, idPermiso
FROM permiso;
GO
