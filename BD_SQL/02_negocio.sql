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
CREATE TABLE Socio_351FI (
    NumeroSocio_351FI int IDENTITY(1,1) NOT NULL,
    Nombre_351FI      varchar(50)  NOT NULL,
    Apellido_351FI    varchar(50)  NOT NULL,
    Dni_351FI         varchar(10)  NOT NULL,
    Estado_351FI      varchar(15)  NOT NULL,
    CONSTRAINT PK_Socio PRIMARY KEY (NumeroSocio_351FI),
    CONSTRAINT UQ_Socio_Dni UNIQUE (Dni_351FI),
    CONSTRAINT CK_Socio_Estado CHECK (Estado_351FI IN ('Activo', 'Baja'))
);
GO

-- =====================================================================
-- Catálogo
-- =====================================================================
CREATE TABLE Autor_351FI (
    CodigoAutor_351FI int IDENTITY(1,1) NOT NULL,
    Nombre_351FI      varchar(50)       NOT NULL,
    Apellido_351FI    varchar(50)       NOT NULL,
    CONSTRAINT PK_Autor PRIMARY KEY (CodigoAutor_351FI)
);
GO

CREATE TABLE Tema_351FI (
    CodigoTema_351FI  int IDENTITY(1,1) NOT NULL,
    Descripcion_351FI varchar(100)      NOT NULL,
    CONSTRAINT PK_Tema PRIMARY KEY (CodigoTema_351FI)
);
GO

CREATE TABLE Libro_351FI (
    CodigoLibro_351FI varchar(20)  NOT NULL,
    Titulo_351FI      varchar(150) NOT NULL,
    Estado_351FI      varchar(15)  NOT NULL CONSTRAINT DF_Libro_Estado DEFAULT 'Activo',
    CONSTRAINT PK_Libro PRIMARY KEY (CodigoLibro_351FI),
    CONSTRAINT CK_Libro_Estado CHECK (Estado_351FI IN ('Activo', 'Baja'))
);
GO

CREATE TABLE Libro_Autor_351FI (
    CodigoLibro_351FI varchar(20) NOT NULL,
    CodigoAutor_351FI int         NOT NULL,
    CONSTRAINT PK_Libro_Autor PRIMARY KEY (CodigoLibro_351FI, CodigoAutor_351FI),
    CONSTRAINT FK_Libro_Autor_Libro FOREIGN KEY (CodigoLibro_351FI) REFERENCES Libro_351FI(CodigoLibro_351FI),
    CONSTRAINT FK_Libro_Autor_Autor FOREIGN KEY (CodigoAutor_351FI) REFERENCES Autor_351FI(CodigoAutor_351FI)
);
GO

CREATE TABLE Libro_Tema_351FI (
    CodigoLibro_351FI varchar(20) NOT NULL,
    CodigoTema_351FI  int         NOT NULL,
    CONSTRAINT PK_Libro_Tema PRIMARY KEY (CodigoLibro_351FI, CodigoTema_351FI),
    CONSTRAINT FK_Libro_Tema_Libro FOREIGN KEY (CodigoLibro_351FI) REFERENCES Libro_351FI(CodigoLibro_351FI),
    CONSTRAINT FK_Libro_Tema_Tema  FOREIGN KEY (CodigoTema_351FI)  REFERENCES Tema_351FI(CodigoTema_351FI)
);
GO

CREATE TABLE Ejemplar_351FI (
    CodigoEjemplar_351FI varchar(20) NOT NULL,
    CodigoLibro_351FI    varchar(20) NOT NULL,
    Estado_351FI         varchar(15) NOT NULL,
    CONSTRAINT PK_Ejemplar PRIMARY KEY (CodigoEjemplar_351FI),
    CONSTRAINT FK_Ejemplar_Libro FOREIGN KEY (CodigoLibro_351FI) REFERENCES Libro_351FI(CodigoLibro_351FI),
    CONSTRAINT CK_Ejemplar_Estado CHECK (Estado_351FI IN ('Disponible', 'Prestado', 'Baja'))
);
GO

