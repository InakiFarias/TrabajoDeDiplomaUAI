using MAP.MAP_SER;
using Servicio;
using System.Globalization;
using System.Text;

namespace BLL.BLL_SER
{
    public class BLL_DV_351FI
    {
        MAP_DV_351FI map_dv_351FI;
        BLL_Bitacora_351FI bll_bitacora_351FI;
        private const string SEPARADOR_HASH = "|";

        // Tablas protegidas por dígito verificador y las columnas de su clave primaria
        private static readonly Dictionary<string, string[]> TABLAS_351FI = new Dictionary<string, string[]>
        {
            // Seguridad
            { "usuario_351FI",                new[] { "dni_351FI" } },
            { "rol_351FI",                    new[] { "idRol_351FI" } },
            { "familia_351FI",                new[] { "idFamilia_351FI" } },
            { "permiso_351FI",                new[] { "idPermiso_351FI" } },
            { "rol_familia_351FI",            new[] { "idRol_351FI", "idFamilia_351FI" } },
            { "rol_permiso_351FI",            new[] { "idRol_351FI", "idPermiso_351FI" } },
            { "familia_familia_351FI",        new[] { "idFamiliaPadre_351FI", "idFamiliaHija_351FI" } },
            { "permiso_familia_351FI",        new[] { "idFamilia_351FI", "idPermiso_351FI" } },

            // Negocio
            { "Socio_351FI",                  new[] { "NumeroSocio_351FI" } },
            { "Autor_351FI",                  new[] { "CodigoAutor_351FI" } },
            { "Tema_351FI",                   new[] { "CodigoTema_351FI" } },
            { "Libro_351FI",                  new[] { "CodigoLibro_351FI" } },
            { "Libro_Autor_351FI",            new[] { "CodigoLibro_351FI", "CodigoAutor_351FI" } },
            { "Libro_Tema_351FI",             new[] { "CodigoLibro_351FI", "CodigoTema_351FI" } },
            { "Ejemplar_351FI",               new[] { "CodigoEjemplar_351FI" } },
            { "Prestamo_351FI",               new[] { "NumeroPrestamo_351FI" } },
            { "Prestamo_Ejemplar_351FI",      new[] { "NumeroPrestamo_351FI", "CodigoEjemplar_351FI" } },
            { "Comprobante_351FI",            new[] { "NumeroComprobante_351FI" } },
            { "Devolucion_351FI",             new[] { "NumeroDevolucion_351FI" } },
            { "ComprobanteDevolucion_351FI",  new[] { "NumeroComprobante_351FI" } },
            { "Multa_351FI",                  new[] { "NumeroMulta_351FI" } },
            { "ComprobantePago_351FI",        new[] { "NumeroComprobante_351FI" } },
            { "Donacion_351FI",               new[] { "NumeroDonacion_351FI" } },
            { "Donacion_Ejemplar_351FI",      new[] { "NumeroDonacion_351FI", "CodigoEjemplar_351FI" } },
            { "ReciboDonacion_351FI",         new[] { "NumeroRecibo_351FI" } }
        };

        public BLL_DV_351FI()
        {
            map_dv_351FI = new MAP_DV_351FI();
            bll_bitacora_351FI = new BLL_Bitacora_351FI();
        }

        // ------------------------------------------------ Generación (después de cada alta, baja o modificación)

        // Calcula el DVH del registro tal como quedó guardado en la base de datos
        public void GenerarDVH_351FI(string nombreTabla_351FI, params object[] clave_351FI)
        {
            SER_Registro_351FI? registro = map_dv_351FI.ObtenerRegistro_351FI(nombreTabla_351FI, ObtenerColumnasClave_351FI(nombreTabla_351FI), clave_351FI);
            if (registro == null)
                throw new Exception($"No se encontró el registro {SER_Registro_351FI.ArmarId_351FI(clave_351FI)} de la tabla '{nombreTabla_351FI}' para generar su dígito verificador.");

            GuardarDVH_351FI(registro);
        }

        // Se usa cuando el registro se borró de la tabla
        public void BorrarDVH_351FI(string nombreTabla_351FI, params object[] clave_351FI)
        {
            ObtenerColumnasClave_351FI(nombreTabla_351FI);
            string id = SER_Registro_351FI.ArmarId_351FI(clave_351FI);
            if (map_dv_351FI.ExisteDVH_351FI(nombreTabla_351FI, id))
                map_dv_351FI.BorrarDVH_351FI(nombreTabla_351FI, id);
        }

