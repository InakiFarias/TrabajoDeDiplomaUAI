using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;

namespace DAL
{
    public abstract class Conexion_351FI
    {
        protected SqlConnection con_351FI;
        public Conexion_351FI()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string envPath = Path.Combine(basePath, ".env");

            Env.Load(envPath);

            string? c = Environment.GetEnvironmentVariable("DB_CONNECTION");

            if (string.IsNullOrEmpty(c))
                throw new InvalidOperationException("No se encontró DB_CONNECTION en el archivo .env");

            con_351FI = new SqlConnection(c);
        }

        protected string ObtenerCadenaConexion_351FI()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string envPath = Path.Combine(basePath, ".env");
            Env.Load(envPath);
            string? c = Environment.GetEnvironmentVariable("DB_CONNECTION");
            if (string.IsNullOrEmpty(c)) throw new InvalidOperationException("No se encontró DB_CONNECTION en el archivo .env");
            return c;
        }
    }
}