-- =====================================================================
-- Préstamos
-- =====================================================================
CREATE TABLE Prestamo_351FI (
    NumeroPrestamo_351FI          int IDENTITY(1,1) NOT NULL,
    NumeroSocio_351FI             int               NOT NULL,
    FechaPrestamo_351FI           date              NOT NULL,
    FechaDevolucionPrevista_351FI date              NOT NULL,
    Estado_351FI                  varchar(15)       NOT NULL,
    CONSTRAINT PK_Prestamo PRIMARY KEY (NumeroPrestamo_351FI),
    CONSTRAINT FK_Prestamo_Socio FOREIGN KEY (NumeroSocio_351FI) REFERENCES Socio_351FI(NumeroSocio_351FI),
    CONSTRAINT CK_Prestamo_Estado CHECK (Estado_351FI IN ('Vigente', 'Finalizado')),
    CONSTRAINT CK_Prestamo_Fechas CHECK (FechaDevolucionPrevista_351FI >= FechaPrestamo_351FI)
);
GO

CREATE TABLE Prestamo_Ejemplar_351FI (
    NumeroPrestamo_351FI int         NOT NULL,
    CodigoEjemplar_351FI varchar(20) NOT NULL,
    CONSTRAINT PK_Prestamo_Ejemplar PRIMARY KEY (NumeroPrestamo_351FI, CodigoEjemplar_351FI),
    CONSTRAINT FK_Prestamo_Ejemplar_Prestamo FOREIGN KEY (NumeroPrestamo_351FI) REFERENCES Prestamo_351FI(NumeroPrestamo_351FI),
    CONSTRAINT FK_Prestamo_Ejemplar_Ejemplar FOREIGN KEY (CodigoEjemplar_351FI) REFERENCES Ejemplar_351FI(CodigoEjemplar_351FI)
);
GO

CREATE TABLE Comprobante_351FI (
    NumeroComprobante_351FI int IDENTITY(1,1) NOT NULL,
    NumeroPrestamo_351FI    int               NOT NULL,
    FechaEmision_351FI      date              NOT NULL,
    CONSTRAINT PK_Comprobante PRIMARY KEY (NumeroComprobante_351FI),
    CONSTRAINT UQ_Comprobante_Prestamo UNIQUE (NumeroPrestamo_351FI),
    CONSTRAINT FK_Comprobante_Prestamo FOREIGN KEY (NumeroPrestamo_351FI) REFERENCES Prestamo_351FI(NumeroPrestamo_351FI)
);
GO

-- =====================================================================
-- Devoluciones y multas
-- =====================================================================
CREATE TABLE Devolucion_351FI (
    NumeroDevolucion_351FI int IDENTITY(1,1) NOT NULL,
    NumeroPrestamo_351FI   int               NOT NULL,
    FechaDevolucion_351FI  date              NOT NULL,
    CONSTRAINT PK_Devolucion PRIMARY KEY (NumeroDevolucion_351FI),
    CONSTRAINT UQ_Devolucion_Prestamo UNIQUE (NumeroPrestamo_351FI),
    CONSTRAINT FK_Devolucion_Prestamo FOREIGN KEY (NumeroPrestamo_351FI) REFERENCES Prestamo_351FI(NumeroPrestamo_351FI)
);
GO

-- Comprobante que se emite al registrar una devolución
CREATE TABLE ComprobanteDevolucion_351FI (
    NumeroComprobante_351FI int IDENTITY(1,1) NOT NULL,
    NumeroDevolucion_351FI  int               NOT NULL,
    FechaEmision_351FI      date              NOT NULL,
    CONSTRAINT PK_ComprobanteDevolucion PRIMARY KEY (NumeroComprobante_351FI),
    CONSTRAINT UQ_ComprobanteDevolucion_Devolucion UNIQUE (NumeroDevolucion_351FI),
    CONSTRAINT FK_ComprobanteDevolucion_Devolucion FOREIGN KEY (NumeroDevolucion_351FI) REFERENCES Devolucion_351FI(NumeroDevolucion_351FI)
);
GO

