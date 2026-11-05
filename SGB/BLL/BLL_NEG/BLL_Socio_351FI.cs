using BE;
using BLL.BLL_SER;
using MAP;
using Servicio;

namespace BLL.BLL_NEG
{
    public class BLL_Socio_351FI
    {
        public const string HABILITADO = "Habilitado";

        MAP_Socio_351FI map_socio_351FI;
        BLL_Bitacora_351FI bll_bitacora_351FI;
        BLL_DV_351FI bll_dv_351FI;
        public BLL_Socio_351FI()
        {
            map_socio_351FI = new MAP_Socio_351FI();
            bll_bitacora_351FI = new BLL_Bitacora_351FI();
            bll_dv_351FI = new BLL_DV_351FI();
        }

        // ------------------------------------------------ Búsquedas para las operaciones (solo socios activos)

        public List<BE_Socio_351FI> ObtenerActivos_351FI() => map_socio_351FI.ObtenerSocios_351FI(true);

        public List<BE_Socio_351FI> BuscarActivosPorDni_351FI(string dni_351FI)
        {
            if (string.IsNullOrWhiteSpace(dni_351FI)) return map_socio_351FI.ObtenerSocios_351FI(true);
            return map_socio_351FI.BuscarPorDni_351FI(dni_351FI.Trim(), true);
        }

        // ------------------------------------------------ Búsquedas para el ABM (todos los socios)

        public List<BE_Socio_351FI> ObtenerTodos_351FI() => map_socio_351FI.ObtenerSocios_351FI(false);

        public List<BE_Socio_351FI> BuscarPorDni_351FI(string dni_351FI)
        {
            if (string.IsNullOrWhiteSpace(dni_351FI)) return map_socio_351FI.ObtenerSocios_351FI(false);
            return map_socio_351FI.BuscarPorDni_351FI(dni_351FI.Trim(), false);
        }

        // ------------------------------------------------ Habilitación para préstamos (RF-001-3)

        public string ValidarHabilitacion_351FI(BE_Socio_351FI socio_351FI)
        {
            if (map_socio_351FI.ContarPrestamosVencidos_351FI(socio_351FI) > 0)
                socio_351FI.EstadoHabilitacion_351FI = "Posee préstamos vencidos";
            else if (map_socio_351FI.ContarPrestamosVigentes_351FI(socio_351FI) >= BLL_Prestamo_351FI.MAXIMO_PRESTAMOS_VIGENTES)
                socio_351FI.EstadoHabilitacion_351FI = $"Alcanzó la cantidad máxima de {BLL_Prestamo_351FI.MAXIMO_PRESTAMOS_VIGENTES} préstamos vigentes";
            else if (map_socio_351FI.ContarMultasPendientes_351FI(socio_351FI) > 0)
                socio_351FI.EstadoHabilitacion_351FI = "Posee multas pendientes de pago";
            else
                socio_351FI.EstadoHabilitacion_351FI = HABILITADO;

            return socio_351FI.EstadoHabilitacion_351FI;
        }

        // ------------------------------------------------ ABM de socios

        public void Alta_351FI(BE_Socio_351FI socio_351FI)
        {
            Validar_351FI(socio_351FI, 0);
            socio_351FI.Estado_351FI = "Activo";
            socio_351FI.NumeroSocio_351FI = map_socio_351FI.InsertarSocio_351FI(socio_351FI);
            bll_dv_351FI.GenerarDVH_351FI("Socio_351FI", socio_351FI.NumeroSocio_351FI);
            bll_dv_351FI.GenerarDVV_351FI("Socio_351FI");
            RegistrarBitacora_351FI("Alta de socio", 3);
        }

        public void Modificar_351FI(BE_Socio_351FI socio_351FI)
        {
            if (socio_351FI.NumeroSocio_351FI == 0) throw new Exception("Seleccione el socio a modificar.");
            Validar_351FI(socio_351FI, socio_351FI.NumeroSocio_351FI);
            map_socio_351FI.ModificarSocio_351FI(socio_351FI);
            bll_dv_351FI.GenerarDVH_351FI("Socio_351FI", socio_351FI.NumeroSocio_351FI);
            bll_dv_351FI.GenerarDVV_351FI("Socio_351FI");
            RegistrarBitacora_351FI("Modificación de socio", 3);
        }

