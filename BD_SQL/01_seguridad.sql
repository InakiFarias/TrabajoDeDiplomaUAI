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

-- ---------------------------------------------------------------------
-- Permisos base
-- ---------------------------------------------------------------------
SET IDENTITY_INSERT permiso_351FI ON;
INSERT INTO permiso_351FI (idPermiso_351FI, nombre_351FI)
VALUES
    -- Técnicos
    (1,  N'Crear Usuario'),
    (2,  N'Modificar Usuario'),
    (3,  N'Desbloquear Usuario'),
    (4,  N'Activar Usuario'),
    (5,  N'Desactivar Usuario'),
    (6,  N'Consultar Bitácora'),
    (7,  N'Exportar Bitácora'),
    (8,  N'Crear Rol'),
    (9,  N'Crear Familia'),
    (10, N'Realizar Backup'),
    (11, N'Realizar Restore'),
    (12, N'Eliminar Rol'),
    (13, N'Eliminar Familia'),
    -- Negocio
    (14, N'Registrar Préstamo'),
    (15, N'Registrar Devolución'),
    (16, N'Cobrar Multa'),
    (17, N'Registrar Donación'),
    (18, N'Alta Socio'),
    (19, N'Modificar Socio'),
    (20, N'Baja Socio'),
    (21, N'Reactivar Socio'),
    (22, N'Alta Libro'),
    (23, N'Modificar Libro'),
    (24, N'Baja Libro'),
    (25, N'Reactivar Libro'),
    (26, N'Alta Ejemplar'),
    (27, N'Baja Ejemplar'),
    (28, N'Reactivar Ejemplar');
SET IDENTITY_INSERT permiso_351FI OFF;

-- ---------------------------------------------------------------------
-- Familias (siguen las secciones del menú principal)
-- ---------------------------------------------------------------------
SET IDENTITY_INSERT familia_351FI ON;
INSERT INTO familia_351FI (idFamilia_351FI, nombre_351FI)
VALUES
    -- Negocio
    (1,  N'Préstamos'),
    (2,  N'Multas y donaciones'),
    (3,  N'Gestión de socios'),
    (4,  N'Gestión de libros'),
    (5,  N'Gestión de ejemplares'),
    (6,  N'Socios y catálogo'),
    -- Técnicas
    (7,  N'Gestión de usuarios'),
    (8,  N'Gestión de roles'),
    (9,  N'Bitácora'),
    (10, N'Gestión de respaldo'),
    (11, N'Administración');
SET IDENTITY_INSERT familia_351FI OFF;

INSERT INTO permiso_familia_351FI (idFamilia_351FI, idPermiso_351FI)
VALUES
    -- Préstamos
    (1, 14), (1, 15),
    -- Multas y donaciones
    (2, 16), (2, 17),
    -- Gestión de socios
    (3, 18), (3, 19), (3, 20), (3, 21),
    -- Gestión de libros
    (4, 22), (4, 23), (4, 24), (4, 25),
    -- Gestión de ejemplares
    (5, 26), (5, 27), (5, 28),
    -- Gestión de usuarios
    (7, 1), (7, 2), (7, 3), (7, 4), (7, 5),
    -- Gestión de roles
    (8, 8), (8, 9), (8, 12), (8, 13),
    -- Bitácora
    (9, 6), (9, 7),
    -- Gestión de respaldo
    (10, 10), (10, 11);

-- Subfamilias
INSERT INTO familia_familia_351FI (idFamiliaPadre_351FI, idFamiliaHija_351FI)
VALUES
    -- Socios y catálogo = Gestión de socios + Gestión de libros + Gestión de ejemplares
    (6, 3), (6, 4), (6, 5),
    -- Administración = Gestión de usuarios + Gestión de roles + Bitácora + Gestión de respaldo
    (11, 7), (11, 8), (11, 9), (11, 10);

-- ---------------------------------------------------------------------
-- Roles
-- ---------------------------------------------------------------------
SET IDENTITY_INSERT rol_351FI ON;
INSERT INTO rol_351FI (idRol_351FI, nombre_351FI)
VALUES
    (1, N'Administrador'),
    (2, N'Bibliotecario');
SET IDENTITY_INSERT rol_351FI OFF;

INSERT INTO rol_familia_351FI (idRol_351FI, idFamilia_351FI)
VALUES
    -- Administrador: acciones técnicas y de negocio
    (1, 11), (1, 1), (1, 2), (1, 6),
    -- Bibliotecario: solo acciones de negocio
    (2, 1), (2, 2), (2, 6);

-- ---------------------------------------------------------------------
-- Usuarios iniciales
-- ---------------------------------------------------------------------
-- Administrador (contraseña: Admin!123) y bibliotecario de prueba (contraseña: Biblio!123), hash SHA-256
INSERT INTO usuario_351FI
    (dni_351FI, nombre_351FI, apellido_351FI, correo_351FI, nombreUsuario_351FI, password_351FI,
     bloqueo_351FI, activo_351FI, cantIntentos_351FI, idRol_351FI, idIdioma_351FI)
VALUES
    (N'12345678', N'Administrador', N'Sistema', N'admin@sgb.com', N'admin',
     LOWER(CONVERT(varchar(64), HASHBYTES('SHA2_256', 'Admin!123'), 2)),
     0, 1, 0, 1, N'es-AR'),
    (N'87654321', N'Bibliotecario', N'Prueba', N'bibliotecario@sgb.com', N'bibliotecario',
     LOWER(CONVERT(varchar(64), HASHBYTES('SHA2_256', 'Biblio!123'), 2)),
     0, 1, 0, 2, N'es-AR');
GO
