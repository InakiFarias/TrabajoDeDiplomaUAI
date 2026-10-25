using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Ejemplar : Conexion
    {
        SqlCommand cm;
        public DAO_Ejemplar() : base()
        {
            cm = new SqlCommand("select * from Ejemplar", con);
        }

        public SqlDataReader BuscarPorTexto(string texto, bool incluirBajas)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@texto", SqlDbType.VarChar).Value = "%" + texto + "%";
            cm.CommandText = @"SELECT e.CodigoEjemplar, e.Estado, l.CodigoLibro, l.Titulo
                               FROM Ejemplar e
                               INNER JOIN Libro l ON l.CodigoLibro = e.CodigoLibro
                               WHERE (e.CodigoEjemplar LIKE @texto
                                      OR l.Titulo LIKE @texto
                                      OR EXISTS (SELECT 1 FROM Libro_Autor la
                                                 INNER JOIN Autor a ON a.CodigoAutor = la.CodigoAutor
                                                 WHERE la.CodigoLibro = l.CodigoLibro
                                                 AND (a.Nombre + ' ' + a.Apellido) LIKE @texto))"
                             + (incluirBajas ? "" : " AND e.Estado <> 'Baja'")
                             + " ORDER BY e.CodigoEjemplar";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader BuscarPorCodigo(string codigo)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo;
            cm.CommandText = @"SELECT e.CodigoEjemplar, e.Estado, l.CodigoLibro, l.Titulo
                               FROM Ejemplar e
                               INNER JOIN Libro l ON l.CodigoLibro = e.CodigoLibro
                               WHERE e.CodigoEjemplar = @codigo";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader ObtenerPorPrestamo(int numeroPrestamo)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroPrestamo", SqlDbType.Int).Value = numeroPrestamo;
            cm.CommandText = @"SELECT e.CodigoEjemplar, e.Estado, l.CodigoLibro, l.Titulo
                               FROM Prestamo_Ejemplar pe
                               INNER JOIN Ejemplar e ON e.CodigoEjemplar = pe.CodigoEjemplar
                               INNER JOIN Libro l ON l.CodigoLibro = e.CodigoLibro
                               WHERE pe.NumeroPrestamo = @numeroPrestamo";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader ObtenerAutores(string codigoLibro)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro;
            cm.CommandText = @"SELECT a.CodigoAutor, a.Nombre, a.Apellido
                               FROM Autor a
                               INNER JOIN Libro_Autor la ON la.CodigoAutor = a.CodigoAutor
                               WHERE la.CodigoLibro = @codigoLibro";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public string ObtenerSiguienteCodigo()
        {
            cm.Parameters.Clear();
            cm.CommandText = @"SELECT ISNULL(MAX(CAST(SUBSTRING(CodigoEjemplar, 4, 16) AS int)), 0) + 1
                               FROM Ejemplar WHERE CodigoEjemplar LIKE 'EJ-%'";
            con.Open();
            int numero = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return "EJ-" + numero.ToString("D5");
        }

        public void InsertarEjemplar(string codigoEjemplar, string codigoLibro, string estado)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@codigoEjemplar", SqlDbType.VarChar).Value = codigoEjemplar;
            cm.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro;
            cm.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado;
            cm.CommandText = "INSERT INTO Ejemplar (CodigoEjemplar, CodigoLibro, Estado) VALUES (@codigoEjemplar, @codigoLibro, @estado)";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }

        public void ModificarLibroDeEjemplar(string codigoEjemplar, string codigoLibro)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@codigoEjemplar", SqlDbType.VarChar).Value = codigoEjemplar;
            cm.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro;
            cm.CommandText = "UPDATE Ejemplar SET CodigoLibro = @codigoLibro WHERE CodigoEjemplar = @codigoEjemplar";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }

        public void ActualizarEstado(string codigoEjemplar, string estado)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@codigoEjemplar", SqlDbType.VarChar).Value = codigoEjemplar;
            cm.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado;
            cm.CommandText = "UPDATE Ejemplar SET Estado = @estado WHERE CodigoEjemplar = @codigoEjemplar";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }

        // Préstamos vigentes que incluyen al ejemplar
        public int ContarPrestamosVigentes(string codigoEjemplar)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@codigoEjemplar", SqlDbType.VarChar).Value = codigoEjemplar;
            cm.CommandText = @"SELECT COUNT(*) FROM Prestamo_Ejemplar pe
                               INNER JOIN Prestamo p ON p.NumeroPrestamo = pe.NumeroPrestamo
                               WHERE pe.CodigoEjemplar = @codigoEjemplar AND p.Estado = 'Vigente'";
            con.Open();
            int cantidad = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return cantidad;
        }
    }
}