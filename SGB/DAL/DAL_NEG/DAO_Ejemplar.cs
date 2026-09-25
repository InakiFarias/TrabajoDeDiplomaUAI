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

        public SqlDataReader BuscarPorTexto(string texto)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@texto", SqlDbType.VarChar).Value = "%" + texto + "%";
            cm.CommandText = @"SELECT e.CodigoEjemplar, e.Estado, l.CodigoLibro, l.Titulo
                               FROM Ejemplar e
                               INNER JOIN Libro l ON l.CodigoLibro = e.CodigoLibro
                               WHERE e.CodigoEjemplar LIKE @texto
                               OR l.Titulo LIKE @texto
                               OR EXISTS (SELECT 1 FROM Libro_Autor la
                                          INNER JOIN Autor a ON a.CodigoAutor = la.CodigoAutor
                                          WHERE la.CodigoLibro = l.CodigoLibro
                                          AND (a.Nombre + ' ' + a.Apellido) LIKE @texto)";
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
    }
}