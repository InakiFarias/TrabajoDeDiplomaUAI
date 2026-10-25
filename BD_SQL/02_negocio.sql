/*
    Sistema de Gestión de Biblioteca (SGB)
    Script 02 - Tablas del negocio
    Ejecutar después de 01_seguridad.sql.
*/

USE bd_sgb;
GO

-- =====================================================================
-- Socios
-- =====================================================================
CREATE TABLE Socio (
    NumeroSocio int IDENTITY(1,1) NOT NULL,
    Nombre      varchar(50)  NOT NULL,
    Apellido    varchar(50)  NOT NULL,
    Dni         varchar(10)  NOT NULL,
    Estado      varchar(15)  NOT NULL,
    CONSTRAINT PK_Socio PRIMARY KEY (NumeroSocio),
    CONSTRAINT UQ_Socio_Dni UNIQUE (Dni),
    CONSTRAINT CK_Socio_Estado CHECK (Estado IN ('Activo', 'Baja'))
);
GO

-- =====================================================================
-- Catálogo
-- =====================================================================
CREATE TABLE Autor (
    CodigoAutor int IDENTITY(1,1) NOT NULL,
    Nombre      varchar(50)       NOT NULL,
    Apellido    varchar(50)       NOT NULL,
    CONSTRAINT PK_Autor PRIMARY KEY (CodigoAutor)
);
GO

CREATE TABLE Tema (
    CodigoTema  int IDENTITY(1,1) NOT NULL,
    Descripcion varchar(100)      NOT NULL,
    CONSTRAINT PK_Tema PRIMARY KEY (CodigoTema)
);
GO

CREATE TABLE Libro (
    CodigoLibro varchar(20)  NOT NULL,
    Titulo      varchar(150) NOT NULL,
    Estado      varchar(15)  NOT NULL CONSTRAINT DF_Libro_Estado DEFAULT 'Activo',
    CONSTRAINT PK_Libro PRIMARY KEY (CodigoLibro),
    CONSTRAINT CK_Libro_Estado CHECK (Estado IN ('Activo', 'Baja'))
);
GO

CREATE TABLE Libro_Autor (
    CodigoLibro varchar(20) NOT NULL,
    CodigoAutor int         NOT NULL,
    CONSTRAINT PK_Libro_Autor PRIMARY KEY (CodigoLibro, CodigoAutor),
    CONSTRAINT FK_Libro_Autor_Libro FOREIGN KEY (CodigoLibro) REFERENCES Libro(CodigoLibro),
    CONSTRAINT FK_Libro_Autor_Autor FOREIGN KEY (CodigoAutor) REFERENCES Autor(CodigoAutor)
);
GO

CREATE TABLE Libro_Tema (
    CodigoLibro varchar(20) NOT NULL,
    CodigoTema  int         NOT NULL,
    CONSTRAINT PK_Libro_Tema PRIMARY KEY (CodigoLibro, CodigoTema),
    CONSTRAINT FK_Libro_Tema_Libro FOREIGN KEY (CodigoLibro) REFERENCES Libro(CodigoLibro),
    CONSTRAINT FK_Libro_Tema_Tema  FOREIGN KEY (CodigoTema)  REFERENCES Tema(CodigoTema)
);
GO

CREATE TABLE Ejemplar (
    CodigoEjemplar varchar(20) NOT NULL,
    CodigoLibro    varchar(20) NOT NULL,
    Estado         varchar(15) NOT NULL,
    CONSTRAINT PK_Ejemplar PRIMARY KEY (CodigoEjemplar),
    CONSTRAINT FK_Ejemplar_Libro FOREIGN KEY (CodigoLibro) REFERENCES Libro(CodigoLibro),
    CONSTRAINT CK_Ejemplar_Estado CHECK (Estado IN ('Disponible', 'Prestado', 'Baja'))
);
GO

-- =====================================================================
-- Préstamos
-- =====================================================================
CREATE TABLE Prestamo (
    NumeroPrestamo          int IDENTITY(1,1) NOT NULL,
    NumeroSocio             int               NOT NULL,
    FechaPrestamo           date              NOT NULL,
    FechaDevolucionPrevista date              NOT NULL,
    Estado                  varchar(15)       NOT NULL,
    CONSTRAINT PK_Prestamo PRIMARY KEY (NumeroPrestamo),
    CONSTRAINT FK_Prestamo_Socio FOREIGN KEY (NumeroSocio) REFERENCES Socio(NumeroSocio),
    CONSTRAINT CK_Prestamo_Estado CHECK (Estado IN ('Vigente', 'Finalizado')),
    CONSTRAINT CK_Prestamo_Fechas CHECK (FechaDevolucionPrevista >= FechaPrestamo)
);
GO

CREATE TABLE Prestamo_Ejemplar (
    NumeroPrestamo int         NOT NULL,
    CodigoEjemplar varchar(20) NOT NULL,
    CONSTRAINT PK_Prestamo_Ejemplar PRIMARY KEY (NumeroPrestamo, CodigoEjemplar),
    CONSTRAINT FK_Prestamo_Ejemplar_Prestamo FOREIGN KEY (NumeroPrestamo) REFERENCES Prestamo(NumeroPrestamo),
    CONSTRAINT FK_Prestamo_Ejemplar_Ejemplar FOREIGN KEY (CodigoEjemplar) REFERENCES Ejemplar(CodigoEjemplar)
);
GO