        public void GenerarDVV_351FI(string nombreTabla_351FI)
        {
            ObtenerColumnasClave_351FI(nombreTabla_351FI);
            List<SER_DVH_351FI> dvhs = map_dv_351FI.ConsultarDVH_351FI(nombreTabla_351FI);

            if (dvhs.Count == 0)
            {
                if (map_dv_351FI.ExisteDVV_351FI(nombreTabla_351FI))
                    map_dv_351FI.BorrarDVV_351FI(nombreTabla_351FI);
                return;
            }

            SER_DVV_351FI dvv = new SER_DVV_351FI(nombreTabla_351FI, CalcularDVV_351FI(dvhs));
            if (map_dv_351FI.ExisteDVV_351FI(nombreTabla_351FI))
                map_dv_351FI.ModificarDVV_351FI(dvv);
            else
                map_dv_351FI.AgregarDVV_351FI(dvv);
        }

        private void GuardarDVH_351FI(SER_Registro_351FI registro_351FI)
        {
            SER_DVH_351FI dvh = new SER_DVH_351FI(registro_351FI.NombreTabla_351FI, registro_351FI.IdRegistro_351FI, CalcularDVH_351FI(registro_351FI));
            if (map_dv_351FI.ExisteDVH_351FI(dvh.NombreTabla_351FI, dvh.IdRegistro_351FI))
                map_dv_351FI.ModificarDVH_351FI(dvh);
            else
                map_dv_351FI.AgregarDVH_351FI(dvh);
        }

        // ------------------------------------------------ Recalcular (FrmRepararInconsistencia)

        // Toma los datos actuales de todas las tablas protegidas como válidos y vuelve a generar sus DVH y DVV
        public void RecalcularDV_351FI()
        {
            foreach (string nombreTabla in TABLAS_351FI.Keys)
            {
                List<SER_Registro_351FI> registros = map_dv_351FI.ConsultarRegistros_351FI(nombreTabla, TABLAS_351FI[nombreTabla]);
                HashSet<string> idsReales = registros.Select(r => r.IdRegistro_351FI).ToHashSet();

                foreach (SER_DVH_351FI dvh in map_dv_351FI.ConsultarDVH_351FI(nombreTabla))
                {
                    if (!idsReales.Contains(dvh.IdRegistro_351FI))
                        map_dv_351FI.BorrarDVH_351FI(nombreTabla, dvh.IdRegistro_351FI);
                }

                foreach (SER_Registro_351FI registro in registros)
                    GuardarDVH_351FI(registro);

                GenerarDVV_351FI(nombreTabla);
            }

            // Criticidad alta: se aceptan como válidos datos que pudieron modificarse por fuera del sistema
            SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Dígitos verificadores", "Recalcular dígitos verificadores", 1);
            bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);
        }

        // ------------------------------------------------ Verificación

        // Para FrmRepararInconsistencia: junta todas las inconsistencias, no corta nunca
        public List<SER_Inconsistencia_351FI> ObtenerInconsistencias_351FI()
        {
            List<SER_Inconsistencia_351FI> inconsistencias = new List<SER_Inconsistencia_351FI>();
            foreach (string nombreTabla in TABLAS_351FI.Keys)
                VerificarTabla_351FI(nombreTabla, inconsistencias);
            return inconsistencias;
        }

        // Para el login: corta con excepción si encuentra alguna inconsistencia
        public bool VerificarIntegridad_351FI()
        {
            if (ObtenerInconsistencias_351FI().Count > 0)
                throw new Exception("Se detecto inconsistencia en la base de datos. \n Redirigiendo a formulario de reparación.");

            return true;
        }

