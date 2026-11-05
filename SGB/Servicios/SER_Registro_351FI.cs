using System.Globalization;

namespace Servicio
{
    // Fila de una tabla protegida por dígito verificador, tal como está guardada en la base de datos
    public class SER_Registro_351FI
    {
        public const string SEPARADOR_ID = "-";

        public string NombreTabla_351FI { get; set; }
        public string IdRegistro_351FI { get; set; }
        public string[] Campos_351FI { get; set; }
        public object[] Valores_351FI { get; set; }

        public SER_Registro_351FI(string nombreTabla_351FI, string idRegistro_351FI, string[] campos_351FI, object[] valores_351FI)
        {
            NombreTabla_351FI = nombreTabla_351FI;
            IdRegistro_351FI = idRegistro_351FI;
            Campos_351FI = campos_351FI;
            Valores_351FI = valores_351FI;
        }

        // Arma el id del registro con los valores de su clave primaria (ej. "1001" o "LIB-0001-3")
        public static string ArmarId_351FI(IEnumerable<object> valoresClave_351FI)
        {
            return string.Join(SEPARADOR_ID, valoresClave_351FI.Select(v => Convert.ToString(v, CultureInfo.InvariantCulture)));
        }
    }
}