-- Comprobante que se emite al cobrar el total adeudado de un socio (RF-002)
CREATE TABLE ComprobantePago_351FI (
    NumeroComprobante_351FI int IDENTITY(1,1) NOT NULL,
    NumeroSocio_351FI       int               NOT NULL,
    FechaEmision_351FI      date              NOT NULL,
    MetodoPago_351FI        varchar(10)       NOT NULL,
    Total_351FI             decimal(18,2)     NOT NULL,
    CONSTRAINT PK_ComprobantePago PRIMARY KEY (NumeroComprobante_351FI),
    CONSTRAINT FK_ComprobantePago_Socio FOREIGN KEY (NumeroSocio_351FI) REFERENCES Socio_351FI(NumeroSocio_351FI),
    CONSTRAINT CK_ComprobantePago_MetodoPago CHECK (MetodoPago_351FI IN ('Efectivo', 'Tarjeta')),
    CONSTRAINT CK_ComprobantePago_Total CHECK (Total_351FI > 0)
);
GO

CREATE TABLE Multa_351FI (
    NumeroMulta_351FI           int IDENTITY(1,1) NOT NULL,
    NumeroDevolucion_351FI      int               NOT NULL,
    DiasAtraso_351FI            int               NOT NULL,
    MontoPorDia_351FI           decimal(18,2)     NOT NULL,
    Monto_351FI                 decimal(18,2)     NOT NULL,
    FechaGeneracion_351FI       date              NOT NULL,
    FechaPago_351FI             date              NULL,
    Estado_351FI                varchar(20)       NOT NULL,
    NumeroComprobantePago_351FI int               NULL,
    CONSTRAINT PK_Multa PRIMARY KEY (NumeroMulta_351FI),
    CONSTRAINT FK_Multa_Devolucion FOREIGN KEY (NumeroDevolucion_351FI) REFERENCES Devolucion_351FI(NumeroDevolucion_351FI),
    CONSTRAINT FK_Multa_ComprobantePago FOREIGN KEY (NumeroComprobantePago_351FI) REFERENCES ComprobantePago_351FI(NumeroComprobante_351FI),
    CONSTRAINT CK_Multa_Estado CHECK (Estado_351FI IN ('Pendiente de pago', 'Pagada')),
    CONSTRAINT CK_Multa_DiasAtraso CHECK (DiasAtraso_351FI > 0)
);
GO

-- =====================================================================
-- Donaciones (RF-002)
-- =====================================================================
CREATE TABLE Donacion_351FI (
    NumeroDonacion_351FI int IDENTITY(1,1) NOT NULL,
    NumeroSocio_351FI    int               NOT NULL,
    FechaDonacion_351FI  date              NOT NULL,
    CONSTRAINT PK_Donacion PRIMARY KEY (NumeroDonacion_351FI),
    CONSTRAINT FK_Donacion_Socio FOREIGN KEY (NumeroSocio_351FI) REFERENCES Socio_351FI(NumeroSocio_351FI)
);
GO

-- Un ejemplar solo puede pertenecer a una donación (UQ sobre CodigoEjemplar)
CREATE TABLE Donacion_Ejemplar_351FI (
    NumeroDonacion_351FI int         NOT NULL,
    CodigoEjemplar_351FI varchar(20) NOT NULL,
    CONSTRAINT PK_Donacion_Ejemplar PRIMARY KEY (NumeroDonacion_351FI, CodigoEjemplar_351FI),
    CONSTRAINT UQ_Donacion_Ejemplar_Ejemplar UNIQUE (CodigoEjemplar_351FI),
    CONSTRAINT FK_Donacion_Ejemplar_Donacion FOREIGN KEY (NumeroDonacion_351FI) REFERENCES Donacion_351FI(NumeroDonacion_351FI),
    CONSTRAINT FK_Donacion_Ejemplar_Ejemplar FOREIGN KEY (CodigoEjemplar_351FI) REFERENCES Ejemplar_351FI(CodigoEjemplar_351FI)
);
GO

CREATE TABLE ReciboDonacion_351FI (
    NumeroRecibo_351FI   int IDENTITY(1,1) NOT NULL,
    NumeroDonacion_351FI int               NOT NULL,
    FechaEmision_351FI   date              NOT NULL,
    CONSTRAINT PK_ReciboDonacion PRIMARY KEY (NumeroRecibo_351FI),
    CONSTRAINT UQ_ReciboDonacion_Donacion UNIQUE (NumeroDonacion_351FI),
    CONSTRAINT FK_ReciboDonacion_Donacion FOREIGN KEY (NumeroDonacion_351FI) REFERENCES Donacion_351FI(NumeroDonacion_351FI)
);
GO
