/*
    Sistema de Gestión de Biblioteca (SGB)
    Script 03 - Carga inicial de datos
    Socios y catálogo preexistentes de la biblioteca.
    Ejecutar después de 02_negocio.sql.
*/

USE bd_sgb;
GO

SET XACT_ABORT ON;
BEGIN TRANSACTION;

-- =====================================================================
-- Socios
-- =====================================================================
INSERT INTO Socio (NumeroSocio, Nombre, Apellido, Dni, Estado)
VALUES
    (1001, N'María', N'González', N'28456123', N'Activo'),
    (1002, N'Juan Carlos', N'Pérez', N'17234567', N'Activo'),
    (1003, N'Lucía', N'Fernández', N'40123789', N'Activo'),
    (1004, N'Roberto', N'Gómez', N'12987654', N'Activo'),
    (1005, N'Ana', N'Martínez', N'35678901', N'Activo'),
    (1006, N'Carlos', N'López', N'22345678', N'Activo'),
    (1007, N'Sofía', N'Díaz', N'43210987', N'Activo'),
    (1008, N'Jorge', N'Romero', N'14567890', N'Activo'),
    (1009, N'Valentina', N'Sosa', N'44876543', N'Activo'),
    (1010, N'Miguel Ángel', N'Torres', N'20123456', N'Activo'),
    (1011, N'Graciela', N'Álvarez', N'11234987', N'Activo'),
    (1012, N'Martín', N'Ruiz', N'38901234', N'Activo'),
    (1013, N'Elena', N'Benítez', N'16789012', N'Baja'),
    (1014, N'Diego', N'Acosta', N'31456789', N'Baja'),
    (1015, N'Camila', N'Medina', N'42345612', N'Activo');

-- =====================================================================
-- Autores
-- =====================================================================
SET IDENTITY_INSERT Autor ON;
INSERT INTO Autor (CodigoAutor, Nombre, Apellido)
VALUES
    (1, N'Julio', N'Cortázar'),
    (2, N'Jorge Luis', N'Borges'),
    (3, N'Ernesto', N'Sabato'),
    (4, N'José', N'Hernández'),
    (5, N'Ricardo', N'Güiraldes'),
    (6, N'Gabriel', N'García Márquez'),
    (7, N'Isabel', N'Allende'),
    (8, N'Eduardo', N'Galeano'),
    (9, N'Joaquín Salvador', N'Lavado (Quino)'),
    (10, N'Horacio', N'Quiroga'),
    (11, N'Rodolfo', N'Walsh'),
    (12, N'Héctor Germán', N'Oesterheld'),
    (13, N'Francisco', N'Solano López'),
    (14, N'José Luis', N'Romero'),
    (15, N'Domingo Faustino', N'Sarmiento'),
    (16, N'Antoine', N'de Saint-Exupéry'),
    (17, N'Stephen', N'Hawking'),
    (18, N'Carl', N'Sagan'),
    (19, N'Elsa', N'Ferrán');
SET IDENTITY_INSERT Autor OFF;

-- =====================================================================
-- Temas
-- =====================================================================
SET IDENTITY_INSERT Tema ON;
INSERT INTO Tema (CodigoTema, Descripcion)
VALUES
    (1, N'Novela'),
    (2, N'Cuento'),
    (3, N'Poesía'),
    (4, N'Historia'),
    (5, N'Historieta'),
    (6, N'Ensayo'),
    (7, N'Ciencia'),
    (8, N'Literatura infantil');
SET IDENTITY_INSERT Tema OFF;

-- =====================================================================
-- Libros
-- =====================================================================
INSERT INTO Libro (CodigoLibro, Titulo)
VALUES
    ('LIB-0001', N'Rayuela'),
    ('LIB-0002', N'Bestiario'),
    ('LIB-0003', N'Ficciones'),
    ('LIB-0004', N'El Aleph'),
    ('LIB-0005', N'El túnel'),
    ('LIB-0006', N'Sobre héroes y tumbas'),
    ('LIB-0007', N'Martín Fierro'),
    ('LIB-0008', N'Don Segundo Sombra'),
    ('LIB-0009', N'Cien años de soledad'),
    ('LIB-0010', N'El amor en los tiempos del cólera'),
    ('LIB-0011', N'La casa de los espíritus'),
    ('LIB-0012', N'Las venas abiertas de América Latina'),
    ('LIB-0013', N'Toda Mafalda'),
    ('LIB-0014', N'Cuentos de la selva'),
    ('LIB-0015', N'Cuentos de amor de locura y de muerte'),
    ('LIB-0016', N'Operación Masacre'),
    ('LIB-0017', N'El Eternauta'),
    ('LIB-0018', N'Breve historia de la Argentina'),
    ('LIB-0019', N'Facundo'),
    ('LIB-0020', N'El principito'),
    ('LIB-0021', N'Breve historia del tiempo'),
    ('LIB-0022', N'Cosmos'),
    ('LIB-0023', N'Crónicas de Villa Crespo');

