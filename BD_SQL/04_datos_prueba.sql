/*
    Sistema de Gestión de Biblioteca (SGB)
    Script 04 - Datos de prueba (opcional)
    Ejecutar después de 03_carga_inicial.sql.

    Las fechas se calculan a partir del día en que se ejecuta el script,
    para que los casos sigan siendo válidos sin importar cuándo se prueben.
    La multa es de $ 500 por día de atraso y el plazo de préstamo es de 14 días.

    Casos que deja preparados:

    Préstamos vigentes
      A) Lucía Fernández   (DNI 40123789): préstamo vencido hace 16 días (2 ejemplares).
                                           No puede pedir otro préstamo; al devolverlo se genera una multa de $ 8.000.
      C) Carlos López      (DNI 22345678): 3 préstamos vigentes en término (límite alcanzado).
      D) María González    (DNI 28456123): préstamo vigente en término (2 ejemplares). Al devolverlo no hay multa.
      F) Juan Carlos Pérez (DNI 17234567): préstamo vencido hace 3 días. Al devolverlo, multa de $ 1.500.
      G) Roberto Gómez     (DNI 12987654): préstamo vencido hace 30 días con 3 ejemplares. Al devolverlo, multa de $ 15.000.
      H) Sofía Díaz        (DNI 43210987): préstamo que vence hoy. Si se devuelve hoy no genera multa.
      I) Jorge Romero      (DNI 14567890): préstamo que vence mañana.

    Multas
      B) Ana Martínez      (DNI 35678901): una multa pendiente de $ 3.000 (6 días de atraso).
      J) Valentina Sosa    (DNI 44876543): dos multas pendientes ($ 2.000 y $ 5.000), total adeudado $ 7.000.
      K) Miguel Á. Torres  (DNI 20123456): multa pendiente de $ 1.000 y además un préstamo vigente en término.
                                           Aparece en Cobrar multas, no puede pedir otro préstamo, pero sí devolver.
      L) Martín Ruiz       (DNI 38901234): multa ya pagada (con comprobante). No aparece en Cobrar multas y está habilitado.
      M) Camila Medina     (DNI 42345612): préstamo devuelto en término, sin multa. Está habilitada.

    Bajas (para probar Reactivar)
      N) Socios Elena Benítez (DNI 16789012) y Diego Acosta (DNI 31456789) dados de baja (vienen del script 03).
         Ejemplar EJ-00044 (Cosmos) dado de baja con su libro activo: se puede reactivar directamente.
         Libro LIB-0019 (Facundo) y su único ejemplar EJ-00038 dados de baja: el ejemplar no se puede
         reactivar hasta reactivar el libro.

    Socios sin movimientos (habilitados para prestar): Graciela Álvarez (1011).
*/

USE bd_sgb;
GO

SET XACT_ABORT ON;
BEGIN TRANSACTION;

DECLARE @hoy date = CAST(GETDATE() AS date);
DECLARE @prestamo int;
DECLARE @devolucion int;
DECLARE @donacion int;
DECLARE @comprobantePago int;

-- =====================================================================
-- PRÉSTAMOS VIGENTES
-- =====================================================================

-- ---------------------------------------------------------------------
-- A) Préstamo vencido (prevista hace 16 días)
-- ---------------------------------------------------------------------
INSERT INTO Prestamo_351FI (NumeroSocio_351FI, FechaPrestamo_351FI, FechaDevolucionPrevista_351FI, Estado_351FI)
VALUES (1003, DATEADD(DAY, -30, @hoy), DATEADD(DAY, -16, @hoy), 'Vigente');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar_351FI (NumeroPrestamo_351FI, CodigoEjemplar_351FI) VALUES (@prestamo, 'EJ-00001'), (@prestamo, 'EJ-00006');
INSERT INTO Comprobante_351FI (NumeroPrestamo_351FI, FechaEmision_351FI) VALUES (@prestamo, DATEADD(DAY, -30, @hoy));
UPDATE Ejemplar_351FI SET Estado_351FI = 'Prestado' WHERE CodigoEjemplar_351FI IN ('EJ-00001', 'EJ-00006');

