CREATE DATABASE bd_sgvcelulares;
USE bd_sgvcelulares;

CREATE TABLE idioma (
    idIdioma varchar(8) not null,
    nombre varchar(50) not null,
    constraint PK_idioma primary key (idIdioma)
);

CREATE TABLE usuario (
    dni VARCHAR(8) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    correo VARCHAR(50) NOT NULL,
    nombreUsuario VARCHAR(50) NOT NULL,
    password VARCHAR(64) NOT NULL,
    bloqueo BIT NOT NULL,
    activo BIT NOT NULL,
    cantIntentos TINYINT not null,
    idRol int not null,
    idIdioma varchar(8) not null,
    CONSTRAINT PK_usuario PRIMARY KEY (dni),
    CONSTRAINT FK_usuario_rol FOREIGN KEY (idRol) REFERENCES rol(idRol),
    CONSTRAINT FK_usuario_idioma FOREIGN KEY (idIdioma) REFERENCES idioma(idIdioma)
);

CREATE TABLE bitacora (
    idBitacora INT IDENTITY(1,1) NOT NULL,
    dni VARCHAR(8) NOT NULL,
    fecha DATETIME NOT NULL,
    modulo VARCHAR(50) NOT NULL,
    evento VARCHAR(50) NOT NULL,
    criticidad TINYINT NOT NULL,
    CONSTRAINT PK_bitacora PRIMARY KEY (idBitacora),
    CONSTRAINT FK_bitacora_usuario FOREIGN KEY (dni) REFERENCES usuario(dni)
);


-- Composite

create table rol (
    idRol int identity(1,1) not null,
    nombre varchar(50) not null,
    constraint pk_rol primary key (idRol)
);

create table familia(
    idFamilia int identity(1,1) not null,
    nombre varchar(50) not null,
    constraint pk_familia primary key (idFamilia)
);

create table rol_familia(
    idRol int not null,
    idFamilia int not null,
    constraint pk_rol_familia primary key (idRol, idFamilia),
    constraint fk_rol_familia_rol foreign key (idRol) references rol(idRol),
    constraint fk_rol_familia_familia foreign key (idFamilia) references familia(idFamilia)
);

create table familia_familia(
    idFamiliaPadre int not null,
    idFamiliaHija int not null,
    constraint pk_familia_familia primary key (idFamiliaPadre, idFamiliaHija),
    constraint fk_ff_padre foreign key (idFamiliaPadre) references familia(idFamilia),
    constraint fk_ff_hija foreign key (idFamiliaHija) references familia(idFamilia)
);

create table permiso(
    idPermiso int identity(1,1) not null,
    nombre varchar(50) not null,
    constraint pk_permiso primary key (idPermiso)
);

create table permiso_familia(
    idFamilia int not null,
    idPermiso int not null,
    constraint pk_permiso_familia primary key (idFamilia, idPermiso),
    constraint fk_permiso_familia_familia foreign key (idFamilia) references familia(idFamilia),
    constraint fk_permiso_familia_permiso foreign key (idPermiso) references permiso(idPermiso)
);

create table rol_permiso(
    idRol int not null,
    idPermiso int not null,
    constraint pk_rol_permiso primary key (idRol, idPermiso),
    constraint fk_rol_permiso_rol foreign key (idRol) references rol(idRol),
    constraint fk_rol_permiso_permiso foreign key (idPermiso) references permiso(idPermiso)
);

-- INSERT para Permiso
insert into permiso (nombre)
values
('Crear Usuario'),
('Modificar Usuario'),
('Desbloquear Usuario'),
('Activar Usuario'),
('Desactivar Usuario'),
('Consultar Bitácora'),
('Exportar Bitácora'),
('Crear Rol'),
('Crear Familia');


insert into idioma (idIdioma, nombre)
values
('es-AR','Spanish (Argentina)'),
('en-US','English (United States)');

insert into rol (nombre)
values
('Administrador');

INSERT INTO usuario
(
    dni,
    nombre,
    apellido,
    correo,
    nombreUsuario,
    password,
    bloqueo,
    activo,
    cantIntentos,
    idRol,
    idIdioma
)
VALUES
(
    '12345678',
    'Administrador',
    'Sistema',
    'admin@sgv.com',
    'admin',
    LOWER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'Admin!123'), 2)),
    0,
    1,
    0,
    1,
    'es-AR'
);

select * from idioma;
select * from usuario;
select * from bitacora;
select * from permiso;
select * from rol;
select * from familia;

-- Consulto a una familia determinada
select idFamilia, nombre from familia where idFamilia = 1;

-- Consulto los permisos de una familia determinada
select p.idPermiso, p.nombre from permiso p
inner join permiso_familia pf
on p.idPermiso = pf.idPermiso
where pf.idFamilia = 1;

-- Consulto las familias hijas de una familia determinada (familia padre)
select f.idFamilia, f.nombre from familia f 
inner join familia_familia ff
on f.idFamilia = ff.idFamiliaHija
where ff.idFamiliaPadre = 1;


/*
    usuarios test:
        admin
        Admin!123
        
        gaymer77777777
        Gaymer!123
*/

