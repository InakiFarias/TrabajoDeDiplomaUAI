using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Ejemplar_351FI : Conexion_351FI
    {
        SqlCommand cm_351FI;
        public DAO_Ejemplar_351FI() : base()
        {
            cm_351FI = new SqlCommand("select * from Ejemplar_351FI", con_351FI);
        }

        public SqlDataReader BuscarPorTexto_351FI(string texto_351FI, bool incluirBajas_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@texto", SqlDbType.VarChar).Value = "%" + texto_351FI + "%";
            cm_351FI.CommandText = @"SELECT e.CodigoEjemplar_351FI, e.Estado_351FI, l.CodigoLibro_351FI, l.Titulo_351FI
                               FROM Ejemplar_351FI e
                               INNER JOIN Libro_351FI l ON l.CodigoLibro_351FI = e.CodigoLibro_351FI
                               WHERE (e.CodigoEjemplar_351FI LIKE @texto
                                      OR l.Titulo_351FI LIKE @texto
                                      OR EXISTS (SELECT 1 FROM Libro_Autor_351FI la
                                                 INNER JOIN Autor_351FI a ON a.CodigoAutor_351FI = la.CodigoAutor_351FI
                                                 WHERE la.CodigoLibro_351FI = l.CodigoLibro_351FI
                                                 AND (a.Nombre_351FI + ' ' + a.Apellido_351FI) LIKE @texto))"
                             + (incluirBajas_351FI ? "" : " AND e.Estado_351FI <> 'Baja'")
                             + " ORDER BY e.CodigoEjemplar_351FI";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader BuscarPorCodigo_351FI(string codigo_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo_351FI;
            cm_351FI.CommandText = @"SELECT e.CodigoEjemplar_351FI, e.Estado_351FI, l.CodigoLibro_351FI, l.Titulo_351FI
                               FROM Ejemplar_351FI e
                               INNER JOIN Libro_351FI l ON l.CodigoLibro_351FI = e.CodigoLibro_351FI
                               WHERE e.CodigoEjemplar_351FI = @codigo";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader ObtenerPorPrestamo_351FI(int numeroPrestamo_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroPrestamo", SqlDbType.Int).Value = numeroPrestamo_351FI;
            cm_351FI.CommandText = @"SELECT e.CodigoEjemplar_351FI, e.Estado_351FI, l.CodigoLibro_351FI, l.Titulo_351FI
                               FROM Prestamo_Ejemplar_351FI pe
                               INNER JOIN Ejemplar_351FI e ON e.CodigoEjemplar_351FI = pe.CodigoEjemplar_351FI
                               INNER JOIN Libro_351FI l ON l.CodigoLibro_351FI = e.CodigoLibro_351FI
                               WHERE pe.NumeroPrestamo_351FI = @numeroPrestamo";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader ObtenerAutores_351FI(string codigoLibro_351FI)
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

        public string ObtenerSiguienteCodigo_351FI()
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.CommandText = @"SELECT ISNULL(MAX(CAST(SUBSTRING(CodigoEjemplar_351FI, 4, 16) AS int)), 0) + 1
                               FROM Ejemplar_351FI WHERE CodigoEjemplar_351FI LIKE 'EJ-%'";
            con_351FI.Open();
            int numero = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return "EJ-" + numero.ToString("D5");
        }

        public void InsertarEjemplar_351FI(string codigoEjemplar_351FI, string codigoLibro_351FI, string estado_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@codigoEjemplar", SqlDbType.VarChar).Value = codigoEjemplar_351FI;
            cm_351FI.Parameters.Add("@codigoLibro", SqlDbType.VarChar).Value = codigoLibro_351FI;
            cm_351FI.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado_351FI;
            cm_351FI.CommandText = "INSERT INTO Ejemplar_351FI (CodigoEjemplar_351FI, CodigoLibro_351FI, Estado_351FI) VALUES (@codigoEjemplar, @codigoLibro, @estado)";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public void ActualizarEstado_351FI(string codigoEjemplar_351FI, string estado_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@codigoEjemplar", SqlDbType.VarChar).Value = codigoEjemplar_351FI;
            cm_351FI.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado_351FI;
            cm_351FI.CommandText = "UPDATE Ejemplar_351FI SET Estado_351FI = @estado WHERE CodigoEjemplar_351FI = @codigoEjemplar";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        // Préstamos vigentes que incluyen al ejemplar
        public int ContarPrestamosVigentes_351FI(string codigoEjemplar_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@codigoEjemplar", SqlDbType.VarChar).Value = codigoEjemplar_351FI;
            cm_351FI.CommandText = @"SELECT COUNT(*) FROM Prestamo_Ejemplar_351FI pe
                               INNER JOIN Prestamo_351FI p ON p.NumeroPrestamo_351FI = pe.NumeroPrestamo_351FI
                               WHERE pe.CodigoEjemplar_351FI = @codigoEjemplar AND p.Estado_351FI = 'Vigente'";
            con_351FI.Open();
            int cantidad = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return cantidad;
        }
    }
}