CREATE TABLE Comprobante (
    NumeroComprobante int IDENTITY(1,1) NOT NULL,
    NumeroPrestamo    int               NOT NULL,
    FechaEmision      date              NOT NULL,
    CONSTRAINT PK_Comprobante PRIMARY KEY (NumeroComprobante),
    CONSTRAINT UQ_Comprobante_Prestamo UNIQUE (NumeroPrestamo),
    CONSTRAINT FK_Comprobante_Prestamo FOREIGN KEY (NumeroPrestamo) REFERENCES Prestamo(NumeroPrestamo)
);
GO

-- =====================================================================
-- Devoluciones y multas
-- =====================================================================
CREATE TABLE Devolucion (
    NumeroDevolucion int IDENTITY(1,1) NOT NULL,
    NumeroPrestamo   int               NOT NULL,
    FechaDevolucion  date              NOT NULL,
    CONSTRAINT PK_Devolucion PRIMARY KEY (NumeroDevolucion),
    CONSTRAINT UQ_Devolucion_Prestamo UNIQUE (NumeroPrestamo),
    CONSTRAINT FK_Devolucion_Prestamo FOREIGN KEY (NumeroPrestamo) REFERENCES Prestamo(NumeroPrestamo)
);
GO

-- Comprobante que se emite al cobrar el total adeudado de un socio (RF-002)
CREATE TABLE ComprobantePago (
    NumeroComprobante int IDENTITY(1,1) NOT NULL,
    NumeroSocio       int               NOT NULL,
    FechaEmision      date              NOT NULL,
    Total             decimal(18,2)     NOT NULL,
    CONSTRAINT PK_ComprobantePago PRIMARY KEY (NumeroComprobante),
    CONSTRAINT FK_ComprobantePago_Socio FOREIGN KEY (NumeroSocio) REFERENCES Socio(NumeroSocio),
    CONSTRAINT CK_ComprobantePago_Total CHECK (Total > 0)
);
GO

CREATE TABLE Multa (
    NumeroMulta           int IDENTITY(1,1) NOT NULL,
    NumeroDevolucion      int               NOT NULL,
    DiasAtraso            int               NOT NULL,
    MontoPorDia           decimal(18,2)     NOT NULL,
    Monto                 decimal(18,2)     NOT NULL,
    FechaGeneracion       date              NOT NULL,
    FechaPago             date              NULL,
    Estado                varchar(20)       NOT NULL,
    NumeroComprobantePago int               NULL,
    CONSTRAINT PK_Multa PRIMARY KEY (NumeroMulta),
    CONSTRAINT FK_Multa_Devolucion FOREIGN KEY (NumeroDevolucion) REFERENCES Devolucion(NumeroDevolucion),
    CONSTRAINT FK_Multa_ComprobantePago FOREIGN KEY (NumeroComprobantePago) REFERENCES ComprobantePago(NumeroComprobante),
    CONSTRAINT CK_Multa_Estado CHECK (Estado IN ('Pendiente de pago', 'Pagada')),
    CONSTRAINT CK_Multa_DiasAtraso CHECK (DiasAtraso > 0)
);
GO

-- =====================================================================
-- Donaciones (RF-002)
-- =====================================================================
CREATE TABLE Donacion (
    NumeroDonacion int IDENTITY(1,1) NOT NULL,
    NumeroSocio    int               NOT NULL,
    FechaDonacion  date              NOT NULL,
    CONSTRAINT PK_Donacion PRIMARY KEY (NumeroDonacion),
    CONSTRAINT FK_Donacion_Socio FOREIGN KEY (NumeroSocio) REFERENCES Socio(NumeroSocio)
);
GO

-- Un ejemplar solo puede pertenecer a una donación (UQ sobre CodigoEjemplar)
CREATE TABLE Donacion_Ejemplar (
    NumeroDonacion int         NOT NULL,
    CodigoEjemplar varchar(20) NOT NULL,
    CONSTRAINT PK_Donacion_Ejemplar PRIMARY KEY (NumeroDonacion, CodigoEjemplar),
    CONSTRAINT UQ_Donacion_Ejemplar_Ejemplar UNIQUE (CodigoEjemplar),
    CONSTRAINT FK_Donacion_Ejemplar_Donacion FOREIGN KEY (NumeroDonacion) REFERENCES Donacion(NumeroDonacion),
    CONSTRAINT FK_Donacion_Ejemplar_Ejemplar FOREIGN KEY (CodigoEjemplar) REFERENCES Ejemplar(CodigoEjemplar)
);
GO

CREATE TABLE ReciboDonacion (
    NumeroRecibo   int IDENTITY(1,1) NOT NULL,
    NumeroDonacion int               NOT NULL,
    FechaEmision   date              NOT NULL,
    CONSTRAINT PK_ReciboDonacion PRIMARY KEY (NumeroRecibo),
    CONSTRAINT UQ_ReciboDonacion_Donacion UNIQUE (NumeroDonacion),
    CONSTRAINT FK_ReciboDonacion_Donacion FOREIGN KEY (NumeroDonacion) REFERENCES Donacion(NumeroDonacion)
);
GO
