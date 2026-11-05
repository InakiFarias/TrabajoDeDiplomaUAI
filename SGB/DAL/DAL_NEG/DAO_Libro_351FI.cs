using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Libro_351FI : Conexion_351FI
    {
        SqlCommand cm_351FI;
        public DAO_Libro_351FI() : base()
        {
            cm_351FI = new SqlCommand("select * from Libro_351FI", con_351FI);
        }

        // ------------------------------------------------------------ Libros

        public SqlDataReader BuscarPorTexto_351FI(string texto_351FI, bool soloActivos_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@texto", SqlDbType.VarChar).Value = "%" + texto_351FI + "%";
            cm_351FI.CommandText = @"SELECT l.CodigoLibro_351FI, l.Titulo_351FI, l.Estado_351FI
                               FROM Libro_351FI l
                               WHERE (l.CodigoLibro_351FI LIKE @texto
                                      OR l.Titulo_351FI LIKE @texto
                                      OR EXISTS (SELECT 1 FROM Libro_Autor_351FI la
                                                 INNER JOIN Autor_351FI a ON a.CodigoAutor_351FI = la.CodigoAutor_351FI
                                                 WHERE la.CodigoLibro_351FI = l.CodigoLibro_351FI
                                                 AND (a.Nombre_351FI + ' ' + a.Apellido_351FI) LIKE @texto))"
                             + (soloActivos_351FI ? " AND l.Estado_351FI = 'Activo'" : "")
                             + " ORDER BY l.Titulo_351FI";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader ObtenerAutoresDeLibro_351FI(string codigoLibro_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro_351FI;
            cm_351FI.CommandText = @"SELECT a.CodigoAutor_351FI, a.Nombre_351FI, a.Apellido_351FI
                               FROM Autor_351FI a
                               INNER JOIN Libro_Autor_351FI la ON la.CodigoAutor_351FI = a.CodigoAutor_351FI
                               WHERE la.CodigoLibro_351FI = @codigoLibro";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader ObtenerTemasDeLibro_351FI(string codigoLibro_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro_351FI;
            cm_351FI.CommandText = @"SELECT t.CodigoTema_351FI, t.Descripcion_351FI
                               FROM Tema_351FI t
                               INNER JOIN Libro_Tema_351FI lt ON lt.CodigoTema_351FI = t.CodigoTema_351FI
                               WHERE lt.CodigoLibro_351FI = @codigoLibro";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public string ObtenerSiguienteCodigo_351FI()
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.CommandText = @"SELECT ISNULL(MAX(CAST(SUBSTRING(CodigoLibro_351FI, 5, 16) AS int)), 0) + 1
                               FROM Libro_351FI WHERE CodigoLibro_351FI LIKE 'LIB-%'";
            con_351FI.Open();
            int numero = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return "LIB-" + numero.ToString("D4");
        }

        public void InsertarLibro_351FI(string codigoLibro_351FI, string titulo_351FI, string estado_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro_351FI;
            cm_351FI.Parameters.Add("@titulo", SqlDbType.VarChar).Value = titulo_351FI;
            cm_351FI.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado_351FI;
            cm_351FI.CommandText = "INSERT INTO Libro_351FI (CodigoLibro_351FI, Titulo_351FI, Estado_351FI) VALUES (@codigoLibro, @titulo, @estado)";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public void ModificarLibro_351FI(string codigoLibro_351FI, string titulo_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro_351FI;
            cm_351FI.Parameters.Add("@titulo", SqlDbType.VarChar).Value = titulo_351FI;
            cm_351FI.CommandText = "UPDATE Libro_351FI SET Titulo_351FI = @titulo WHERE CodigoLibro_351FI = @codigoLibro";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public void ActualizarEstado_351FI(string codigoLibro_351FI, string estado_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro_351FI;
            cm_351FI.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado_351FI;
            cm_351FI.CommandText = "UPDATE Libro_351FI SET Estado_351FI = @estado WHERE CodigoLibro_351FI = @codigoLibro";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public void BorrarAutoresDeLibro_351FI(string codigoLibro_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro_351FI;
            cm_351FI.CommandText = "DELETE FROM Libro_Autor_351FI WHERE CodigoLibro_351FI = @codigoLibro";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public void InsertarAutorDeLibro_351FI(string codigoLibro_351FI, int codigoAutor_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro_351FI;
            cm_351FI.Parameters.Add("@codigoAutor", SqlDbType.Int).Value = codigoAutor_351FI;
            cm_351FI.CommandText = "INSERT INTO Libro_Autor_351FI (CodigoLibro_351FI, CodigoAutor_351FI) VALUES (@codigoLibro, @codigoAutor)";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public void BorrarTemasDeLibro_351FI(string codigoLibro_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro_351FI;
            cm_351FI.CommandText = "DELETE FROM Libro_Tema_351FI WHERE CodigoLibro_351FI = @codigoLibro";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public void InsertarTemaDeLibro_351FI(string codigoLibro_351FI, int codigoTema_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro_351FI;
            cm_351FI.Parameters.Add("@codigoTema", SqlDbType.Int).Value = codigoTema_351FI;
            cm_351FI.CommandText = "INSERT INTO Libro_Tema_351FI (CodigoLibro_351FI, CodigoTema_351FI) VALUES (@codigoLibro, @codigoTema)";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        // Ejemplares que no fueron dados de baja
        public int ContarEjemplaresActivos_351FI(string codigoLibro_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro_351FI;
            cm_351FI.CommandText = "SELECT COUNT(*) FROM Ejemplar_351FI WHERE CodigoLibro_351FI = @codigoLibro AND Estado_351FI <> 'Baja'";
            con_351FI.Open();
            int cantidad = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return cantidad;
        }

        // ------------------------------------------------------------ Autores y temas

        public SqlDataReader ObtenerAutores_351FI()
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.CommandText = "SELECT CodigoAutor_351FI, Nombre_351FI, Apellido_351FI FROM Autor_351FI ORDER BY Apellido_351FI, Nombre_351FI";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public bool ExisteAutor_351FI(string nombre_351FI, string apellido_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre_351FI;
            cm_351FI.Parameters.Add("@apellido", SqlDbType.VarChar).Value = apellido_351FI;
            cm_351FI.CommandText = "SELECT COUNT(*) FROM Autor_351FI WHERE Nombre_351FI = @nombre AND Apellido_351FI = @apellido";
            con_351FI.Open();
            int cantidad = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return cantidad > 0;
        }

        public int InsertarAutor_351FI(string nombre_351FI, string apellido_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre_351FI;
            cm_351FI.Parameters.Add("@apellido", SqlDbType.VarChar).Value = apellido_351FI;
            cm_351FI.CommandText = @"INSERT INTO Autor_351FI (Nombre_351FI, Apellido_351FI)
                               OUTPUT INSERTED.CodigoAutor_351FI
                               VALUES (@nombre, @apellido)";
            con_351FI.Open();
            int codigoAutor = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return codigoAutor;
        }

        public SqlDataReader ObtenerTemas_351FI()
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.CommandText = "SELECT CodigoTema_351FI, Descripcion_351FI FROM Tema_351FI ORDER BY Descripcion_351FI";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public bool ExisteTema_351FI(string descripcion_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion_351FI;
            cm_351FI.CommandText = "SELECT COUNT(*) FROM Tema_351FI WHERE Descripcion_351FI = @descripcion";
            con_351FI.Open();
            int cantidad = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return cantidad > 0;
        }

        public int InsertarTema_351FI(string descripcion_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion_351FI;
            cm_351FI.CommandText = @"INSERT INTO Tema_351FI (Descripcion_351FI)
                               OUTPUT INSERTED.CodigoTema_351FI
                               VALUES (@descripcion)";
            con_351FI.Open();
            int codigoTema = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return codigoTema;
        }
    }
}
