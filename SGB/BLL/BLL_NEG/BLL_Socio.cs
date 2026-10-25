using BE;
using BLL.BLL_SER;
using MAP;
using Servicio;

namespace BLL.BLL_NEG
{
    public class BLL_Socio
    {
        public const string HABILITADO = "Habilitado";

        MAP_Socio map_socio;
        BLL_Bitacora bll_bitacora;
        public BLL_Socio()
        {
            map_socio = new MAP_Socio();
            bll_bitacora = new BLL_Bitacora();
        }

        // ------------------------------------------------ Búsquedas para las operaciones (solo socios activos)

        public List<BE_Socio> ObtenerActivos() => map_socio.ObtenerSocios(true);

        public List<BE_Socio> BuscarActivosPorDni(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni)) return map_socio.ObtenerSocios(true);
            return map_socio.BuscarPorDni(dni.Trim(), true);
        }

        // ------------------------------------------------ Búsquedas para el ABM (todos los socios)

        public List<BE_Socio> ObtenerTodos() => map_socio.ObtenerSocios(false);

        public List<BE_Socio> BuscarPorDni(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni)) return map_socio.ObtenerSocios(false);
            return map_socio.BuscarPorDni(dni.Trim(), false);
        }

        // ------------------------------------------------ Habilitación para préstamos (RF-001-3)

        public string ValidarHabilitacion(BE_Socio socio)
        {
            if (map_socio.ContarPrestamosVencidos(socio) > 0)
                socio.EstadoHabilitacion = "Posee préstamos vencidos";
            else if (map_socio.ContarPrestamosVigentes(socio) >= BLL_Prestamo.MAXIMO_PRESTAMOS_VIGENTES)
                socio.EstadoHabilitacion = $"Alcanzó la cantidad máxima de {BLL_Prestamo.MAXIMO_PRESTAMOS_VIGENTES} préstamos vigentes";
            else if (map_socio.ContarMultasPendientes(socio) > 0)
                socio.EstadoHabilitacion = "Posee multas pendientes de pago";
            else
                socio.EstadoHabilitacion = HABILITADO;

            return socio.EstadoHabilitacion;
        }

        // ------------------------------------------------ ABM de socios

        public void Alta(BE_Socio socio)
        {
            Validar(socio, 0);
            socio.Estado = "Activo";
            socio.NumeroSocio = map_socio.InsertarSocio(socio);
            RegistrarBitacora("Alta de socio", 3);
        }

        public void Modificar(BE_Socio socio)
        {
            if (socio.NumeroSocio == 0) throw new Exception("Seleccione el socio a modificar.");
            Validar(socio, socio.NumeroSocio);
            map_socio.ModificarSocio(socio);
            RegistrarBitacora("Modificación de socio", 3);
        }

        public void Baja(BE_Socio socio)
        {
            if (socio.Estado == "Baja") throw new Exception("El socio ya se encuentra dado de baja.");
            if (map_socio.ContarPrestamosVigentes(socio) > 0) throw new Exception("No se puede dar de baja al socio porque posee préstamos vigentes.");
            if (map_socio.ContarMultasPendientes(socio) > 0) throw new Exception("No se puede dar de baja al socio porque posee multas pendientes de pago.");

            map_socio.ActualizarEstado(socio, "Baja");
            socio.Estado = "Baja";
            RegistrarBitacora("Baja de socio", 2);
        }

        private void Validar(BE_Socio socio, int numeroSocioExcluido)
        {
            socio.Nombre = socio.Nombre?.Trim() ?? "";
            socio.Apellido = socio.Apellido?.Trim() ?? "";
            socio.Dni = socio.Dni?.Trim() ?? "";

            if (socio.Nombre == "") throw new Exception("Ingrese el nombre del socio.");
            if (socio.Apellido == "") throw new Exception("Ingrese el apellido del socio.");
            if (socio.Nombre.Length > 50 || socio.Apellido.Length > 50) throw new Exception("El nombre y el apellido no pueden superar los 50 caracteres.");
            if (socio.Dni.Length < 7 || socio.Dni.Length > 8 || !socio.Dni.All(char.IsDigit)) throw new Exception("El DNI debe tener 7 u 8 dígitos, sin puntos.");
            if (map_socio.ExisteDni(socio.Dni, numeroSocioExcluido)) throw new Exception("Ya existe un socio registrado con el DNI ingresado.");
        }

        private void RegistrarBitacora(string evento, int criticidad)
        {
            SER_Bitacora bitacora = new SER_Bitacora(SER_SesionManager.ObtenerSesion().Usuario, DateTime.Now, "Socios", evento, criticidad);
            bll_bitacora.RegistrarBitacora(bitacora);
        }
    }
}
