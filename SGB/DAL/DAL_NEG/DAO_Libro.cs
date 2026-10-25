using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Libro : Conexion
    {
        SqlCommand cm;
        public DAO_Libro() : base()
        {
            cm = new SqlCommand("select * from Libro", con);
        }

        // ------------------------------------------------------------ Libros

        public SqlDataReader BuscarPorTexto(string texto, bool soloActivos)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@texto", SqlDbType.VarChar).Value = "%" + texto + "%";
            cm.CommandText = @"SELECT l.CodigoLibro, l.Titulo, l.Estado
                               FROM Libro l
                               WHERE (l.CodigoLibro LIKE @texto
                                      OR l.Titulo LIKE @texto
                                      OR EXISTS (SELECT 1 FROM Libro_Autor la
                                                 INNER JOIN Autor a ON a.CodigoAutor = la.CodigoAutor
                                                 WHERE la.CodigoLibro = l.CodigoLibro
                                                 AND (a.Nombre + ' ' + a.Apellido) LIKE @texto))"
                             + (soloActivos ? " AND l.Estado = 'Activo'" : "")
                             + " ORDER BY l.Titulo";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader ObtenerAutoresDeLibro(string codigoLibro)
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

        public SqlDataReader ObtenerTemasDeLibro(string codigoLibro)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro;
            cm.CommandText = @"SELECT t.CodigoTema, t.Descripcion
                               FROM Tema t
                               INNER JOIN Libro_Tema lt ON lt.CodigoTema = t.CodigoTema
                               WHERE lt.CodigoLibro = @codigoLibro";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public string ObtenerSiguienteCodigo()
        {
            cm.Parameters.Clear();
            cm.CommandText = @"SELECT ISNULL(MAX(CAST(SUBSTRING(CodigoLibro, 5, 16) AS int)), 0) + 1
                               FROM Libro WHERE CodigoLibro LIKE 'LIB-%'";
            con.Open();
            int numero = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return "LIB-" + numero.ToString("D4");
        }

        public void InsertarLibro(string codigoLibro, string titulo, string estado)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro;
            cm.Parameters.Add("@titulo", SqlDbType.VarChar).Value = titulo;
            cm.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado;
            cm.CommandText = "INSERT INTO Libro (CodigoLibro, Titulo, Estado) VALUES (@codigoLibro, @titulo, @estado)";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }

        public void ModificarLibro(string codigoLibro, string titulo)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro;
            cm.Parameters.Add("@titulo", SqlDbType.VarChar).Value = titulo;
            cm.CommandText = "UPDATE Libro SET Titulo = @titulo WHERE CodigoLibro = @codigoLibro";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }

        public void ActualizarEstado(string codigoLibro, string estado)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro;
            cm.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado;
            cm.CommandText = "UPDATE Libro SET Estado = @estado WHERE CodigoLibro = @codigoLibro";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }

        public void BorrarAutoresDeLibro(string codigoLibro)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro;
            cm.CommandText = "DELETE FROM Libro_Autor WHERE CodigoLibro = @codigoLibro";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }

        public void InsertarAutorDeLibro(string codigoLibro, int codigoAutor)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro;
            cm.Parameters.Add("@codigoAutor", SqlDbType.Int).Value = codigoAutor;
            cm.CommandText = "INSERT INTO Libro_Autor (CodigoLibro, CodigoAutor) VALUES (@codigoLibro, @codigoAutor)";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }

        public void BorrarTemasDeLibro(string codigoLibro)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro;
            cm.CommandText = "DELETE FROM Libro_Tema WHERE CodigoLibro = @codigoLibro";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }

        public void InsertarTemaDeLibro(string codigoLibro, int codigoTema)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro;
            cm.Parameters.Add("@codigoTema", SqlDbType.Int).Value = codigoTema;
            cm.CommandText = "INSERT INTO Libro_Tema (CodigoLibro, CodigoTema) VALUES (@codigoLibro, @codigoTema)";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }

        // Ejemplares que no fueron dados de baja
        public int ContarEjemplaresActivos(string codigoLibro)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro;
            cm.CommandText = "SELECT COUNT(*) FROM Ejemplar WHERE CodigoLibro = @codigoLibro AND Estado <> 'Baja'";
            con.Open();
            int cantidad = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return cantidad;
        }

        // ------------------------------------------------------------ Autores y temas

        public SqlDataReader ObtenerAutores()
        {
            cm.Parameters.Clear();
            cm.CommandText = "SELECT CodigoAutor, Nombre, Apellido FROM Autor ORDER BY Apellido, Nombre";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public bool ExisteAutor(string nombre, string apellido)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
            cm.Parameters.Add("@apellido", SqlDbType.VarChar).Value = apellido;
            cm.CommandText = "SELECT COUNT(*) FROM Autor WHERE Nombre = @nombre AND Apellido = @apellido";
            con.Open();
            int cantidad = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return cantidad > 0;
        }

        public int InsertarAutor(string nombre, string apellido)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
            cm.Parameters.Add("@apellido", SqlDbType.VarChar).Value = apellido;
            cm.CommandText = @"INSERT INTO Autor (Nombre, Apellido)
                               OUTPUT INSERTED.CodigoAutor
                               VALUES (@nombre, @apellido)";
            con.Open();
            int codigoAutor = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return codigoAutor;
        }

        public SqlDataReader ObtenerTemas()
        {
            cm.Parameters.Clear();
            cm.CommandText = "SELECT CodigoTema, Descripcion FROM Tema ORDER BY Descripcion";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public bool ExisteTema(string descripcion)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion;
            cm.CommandText = "SELECT COUNT(*) FROM Tema WHERE Descripcion = @descripcion";
            con.Open();
            int cantidad = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return cantidad > 0;
        }

        public int InsertarTema(string descripcion)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion;
            cm.CommandText = @"INSERT INTO Tema (Descripcion)
                               OUTPUT INSERTED.CodigoTema
                               VALUES (@descripcion)";
            con.Open();
            int codigoTema = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return codigoTema;
        }
    }
}