        public void Baja_351FI(BE_Socio_351FI socio_351FI)
        {
            if (socio_351FI.Estado_351FI == "Baja") throw new Exception("El socio ya se encuentra dado de baja.");
            if (map_socio_351FI.ContarPrestamosVigentes_351FI(socio_351FI) > 0) throw new Exception("No se puede dar de baja al socio porque posee préstamos vigentes.");
            if (map_socio_351FI.ContarMultasPendientes_351FI(socio_351FI) > 0) throw new Exception("No se puede dar de baja al socio porque posee multas pendientes de pago.");

            map_socio_351FI.ActualizarEstado_351FI(socio_351FI, "Baja");
            socio_351FI.Estado_351FI = "Baja";
            bll_dv_351FI.GenerarDVH_351FI("Socio_351FI", socio_351FI.NumeroSocio_351FI);
            bll_dv_351FI.GenerarDVV_351FI("Socio_351FI");
            RegistrarBitacora_351FI("Baja de socio", 2);
        }

        // Vuelve a dar de alta a un socio que estaba dado de baja
        public void Reactivar_351FI(BE_Socio_351FI socio_351FI)
        {
            if (socio_351FI.Estado_351FI != "Baja") throw new Exception("El socio ya se encuentra activo.");

            map_socio_351FI.ActualizarEstado_351FI(socio_351FI, "Activo");
            socio_351FI.Estado_351FI = "Activo";
            bll_dv_351FI.GenerarDVH_351FI("Socio_351FI", socio_351FI.NumeroSocio_351FI);
            bll_dv_351FI.GenerarDVV_351FI("Socio_351FI");
            RegistrarBitacora_351FI("Reactivación de socio", 3);
        }

        private void Validar_351FI(BE_Socio_351FI socio_351FI, int numeroSocioExcluido_351FI)
        {
            socio_351FI.Nombre_351FI = socio_351FI.Nombre_351FI?.Trim() ?? "";
            socio_351FI.Apellido_351FI = socio_351FI.Apellido_351FI?.Trim() ?? "";
            socio_351FI.Dni_351FI = socio_351FI.Dni_351FI?.Trim() ?? "";

            if (socio_351FI.Nombre_351FI == "") throw new Exception("Ingrese el nombre del socio.");
            if (socio_351FI.Apellido_351FI == "") throw new Exception("Ingrese el apellido del socio.");
            if (socio_351FI.Nombre_351FI.Length > 50 || socio_351FI.Apellido_351FI.Length > 50) throw new Exception("El nombre y el apellido no pueden superar los 50 caracteres.");
            if (socio_351FI.Dni_351FI.Length < 7 || socio_351FI.Dni_351FI.Length > 8 || !socio_351FI.Dni_351FI.All(char.IsDigit)) throw new Exception("El DNI debe tener 7 u 8 dígitos, sin puntos.");
            if (map_socio_351FI.ExisteDni_351FI(socio_351FI.Dni_351FI, numeroSocioExcluido_351FI))
            {
                // Si el DNI es de un socio dado de baja, se indica cómo reactivarlo en lugar de crear otro
                BE_Socio_351FI? existente = map_socio_351FI.BuscarPorDni_351FI(socio_351FI.Dni_351FI, false).FirstOrDefault(s => s.Dni_351FI == socio_351FI.Dni_351FI);
                if (existente != null && existente.Estado_351FI == "Baja")
                    throw new Exception($"El DNI ingresado pertenece al socio N° {existente.NumeroSocio_351FI}, que está dado de baja. Selecciónelo en la grilla y presione Reactivar.");
                throw new Exception("Ya existe un socio registrado con el DNI ingresado.");
            }
        }

        private void RegistrarBitacora_351FI(string evento_351FI, int criticidad_351FI)
        {
            SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Socios", evento_351FI, criticidad_351FI);
            bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);
        }
    }
}