-- ---------------------------------------------------------------------
-- C) Tres préstamos vigentes en término (límite alcanzado)
-- ---------------------------------------------------------------------
INSERT INTO Prestamo_351FI (NumeroSocio_351FI, FechaPrestamo_351FI, FechaDevolucionPrevista_351FI, Estado_351FI)
VALUES (1006, DATEADD(DAY, -3, @hoy), DATEADD(DAY, 11, @hoy), 'Vigente');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar_351FI (NumeroPrestamo_351FI, CodigoEjemplar_351FI) VALUES (@prestamo, 'EJ-00013');
INSERT INTO Comprobante_351FI (NumeroPrestamo_351FI, FechaEmision_351FI) VALUES (@prestamo, DATEADD(DAY, -3, @hoy));

INSERT INTO Prestamo_351FI (NumeroSocio_351FI, FechaPrestamo_351FI, FechaDevolucionPrevista_351FI, Estado_351FI)
VALUES (1006, DATEADD(DAY, -2, @hoy), DATEADD(DAY, 12, @hoy), 'Vigente');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar_351FI (NumeroPrestamo_351FI, CodigoEjemplar_351FI) VALUES (@prestamo, 'EJ-00017');
INSERT INTO Comprobante_351FI (NumeroPrestamo_351FI, FechaEmision_351FI) VALUES (@prestamo, DATEADD(DAY, -2, @hoy));

INSERT INTO Prestamo_351FI (NumeroSocio_351FI, FechaPrestamo_351FI, FechaDevolucionPrevista_351FI, Estado_351FI)
VALUES (1006, DATEADD(DAY, -1, @hoy), DATEADD(DAY, 13, @hoy), 'Vigente');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar_351FI (NumeroPrestamo_351FI, CodigoEjemplar_351FI) VALUES (@prestamo, 'EJ-00021');
INSERT INTO Comprobante_351FI (NumeroPrestamo_351FI, FechaEmision_351FI) VALUES (@prestamo, DATEADD(DAY, -1, @hoy));

UPDATE Ejemplar_351FI SET Estado_351FI = 'Prestado' WHERE CodigoEjemplar_351FI IN ('EJ-00013', 'EJ-00017', 'EJ-00021');

-- ---------------------------------------------------------------------
-- D) Préstamo vigente en término (prevista dentro de 9 días)
-- ---------------------------------------------------------------------
INSERT INTO Prestamo_351FI (NumeroSocio_351FI, FechaPrestamo_351FI, FechaDevolucionPrevista_351FI, Estado_351FI)
VALUES (1001, DATEADD(DAY, -5, @hoy), DATEADD(DAY, 9, @hoy), 'Vigente');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar_351FI (NumeroPrestamo_351FI, CodigoEjemplar_351FI) VALUES (@prestamo, 'EJ-00018'), (@prestamo, 'EJ-00027');
INSERT INTO Comprobante_351FI (NumeroPrestamo_351FI, FechaEmision_351FI) VALUES (@prestamo, DATEADD(DAY, -5, @hoy));
UPDATE Ejemplar_351FI SET Estado_351FI = 'Prestado' WHERE CodigoEjemplar_351FI IN ('EJ-00018', 'EJ-00027');

-- ---------------------------------------------------------------------
-- F) Préstamo vencido hace 3 días
-- ---------------------------------------------------------------------
INSERT INTO Prestamo_351FI (NumeroSocio_351FI, FechaPrestamo_351FI, FechaDevolucionPrevista_351FI, Estado_351FI)
VALUES (1002, DATEADD(DAY, -17, @hoy), DATEADD(DAY, -3, @hoy), 'Vigente');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar_351FI (NumeroPrestamo_351FI, CodigoEjemplar_351FI) VALUES (@prestamo, 'EJ-00004');
INSERT INTO Comprobante_351FI (NumeroPrestamo_351FI, FechaEmision_351FI) VALUES (@prestamo, DATEADD(DAY, -17, @hoy));
UPDATE Ejemplar_351FI SET Estado_351FI = 'Prestado' WHERE CodigoEjemplar_351FI = 'EJ-00004';