        private void VerificarTabla_351FI(string nombreTabla_351FI, List<SER_Inconsistencia_351FI> inconsistencias_351FI)
        {
            List<SER_Registro_351FI> registros = map_dv_351FI.ConsultarRegistros_351FI(nombreTabla_351FI, TABLAS_351FI[nombreTabla_351FI]);
            Dictionary<string, string> dvhGuardados = map_dv_351FI.ConsultarDVH_351FI(nombreTabla_351FI).ToDictionary(d => d.IdRegistro_351FI, d => d.Valor_351FI);
            List<SER_DVH_351FI> dvhCalculados = new List<SER_DVH_351FI>();
            bool huboErrorRegistro = false;

            // DVH: cada registro de la tabla debe tener su DVH y coincidir con el calculado
            foreach (SER_Registro_351FI registro in registros)
            {
                string dvhCalculado = CalcularDVH_351FI(registro);

                if (!dvhGuardados.TryGetValue(registro.IdRegistro_351FI, out string? dvhGuardado))
                {
                    inconsistencias_351FI.Add(new SER_Inconsistencia_351FI(nombreTabla_351FI, registro.IdRegistro_351FI,
                        $"No se encontró el DVH para el registro con Datos(POSIBLE INSERCIÓN):{Environment.NewLine}{MostrarDatos_351FI(registro)}"));
                    huboErrorRegistro = true;
                }
                else if (dvhGuardado != dvhCalculado)
                {
                    inconsistencias_351FI.Add(new SER_Inconsistencia_351FI(nombreTabla_351FI, registro.IdRegistro_351FI,
                        $"No coincide el DVH para el registro con Datos(POSIBLE MODIFICACIÓN):{Environment.NewLine}{MostrarDatos_351FI(registro)}"));
                    huboErrorRegistro = true;
                }

                dvhCalculados.Add(new SER_DVH_351FI(nombreTabla_351FI, registro.IdRegistro_351FI, dvhCalculado));
            }

            // DVH sin registro: el registro se borró por fuera del sistema
            HashSet<string> idsReales = registros.Select(r => r.IdRegistro_351FI).ToHashSet();
            foreach (string id in dvhGuardados.Keys)
            {
                if (!idsReales.Contains(id))
                {
                    inconsistencias_351FI.Add(new SER_Inconsistencia_351FI(nombreTabla_351FI, id,
                        $"Existe el DVH del registro '{id}', pero el registro no está en la tabla '{nombreTabla_351FI}' (POSIBLE ELIMINACIÓN)."));
                    huboErrorRegistro = true;
                }
            }

            if (huboErrorRegistro) return; // el DVV va a fallar como consecuencia directa; reportarlo también sería ruido

            // DVV
            SER_DVV_351FI? dvv = map_dv_351FI.ObtenerDVV_351FI(nombreTabla_351FI);

            if (registros.Count == 0)
            {
                if (dvv != null)
                    inconsistencias_351FI.Add(new SER_Inconsistencia_351FI(nombreTabla_351FI, "(tabla completa)",
                        $"La tabla '{nombreTabla_351FI}' no tiene registros, pero tiene un DVV generado.{Environment.NewLine}Posible eliminación directa de todos sus registros y sus DVH."));
                return;
            }

            if (dvv == null)
            {
                inconsistencias_351FI.Add(new SER_Inconsistencia_351FI(nombreTabla_351FI, "(tabla completa)",
                    $"La tabla '{nombreTabla_351FI}' tiene registros con DVH válido, pero no existe un DVV generado para la tabla.{Environment.NewLine}Posible eliminación directa del DVV en la base de datos."));
                return;
            }

            if (CalcularDVV_351FI(dvhCalculados) != dvv.Valor_351FI)
            {
                inconsistencias_351FI.Add(new SER_Inconsistencia_351FI(nombreTabla_351FI, "(tabla completa)",
                    $"El DVV de la tabla '{nombreTabla_351FI}' no coincide con el valor calculado.{Environment.NewLine}Posible modificación directa del DVV en la base de datos."));
            }
        }

        // ------------------------------------------------ Cálculo

        // DVH: hash de todos los campos del registro, en el orden de las columnas de la tabla
        private string CalcularDVH_351FI(SER_Registro_351FI registro_351FI)
        {
            return SER_Cripto_351FI.Encriptar_351FI(string.Join(SEPARADOR_HASH, registro_351FI.Valores_351FI.Select(FormatearValor_351FI)));
        }

        // DVV: hash de los DVH de la tabla ordenados por id de registro
        private string CalcularDVV_351FI(List<SER_DVH_351FI> dvhs_351FI)
        {
            return SER_Cripto_351FI.Encriptar_351FI(string.Join(SEPARADOR_HASH,
                dvhs_351FI.OrderBy(d => d.IdRegistro_351FI, StringComparer.Ordinal).Select(d => d.Valor_351FI)));
        }

        // Formato fijo para que el hash no dependa de la configuración regional de Windows
        private string FormatearValor_351FI(object valor_351FI)
        {
            if (valor_351FI == null || valor_351FI == DBNull.Value) return "";
            if (valor_351FI is DateTime fecha) return fecha.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture);
            return Convert.ToString(valor_351FI, CultureInfo.InvariantCulture) ?? "";
        }

        private string[] ObtenerColumnasClave_351FI(string nombreTabla_351FI)
        {
            if (!TABLAS_351FI.TryGetValue(nombreTabla_351FI, out string[]? columnas))
                throw new Exception($"La tabla '{nombreTabla_351FI}' no está protegida por dígito verificador.");
            return columnas;
        }

        private string MostrarDatos_351FI(SER_Registro_351FI registro_351FI)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < registro_351FI.Campos_351FI.Length; i++)
                sb.Append($"{registro_351FI.Campos_351FI[i]}: {FormatearValor_351FI(registro_351FI.Valores_351FI[i])}").Append(Environment.NewLine);
            return sb.ToString().TrimEnd();
        }
    }
}
