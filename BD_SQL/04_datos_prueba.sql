/*
    Sistema de Gestión de Biblioteca (SGB)
    Script 04 - Datos de prueba (opcional)
    Ejecutar después de 03_carga_inicial.sql.

    Las fechas se calculan a partir del día en que se ejecuta el script,
    para que los casos sigan siendo válidos sin importar cuándo se prueben.

    Casos que deja preparados:
      A) Lucía Fernández   (DNI 40123789): préstamo vencido. No puede pedir otro préstamo y,
                                           al devolverlo, se genera una multa por 16 días de atraso.
      B) Ana Martínez      (DNI 35678901): multa pendiente de pago por 6 días de atraso.
                                           No puede pedir préstamos hasta abonarla.
      C) Carlos López      (DNI 22345678): 3 préstamos vigentes en término (límite alcanzado).
      D) María González    (DNI 28456123): préstamo vigente en término. Al devolverlo no hay multa.
      E) Graciela Álvarez  (DNI 11234987): donó el ejemplar EJ-00045, que ya no puede donarse otra vez.
*/

USE bd_sgb;
GO

SET XACT_ABORT ON;
BEGIN TRANSACTION;

DECLARE @hoy date = CAST(GETDATE() AS date);
DECLARE @prestamo int;
DECLARE @devolucion int;
DECLARE @donacion int;

-- ---------------------------------------------------------------------
-- A) Préstamo vencido (prevista hace 16 días)
-- ---------------------------------------------------------------------
INSERT INTO Prestamo (NumeroSocio, FechaPrestamo, FechaDevolucionPrevista, Estado)
VALUES (1003, DATEADD(DAY, -30, @hoy), DATEADD(DAY, -16, @hoy), 'Vigente');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar (NumeroPrestamo, CodigoEjemplar) VALUES (@prestamo, 'EJ-00001'), (@prestamo, 'EJ-00006');
INSERT INTO Comprobante (NumeroPrestamo, FechaEmision) VALUES (@prestamo, DATEADD(DAY, -30, @hoy));
UPDATE Ejemplar SET Estado = 'Prestado' WHERE CodigoEjemplar IN ('EJ-00001', 'EJ-00006');

-- ---------------------------------------------------------------------
-- B) Préstamo devuelto con 6 días de atraso y multa pendiente de pago
-- ---------------------------------------------------------------------
INSERT INTO Prestamo (NumeroSocio, FechaPrestamo, FechaDevolucionPrevista, Estado)
VALUES (1005, DATEADD(DAY, -40, @hoy), DATEADD(DAY, -26, @hoy), 'Finalizado');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar (NumeroPrestamo, CodigoEjemplar) VALUES (@prestamo, 'EJ-00011');
INSERT INTO Comprobante (NumeroPrestamo, FechaEmision) VALUES (@prestamo, DATEADD(DAY, -40, @hoy));
INSERT INTO Devolucion (NumeroPrestamo, FechaDevolucion) VALUES (@prestamo, DATEADD(DAY, -20, @hoy));
SET @devolucion = SCOPE_IDENTITY();
INSERT INTO Multa (NumeroDevolucion, DiasAtraso, MontoPorDia, Monto, FechaGeneracion, FechaPago, Estado)
VALUES (@devolucion, 6, 500, 3000, DATEADD(DAY, -20, @hoy), NULL, 'Pendiente de pago');

-- ---------------------------------------------------------------------
-- C) Tres préstamos vigentes en término (límite alcanzado)
-- ---------------------------------------------------------------------
INSERT INTO Prestamo (NumeroSocio, FechaPrestamo, FechaDevolucionPrevista, Estado)
VALUES (1006, DATEADD(DAY, -3, @hoy), DATEADD(DAY, 11, @hoy), 'Vigente');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar (NumeroPrestamo, CodigoEjemplar) VALUES (@prestamo, 'EJ-00013');
INSERT INTO Comprobante (NumeroPrestamo, FechaEmision) VALUES (@prestamo, DATEADD(DAY, -3, @hoy));

INSERT INTO Prestamo (NumeroSocio, FechaPrestamo, FechaDevolucionPrevista, Estado)
VALUES (1006, DATEADD(DAY, -2, @hoy), DATEADD(DAY, 12, @hoy), 'Vigente');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar (NumeroPrestamo, CodigoEjemplar) VALUES (@prestamo, 'EJ-00017');
INSERT INTO Comprobante (NumeroPrestamo, FechaEmision) VALUES (@prestamo, DATEADD(DAY, -2, @hoy));

INSERT INTO Prestamo (NumeroSocio, FechaPrestamo, FechaDevolucionPrevista, Estado)
VALUES (1006, DATEADD(DAY, -1, @hoy), DATEADD(DAY, 13, @hoy), 'Vigente');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar (NumeroPrestamo, CodigoEjemplar) VALUES (@prestamo, 'EJ-00021');
INSERT INTO Comprobante (NumeroPrestamo, FechaEmision) VALUES (@prestamo, DATEADD(DAY, -1, @hoy));

UPDATE Ejemplar SET Estado = 'Prestado' WHERE CodigoEjemplar IN ('EJ-00013', 'EJ-00017', 'EJ-00021');

-- ---------------------------------------------------------------------
-- D) Préstamo vigente en término (prevista dentro de 9 días)
-- ---------------------------------------------------------------------
INSERT INTO Prestamo (NumeroSocio, FechaPrestamo, FechaDevolucionPrevista, Estado)
VALUES (1001, DATEADD(DAY, -5, @hoy), DATEADD(DAY, 9, @hoy), 'Vigente');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar (NumeroPrestamo, CodigoEjemplar) VALUES (@prestamo, 'EJ-00018'), (@prestamo, 'EJ-00027');
INSERT INTO Comprobante (NumeroPrestamo, FechaEmision) VALUES (@prestamo, DATEADD(DAY, -5, @hoy));
UPDATE Ejemplar SET Estado = 'Prestado' WHERE CodigoEjemplar IN ('EJ-00018', 'EJ-00027');

-- ---------------------------------------------------------------------
-- E) Donación ya registrada
-- ---------------------------------------------------------------------
INSERT INTO Donacion (NumeroSocio, FechaDonacion) VALUES (1011, DATEADD(DAY, -60, @hoy));
SET @donacion = SCOPE_IDENTITY();
INSERT INTO Donacion_Ejemplar (NumeroDonacion, CodigoEjemplar) VALUES (@donacion, 'EJ-00045');
INSERT INTO ReciboDonacion (NumeroDonacion, FechaEmision) VALUES (@donacion, DATEADD(DAY, -60, @hoy));

COMMIT TRANSACTION;
GO
