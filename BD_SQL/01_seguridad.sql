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
CREATE TABLE idioma_351FI (
    idIdioma_351FI varchar(8)  NOT NULL,
    nombre_351FI   varchar(50) NOT NULL,
    CONSTRAINT PK_idioma PRIMARY KEY (idIdioma_351FI)
);
GO

-- =====================================================================
-- Dígitos verificadores
-- =====================================================================
CREATE TABLE dvv_351FI (
    nombreTabla_351FI varchar(50) NOT NULL,
    valor_351FI       varchar(64) NOT NULL,
    CONSTRAINT PK_dvv PRIMARY KEY (nombreTabla_351FI)
);
GO

CREATE TABLE dvh_351FI (
    nombreTabla_351FI varchar(50) NOT NULL,
    idRegistro_351FI  varchar(50) NOT NULL,
    valor_351FI       varchar(64) NOT NULL,
    CONSTRAINT PK_dvh PRIMARY KEY (nombreTabla_351FI, idRegistro_351FI)
);
GO

-- =====================================================================
-- Permisos (composite)
-- =====================================================================
CREATE TABLE rol_351FI (
    idRol_351FI  int IDENTITY(1,1) NOT NULL,
    nombre_351FI varchar(50)       NOT NULL,
    CONSTRAINT PK_rol PRIMARY KEY (idRol_351FI)
);
GO

CREATE TABLE familia_351FI (
    idFamilia_351FI int IDENTITY(1,1) NOT NULL,
    nombre_351FI    varchar(50)       NOT NULL,
    CONSTRAINT PK_familia PRIMARY KEY (idFamilia_351FI)
);
GO

CREATE TABLE permiso_351FI (
    idPermiso_351FI int IDENTITY(1,1) NOT NULL,
    nombre_351FI    varchar(50)       NOT NULL,
    CONSTRAINT PK_permiso PRIMARY KEY (idPermiso_351FI)
);
GO

CREATE TABLE rol_familia_351FI (
    idRol_351FI     int NOT NULL,
    idFamilia_351FI int NOT NULL,
    CONSTRAINT PK_rol_familia PRIMARY KEY (idRol_351FI, idFamilia_351FI),
    CONSTRAINT FK_rol_familia_rol     FOREIGN KEY (idRol_351FI)     REFERENCES rol_351FI(idRol_351FI),
    CONSTRAINT FK_rol_familia_familia FOREIGN KEY (idFamilia_351FI) REFERENCES familia_351FI(idFamilia_351FI)
);
GO

CREATE TABLE familia_familia_351FI (
    idFamiliaPadre_351FI int NOT NULL,
    idFamiliaHija_351FI  int NOT NULL,
    CONSTRAINT PK_familia_familia PRIMARY KEY (idFamiliaPadre_351FI, idFamiliaHija_351FI),
    CONSTRAINT FK_ff_padre FOREIGN KEY (idFamiliaPadre_351FI) REFERENCES familia_351FI(idFamilia_351FI),
    CONSTRAINT FK_ff_hija  FOREIGN KEY (idFamiliaHija_351FI)  REFERENCES familia_351FI(idFamilia_351FI)
);
GO

CREATE TABLE permiso_familia_351FI (
    idFamilia_351FI int NOT NULL,
    idPermiso_351FI int NOT NULL,
    CONSTRAINT PK_permiso_familia PRIMARY KEY (idFamilia_351FI, idPermiso_351FI),
    CONSTRAINT FK_permiso_familia_familia FOREIGN KEY (idFamilia_351FI) REFERENCES familia_351FI(idFamilia_351FI),
    CONSTRAINT FK_permiso_familia_permiso FOREIGN KEY (idPermiso_351FI) REFERENCES permiso_351FI(idPermiso_351FI)
);
GO

CREATE TABLE rol_permiso_351FI (
    idRol_351FI     int NOT NULL,
    idPermiso_351FI int NOT NULL,
    CONSTRAINT PK_rol_permiso PRIMARY KEY (idRol_351FI, idPermiso_351FI),
    CONSTRAINT FK_rol_permiso_rol     FOREIGN KEY (idRol_351FI)     REFERENCES rol_351FI(idRol_351FI),
    CONSTRAINT FK_rol_permiso_permiso FOREIGN KEY (idPermiso_351FI) REFERENCES permiso_351FI(idPermiso_351FI)
);
GO

-- =====================================================================
-- Usuarios y bitácora
-- =====================================================================
CREATE TABLE usuario_351FI (
    dni_351FI           varchar(8)  NOT NULL,
    nombre_351FI        varchar(50) NOT NULL,
    apellido_351FI      varchar(50) NOT NULL,
    correo_351FI        varchar(50) NOT NULL,
    nombreUsuario_351FI varchar(50) NOT NULL,
    password_351FI      varchar(64) NOT NULL,
    bloqueo_351FI       bit         NOT NULL,
    activo_351FI        bit         NOT NULL,
    cantIntentos_351FI  tinyint     NOT NULL,
    idRol_351FI         int         NOT NULL,
    idIdioma_351FI      varchar(8)  NOT NULL,
    CONSTRAINT PK_usuario PRIMARY KEY (dni_351FI),
    CONSTRAINT FK_usuario_rol    FOREIGN KEY (idRol_351FI)    REFERENCES rol_351FI(idRol_351FI),
    CONSTRAINT FK_usuario_idioma FOREIGN KEY (idIdioma_351FI) REFERENCES idioma_351FI(idIdioma_351FI)
);
GO

CREATE TABLE bitacora_351FI (
    idBitacora_351FI int IDENTITY(1,1) NOT NULL,
    dni_351FI        varchar(8)  NOT NULL,
    fecha_351FI      datetime    NOT NULL,
    modulo_351FI     varchar(50) NOT NULL,
    evento_351FI     varchar(50) NOT NULL,
    criticidad_351FI tinyint     NOT NULL,
    CONSTRAINT PK_bitacora PRIMARY KEY (idBitacora_351FI),
    CONSTRAINT FK_bitacora_usuario FOREIGN KEY (dni_351FI) REFERENCES usuario_351FI(dni_351FI)
);
GO

-- =====================================================================
-- Carga inicial
-- =====================================================================
INSERT INTO idioma_351FI (idIdioma_351FI, nombre_351FI)
VALUES
    (N'es-AR', N'Español (Argentina)'),
    (N'en-US', N'English (United States)');

INSERT INTO permiso_351FI (nombre_351FI)
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

INSERT INTO rol_351FI (nombre_351FI)
VALUES (N'Administrador');

-- Usuario administrador inicial (contraseña: Admin!123, hash SHA-256)
INSERT INTO usuario_351FI
    (dni_351FI, nombre_351FI, apellido_351FI, correo_351FI, nombreUsuario_351FI, password_351FI,
     bloqueo_351FI, activo_351FI, cantIntentos_351FI, idRol_351FI, idIdioma_351FI)
VALUES
    (N'12345678', N'Administrador', N'Sistema', N'admin@sgb.com', N'admin',
     LOWER(CONVERT(varchar(64), HASHBYTES('SHA2_256', 'Admin!123'), 2)),
     0, 1, 0, 1, N'es-AR');

-- Asignar todos los permisos al rol Administrador
INSERT INTO rol_permiso_351FI (idRol_351FI, idPermiso_351FI)
SELECT 1, idPermiso_351FI
FROM permiso_351FI;
GO