-- ---------------------------------------------------------------------
-- G) Préstamo vencido hace 30 días con 3 ejemplares
-- ---------------------------------------------------------------------
INSERT INTO Prestamo_351FI (NumeroSocio_351FI, FechaPrestamo_351FI, FechaDevolucionPrevista_351FI, Estado_351FI)
VALUES (1004, DATEADD(DAY, -44, @hoy), DATEADD(DAY, -30, @hoy), 'Vigente');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar_351FI (NumeroPrestamo_351FI, CodigoEjemplar_351FI) VALUES (@prestamo, 'EJ-00007'), (@prestamo, 'EJ-00014'), (@prestamo, 'EJ-00029');
INSERT INTO Comprobante_351FI (NumeroPrestamo_351FI, FechaEmision_351FI) VALUES (@prestamo, DATEADD(DAY, -44, @hoy));
UPDATE Ejemplar_351FI SET Estado_351FI = 'Prestado' WHERE CodigoEjemplar_351FI IN ('EJ-00007', 'EJ-00014', 'EJ-00029');

-- ---------------------------------------------------------------------
-- H) Préstamo que vence hoy (devuelto hoy no genera multa)
-- ---------------------------------------------------------------------
INSERT INTO Prestamo_351FI (NumeroSocio_351FI, FechaPrestamo_351FI, FechaDevolucionPrevista_351FI, Estado_351FI)
VALUES (1007, DATEADD(DAY, -14, @hoy), @hoy, 'Vigente');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar_351FI (NumeroPrestamo_351FI, CodigoEjemplar_351FI) VALUES (@prestamo, 'EJ-00009');
INSERT INTO Comprobante_351FI (NumeroPrestamo_351FI, FechaEmision_351FI) VALUES (@prestamo, DATEADD(DAY, -14, @hoy));
UPDATE Ejemplar_351FI SET Estado_351FI = 'Prestado' WHERE CodigoEjemplar_351FI = 'EJ-00009';

-- ---------------------------------------------------------------------
-- I) Préstamo que vence mañana
-- ---------------------------------------------------------------------
INSERT INTO Prestamo_351FI (NumeroSocio_351FI, FechaPrestamo_351FI, FechaDevolucionPrevista_351FI, Estado_351FI)
VALUES (1008, DATEADD(DAY, -13, @hoy), DATEADD(DAY, 1, @hoy), 'Vigente');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar_351FI (NumeroPrestamo_351FI, CodigoEjemplar_351FI) VALUES (@prestamo, 'EJ-00023');
INSERT INTO Comprobante_351FI (NumeroPrestamo_351FI, FechaEmision_351FI) VALUES (@prestamo, DATEADD(DAY, -13, @hoy));
UPDATE Ejemplar_351FI SET Estado_351FI = 'Prestado' WHERE CodigoEjemplar_351FI = 'EJ-00023';

-- =====================================================================
-- MULTAS (préstamos ya devueltos con atraso)
-- =====================================================================

-- ---------------------------------------------------------------------
-- B) Préstamo devuelto con 6 días de atraso y multa pendiente de pago
-- ---------------------------------------------------------------------
INSERT INTO Prestamo_351FI (NumeroSocio_351FI, FechaPrestamo_351FI, FechaDevolucionPrevista_351FI, Estado_351FI)
VALUES (1005, DATEADD(DAY, -40, @hoy), DATEADD(DAY, -26, @hoy), 'Finalizado');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar_351FI (NumeroPrestamo_351FI, CodigoEjemplar_351FI) VALUES (@prestamo, 'EJ-00011');
INSERT INTO Comprobante_351FI (NumeroPrestamo_351FI, FechaEmision_351FI) VALUES (@prestamo, DATEADD(DAY, -40, @hoy));
INSERT INTO Devolucion_351FI (NumeroPrestamo_351FI, FechaDevolucion_351FI) VALUES (@prestamo, DATEADD(DAY, -20, @hoy));
SET @devolucion = SCOPE_IDENTITY();
INSERT INTO Multa_351FI (NumeroDevolucion_351FI, DiasAtraso_351FI, MontoPorDia_351FI, Monto_351FI, FechaGeneracion_351FI, FechaPago_351FI, Estado_351FI)
VALUES (@devolucion, 6, 500, 3000, DATEADD(DAY, -20, @hoy), NULL, 'Pendiente de pago');

