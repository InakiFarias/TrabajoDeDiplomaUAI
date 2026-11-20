using System.Xml;
using System.Xml.Serialization;
using BE;

namespace BLL.BLL_SER
{
    public class BLL_Deserializador_351FI
    {
        const string MENSAJE_INVALIDO = "No se pudo procesar el archivo: no corresponde a un XML de libros o está dañado.";

        // Reconstruye la lista de libros (con sus autores y temas) a partir de un archivo XML
        public List<BE_Libro_351FI> DeserializarXml_351FI(string ruta_351FI)
        {
            List<BE_Libro_351FI>? libros;
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<BE_Libro_351FI>));
                using FileStream archivo = new FileStream(ruta_351FI, FileMode.Open, FileAccess.Read);
                libros = serializador.Deserialize(archivo) as List<BE_Libro_351FI>;
            }
            catch (Exception ex) when (ex is InvalidOperationException || ex is XmlException)
            {
                throw new Exception(MENSAJE_INVALIDO);
            }

            // Un XML bien formado pero de otra cosa puede dar libros incompletos
            if (libros == null || libros.Count == 0 || libros.Any(l => string.IsNullOrWhiteSpace(l.CodigoLibro_351FI) || string.IsNullOrWhiteSpace(l.Titulo_351FI) || l.Autores_351FI == null || l.Temas_351FI == null))
                throw new Exception(MENSAJE_INVALIDO);

            return libros;
        }
    }
}
