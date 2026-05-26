using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class SER_Cripto
    {
        public static string Encriptar(string texto)
        {
            byte[] bytesTexto = Encoding.UTF8.GetBytes(texto);
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