-- ---------------------------------------------------------------------
-- J) Dos multas pendientes del mismo socio (total adeudado $ 7.000)
-- ---------------------------------------------------------------------
INSERT INTO Prestamo_351FI (NumeroSocio_351FI, FechaPrestamo_351FI, FechaDevolucionPrevista_351FI, Estado_351FI)
VALUES (1009, DATEADD(DAY, -60, @hoy), DATEADD(DAY, -46, @hoy), 'Finalizado');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar_351FI (NumeroPrestamo_351FI, CodigoEjemplar_351FI) VALUES (@prestamo, 'EJ-00002');
INSERT INTO Comprobante_351FI (NumeroPrestamo_351FI, FechaEmision_351FI) VALUES (@prestamo, DATEADD(DAY, -60, @hoy));
INSERT INTO Devolucion_351FI (NumeroPrestamo_351FI, FechaDevolucion_351FI) VALUES (@prestamo, DATEADD(DAY, -42, @hoy));
SET @devolucion = SCOPE_IDENTITY();
INSERT INTO Multa_351FI (NumeroDevolucion_351FI, DiasAtraso_351FI, MontoPorDia_351FI, Monto_351FI, FechaGeneracion_351FI, FechaPago_351FI, Estado_351FI)
VALUES (@devolucion, 4, 500, 2000, DATEADD(DAY, -42, @hoy), NULL, 'Pendiente de pago');

INSERT INTO Prestamo_351FI (NumeroSocio_351FI, FechaPrestamo_351FI, FechaDevolucionPrevista_351FI, Estado_351FI)
VALUES (1009, DATEADD(DAY, -35, @hoy), DATEADD(DAY, -21, @hoy), 'Finalizado');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar_351FI (NumeroPrestamo_351FI, CodigoEjemplar_351FI) VALUES (@prestamo, 'EJ-00024'), (@prestamo, 'EJ-00030');
INSERT INTO Comprobante_351FI (NumeroPrestamo_351FI, FechaEmision_351FI) VALUES (@prestamo, DATEADD(DAY, -35, @hoy));
INSERT INTO Devolucion_351FI (NumeroPrestamo_351FI, FechaDevolucion_351FI) VALUES (@prestamo, DATEADD(DAY, -11, @hoy));
SET @devolucion = SCOPE_IDENTITY();
INSERT INTO Multa_351FI (NumeroDevolucion_351FI, DiasAtraso_351FI, MontoPorDia_351FI, Monto_351FI, FechaGeneracion_351FI, FechaPago_351FI, Estado_351FI)
VALUES (@devolucion, 10, 500, 5000, DATEADD(DAY, -11, @hoy), NULL, 'Pendiente de pago');

-- ---------------------------------------------------------------------
-- K) Multa pendiente y además un préstamo vigente en término
-- ---------------------------------------------------------------------
INSERT INTO Prestamo_351FI (NumeroSocio_351FI, FechaPrestamo_351FI, FechaDevolucionPrevista_351FI, Estado_351FI)
VALUES (1010, DATEADD(DAY, -25, @hoy), DATEADD(DAY, -11, @hoy), 'Finalizado');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar_351FI (NumeroPrestamo_351FI, CodigoEjemplar_351FI) VALUES (@prestamo, 'EJ-00033');
INSERT INTO Comprobante_351FI (NumeroPrestamo_351FI, FechaEmision_351FI) VALUES (@prestamo, DATEADD(DAY, -25, @hoy));
INSERT INTO Devolucion_351FI (NumeroPrestamo_351FI, FechaDevolucion_351FI) VALUES (@prestamo, DATEADD(DAY, -9, @hoy));
SET @devolucion = SCOPE_IDENTITY();
INSERT INTO Multa_351FI (NumeroDevolucion_351FI, DiasAtraso_351FI, MontoPorDia_351FI, Monto_351FI, FechaGeneracion_351FI, FechaPago_351FI, Estado_351FI)
VALUES (@devolucion, 2, 500, 1000, DATEADD(DAY, -9, @hoy), NULL, 'Pendiente de pago');

INSERT INTO Prestamo_351FI (NumeroSocio_351FI, FechaPrestamo_351FI, FechaDevolucionPrevista_351FI, Estado_351FI)
VALUES (1010, DATEADD(DAY, -12, @hoy), DATEADD(DAY, 2, @hoy), 'Vigente');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar_351FI (NumeroPrestamo_351FI, CodigoEjemplar_351FI) VALUES (@prestamo, 'EJ-00032');
INSERT INTO Comprobante_351FI (NumeroPrestamo_351FI, FechaEmision_351FI) VALUES (@prestamo, DATEADD(DAY, -12, @hoy));
UPDATE Ejemplar_351FI SET Estado_351FI = 'Prestado' WHERE CodigoEjemplar_351FI = 'EJ-00032';

