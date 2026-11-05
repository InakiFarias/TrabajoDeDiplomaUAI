using System.Security.Cryptography;
using System.Text;

namespace Servicio
{
    public class SER_Cripto_351FI
    {
        public static string Encriptar_351FI(string texto_351FI)
        {
            byte[] bytesTexto = Encoding.UTF8.GetBytes(texto_351FI);
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytesHash = sha.ComputeHash(bytesTexto);
                StringBuilder sb = new StringBuilder();
                foreach(byte b in bytesHash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
