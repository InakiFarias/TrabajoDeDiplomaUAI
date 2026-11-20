using System.Xml.Serialization;
using BE;

namespace BLL.BLL_SER
{
    public class BLL_Serializador_351FI
    {
        // Guarda la lista de libros (con sus autores y temas) en un archivo XML
        public void SerializarXml_351FI(List<BE_Libro_351FI> libros_351FI, string ruta_351FI)
        {
            if (libros_351FI == null || libros_351FI.Count == 0)
                throw new Exception("No se puede serializar: el listado de libros está vacío.");

            XmlSerializer serializador = new XmlSerializer(typeof(List<BE_Libro_351FI>));
            using FileStream archivo = new FileStream(ruta_351FI, FileMode.Create);
            serializador.Serialize(archivo, libros_351FI);
        }
    }
}