-- ---------------------------------------------------------------------
-- L) Multa ya pagada (queda como historial, con su comprobante de pago)
-- ---------------------------------------------------------------------
INSERT INTO Prestamo_351FI (NumeroSocio_351FI, FechaPrestamo_351FI, FechaDevolucionPrevista_351FI, Estado_351FI)
VALUES (1012, DATEADD(DAY, -50, @hoy), DATEADD(DAY, -36, @hoy), 'Finalizado');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar_351FI (NumeroPrestamo_351FI, CodigoEjemplar_351FI) VALUES (@prestamo, 'EJ-00035');
INSERT INTO Comprobante_351FI (NumeroPrestamo_351FI, FechaEmision_351FI) VALUES (@prestamo, DATEADD(DAY, -50, @hoy));
INSERT INTO Devolucion_351FI (NumeroPrestamo_351FI, FechaDevolucion_351FI) VALUES (@prestamo, DATEADD(DAY, -28, @hoy));
SET @devolucion = SCOPE_IDENTITY();
INSERT INTO ComprobantePago_351FI (NumeroSocio_351FI, FechaEmision_351FI, MetodoPago_351FI, Total_351FI) VALUES (1012, DATEADD(DAY, -27, @hoy), 'Efectivo', 4000);
SET @comprobantePago = SCOPE_IDENTITY();
INSERT INTO Multa_351FI (NumeroDevolucion_351FI, DiasAtraso_351FI, MontoPorDia_351FI, Monto_351FI, FechaGeneracion_351FI, FechaPago_351FI, Estado_351FI, NumeroComprobantePago_351FI)
VALUES (@devolucion, 8, 500, 4000, DATEADD(DAY, -28, @hoy), DATEADD(DAY, -27, @hoy), 'Pagada', @comprobantePago);

-- ---------------------------------------------------------------------
-- M) Préstamo devuelto en término, sin multa
-- ---------------------------------------------------------------------
INSERT INTO Prestamo_351FI (NumeroSocio_351FI, FechaPrestamo_351FI, FechaDevolucionPrevista_351FI, Estado_351FI)
VALUES (1015, DATEADD(DAY, -20, @hoy), DATEADD(DAY, -6, @hoy), 'Finalizado');
SET @prestamo = SCOPE_IDENTITY();
INSERT INTO Prestamo_Ejemplar_351FI (NumeroPrestamo_351FI, CodigoEjemplar_351FI) VALUES (@prestamo, 'EJ-00039'), (@prestamo, 'EJ-00040');
INSERT INTO Comprobante_351FI (NumeroPrestamo_351FI, FechaEmision_351FI) VALUES (@prestamo, DATEADD(DAY, -20, @hoy));
INSERT INTO Devolucion_351FI (NumeroPrestamo_351FI, FechaDevolucion_351FI) VALUES (@prestamo, DATEADD(DAY, -8, @hoy));

-- =====================================================================
-- DONACIONES
-- =====================================================================

-- ---------------------------------------------------------------------
-- E) Donación ya registrada
-- ---------------------------------------------------------------------
INSERT INTO Donacion_351FI (NumeroSocio_351FI, FechaDonacion_351FI) VALUES (1011, DATEADD(DAY, -60, @hoy));
SET @donacion = SCOPE_IDENTITY();
INSERT INTO Donacion_Ejemplar_351FI (NumeroDonacion_351FI, CodigoEjemplar_351FI) VALUES (@donacion, 'EJ-00045');
INSERT INTO ReciboDonacion_351FI (NumeroDonacion_351FI, FechaEmision_351FI) VALUES (@donacion, DATEADD(DAY, -60, @hoy));

-- =====================================================================
-- BAJAS (para probar Reactivar)
-- =====================================================================

-- ---------------------------------------------------------------------
-- N) Ejemplar dado de baja con su libro activo
-- ---------------------------------------------------------------------
UPDATE Ejemplar_351FI SET Estado_351FI = 'Baja' WHERE CodigoEjemplar_351FI = 'EJ-00044';

-- Libro dado de baja junto con su único ejemplar
UPDATE Ejemplar_351FI SET Estado_351FI = 'Baja' WHERE CodigoEjemplar_351FI = 'EJ-00038';
UPDATE Libro_351FI SET Estado_351FI = 'Baja' WHERE CodigoLibro_351FI = 'LIB-0019';

COMMIT TRANSACTION;
GO