INSERT INTO Libro_Autor (CodigoLibro, CodigoAutor)
VALUES
    ('LIB-0001', 1),
    ('LIB-0002', 1),
    ('LIB-0003', 2),
    ('LIB-0004', 2),
    ('LIB-0005', 3),
    ('LIB-0006', 3),
    ('LIB-0007', 4),
    ('LIB-0008', 5),
    ('LIB-0009', 6),
    ('LIB-0010', 6),
    ('LIB-0011', 7),
    ('LIB-0012', 8),
    ('LIB-0013', 9),
    ('LIB-0014', 10),
    ('LIB-0015', 10),
    ('LIB-0016', 11),
    ('LIB-0017', 12),
    ('LIB-0017', 13),
    ('LIB-0018', 14),
    ('LIB-0019', 15),
    ('LIB-0020', 16),
    ('LIB-0021', 17),
    ('LIB-0022', 18),
    ('LIB-0023', 19);

-- 'Crónicas de Villa Crespo' queda sin tema asignado a propósito (caso "Sin tema" de RF-002)
INSERT INTO Libro_Tema (CodigoLibro, CodigoTema)
VALUES
    ('LIB-0001', 1),
    ('LIB-0002', 2),
    ('LIB-0003', 2),
    ('LIB-0004', 2),
    ('LIB-0005', 1),
    ('LIB-0006', 1),
    ('LIB-0007', 3),
    ('LIB-0008', 1),
    ('LIB-0009', 1),
    ('LIB-0010', 1),
    ('LIB-0011', 1),
    ('LIB-0012', 6),
    ('LIB-0012', 4),
    ('LIB-0013', 5),
    ('LIB-0014', 2),
    ('LIB-0014', 8),
    ('LIB-0015', 2),
    ('LIB-0016', 4),
    ('LIB-0017', 5),
    ('LIB-0018', 4),
    ('LIB-0019', 6),
    ('LIB-0019', 4),
    ('LIB-0020', 8),
    ('LIB-0021', 7),
    ('LIB-0022', 7);

-- =====================================================================
-- Ejemplares
-- =====================================================================
INSERT INTO Ejemplar (CodigoEjemplar, CodigoLibro, Estado)
VALUES
    ('EJ-00001', 'LIB-0001', N'Disponible'),
    ('EJ-00002', 'LIB-0001', N'Disponible'),
    ('EJ-00003', 'LIB-0001', N'Disponible'),
    ('EJ-00004', 'LIB-0002', N'Disponible'),
    ('EJ-00005', 'LIB-0002', N'Disponible'),
    ('EJ-00006', 'LIB-0003', N'Disponible'),
    ('EJ-00007', 'LIB-0003', N'Disponible'),
    ('EJ-00008', 'LIB-0003', N'Disponible'),
    ('EJ-00009', 'LIB-0004', N'Disponible'),
    ('EJ-00010', 'LIB-0004', N'Disponible'),
    ('EJ-00011', 'LIB-0005', N'Disponible'),
    ('EJ-00012', 'LIB-0005', N'Disponible'),
    ('EJ-00013', 'LIB-0006', N'Disponible'),
    ('EJ-00014', 'LIB-0007', N'Disponible'),
    ('EJ-00015', 'LIB-0007', N'Disponible'),
    ('EJ-00016', 'LIB-0007', N'Disponible'),
    ('EJ-00017', 'LIB-0008', N'Disponible'),
    ('EJ-00018', 'LIB-0009', N'Disponible'),
    ('EJ-00019', 'LIB-0009', N'Disponible'),
    ('EJ-00020', 'LIB-0009', N'Disponible'),
    ('EJ-00021', 'LIB-0010', N'Disponible'),
    ('EJ-00022', 'LIB-0010', N'Disponible'),
    ('EJ-00023', 'LIB-0011', N'Disponible'),
    ('EJ-00024', 'LIB-0011', N'Disponible'),
    ('EJ-00025', 'LIB-0012', N'Disponible'),
    ('EJ-00026', 'LIB-0012', N'Disponible'),
    ('EJ-00027', 'LIB-0013', N'Disponible'),
    ('EJ-00028', 'LIB-0013', N'Disponible'),
    ('EJ-00029', 'LIB-0014', N'Disponible'),
    ('EJ-00030', 'LIB-0014', N'Disponible'),
    ('EJ-00031', 'LIB-0014', N'Disponible'),
    ('EJ-00032', 'LIB-0015', N'Disponible'),
    ('EJ-00033', 'LIB-0016', N'Disponible'),
    ('EJ-00034', 'LIB-0016', N'Disponible'),
    ('EJ-00035', 'LIB-0017', N'Disponible'),
    ('EJ-00036', 'LIB-0017', N'Disponible'),
    ('EJ-00037', 'LIB-0018', N'Disponible'),
    ('EJ-00038', 'LIB-0019', N'Disponible'),
    ('EJ-00039', 'LIB-0020', N'Disponible'),
    ('EJ-00040', 'LIB-0020', N'Disponible'),
    ('EJ-00041', 'LIB-0020', N'Disponible'),
    ('EJ-00042', 'LIB-0021', N'Disponible'),
    ('EJ-00043', 'LIB-0022', N'Disponible'),
    ('EJ-00044', 'LIB-0022', N'Disponible'),
    ('EJ-00045', 'LIB-0023', N'Disponible');

COMMIT TRANSACTION;
GO
