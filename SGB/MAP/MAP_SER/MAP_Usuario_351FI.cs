using DAL;
using Microsoft.Data.SqlClient;
using Servicio;

namespace MAP.MAP_SER
{
    public class MAP_Usuario_351FI : IABMC_351FI<SER_Usuario_351FI>
    {
        DAO_Usuario_351FI dao_usuario_351FI;
        MAP_Rol_351FI map_rol_351FI;
        public MAP_Usuario_351FI()
        {
            dao_usuario_351FI = new DAO_Usuario_351FI();
            map_rol_351FI = new MAP_Rol_351FI();
        }

        public void Agregar_351FI(SER_Usuario_351FI usuario_351FI)
        {
            dao_usuario_351FI.Agregar_351FI(usuario_351FI.Dni_351FI, usuario_351FI.Nombre_351FI, usuario_351FI.Apellido_351FI, usuario_351FI.Correo_351FI, usuario_351FI.NombreUsuario_351FI, usuario_351FI.Password_351FI, usuario_351FI.Bloqueo_351FI, usuario_351FI.Activo_351FI, usuario_351FI.CantIntentos_351FI, usuario_351FI.Rol_351FI.Id_351FI, usuario_351FI.IdIdioma_351FI);
        }

        public void Borrar_351FI(SER_Usuario_351FI usuario_351FI)
        {
            throw new NotImplementedException();
        }

        public void Modificar_351FI(SER_Usuario_351FI usuario_351FI)
        {
            dao_usuario_351FI.Modificar_351FI(usuario_351FI.Dni_351FI, usuario_351FI.Nombre_351FI, usuario_351FI.Apellido_351FI, usuario_351FI.NombreUsuario_351FI);
        }
        public void ModificarPassword_351FI(SER_Usuario_351FI usuario_351FI, string claveNueva_351FI)
        {
            dao_usuario_351FI.ModificarPassword_351FI(usuario_351FI.Dni_351FI, claveNueva_351FI);
        }
        public List<SER_Usuario_351FI> Consultar_351FI()
        {
            List<SER_Usuario_351FI> lista = new List<SER_Usuario_351FI>();
            SqlDataReader dr = dao_usuario_351FI.Consultar_351FI();

            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                lista.Add(
                        new SER_Usuario_351FI(
                                Convert.ToString(datos[0]),
                                Convert.ToString(datos[1]),
                                Convert.ToString(datos[2]),
                                Convert.ToString(datos[3]),
                                Convert.ToString(datos[4]),
                                Convert.ToString(datos[5]),
                                Convert.ToBoolean(datos[6]),
                                Convert.ToBoolean(datos[7]),
                                Convert.ToInt32(datos[8]),
                                map_rol_351FI.ObtenerRolPorId_351FI(Convert.ToInt16(datos[9])),
                                Convert.ToString(datos[10])
                            )
                    );
            }
            dr.Close();
            return lista;
        }
        public SER_Usuario_351FI? ConsultarPorId_351FI(SER_Usuario_351FI usuario_351FI)
        {
            SER_Usuario_351FI usuarioAux = null;
            SqlDataReader dr = dao_usuario_351FI.ConsultarPorId_351FI(usuario_351FI.Dni_351FI);
            if (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                usuarioAux = new SER_Usuario_351FI(
                               Convert.ToString(datos[0]),
                               Convert.ToString(datos[1]),
                               Convert.ToString(datos[2]),
                               Convert.ToString(datos[3]),
                               Convert.ToString(datos[4]),
                               Convert.ToString(datos[5]),
                               Convert.ToBoolean(datos[6]),
                               Convert.ToBoolean(datos[7]),
                               Convert.ToInt16(datos[8]),
                               map_rol_351FI.ObtenerRolPorId_351FI(Convert.ToInt16(datos[9])),
                               Convert.ToString(datos[10])
                           );
            }
            dr.Close();
            return usuarioAux;
        }
        public SER_Usuario_351FI? ConsultarPorNombreUsuario_351FI(SER_Usuario_351FI usuario_351FI)
        {
            SER_Usuario_351FI usuarioAux = null;
            SqlDataReader dr = dao_usuario_351FI.ConsultarPorNombreUsuario_351FI(usuario_351FI.NombreUsuario_351FI);
            if (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                usuarioAux = new SER_Usuario_351FI(
                                Convert.ToString(datos[0]),
                                Convert.ToString(datos[1]),
                                Convert.ToString(datos[2]),
                                Convert.ToString(datos[3]),
                                Convert.ToString(datos[4]),
                                Convert.ToString(datos[5]),
                                Convert.ToBoolean(datos[6]),
                                Convert.ToBoolean(datos[7]),
                                Convert.ToInt16(datos[8]),
                                map_rol_351FI.ObtenerRolPorId_351FI(Convert.ToInt16(datos[9])),
                                Convert.ToString(datos[10])
                            );
            }
            dr.Close();
            return usuarioAux;
        }
      
        public bool ValidarDniRepetido_351FI(SER_Usuario_351FI usuario_351FI) => dao_usuario_351FI.ValidarRepetido_351FI(usuario_351FI.Dni_351FI);
        public bool ExisteNombreUsuario_351FI(SER_Usuario_351FI usuario_351FI) => dao_usuario_351FI.ExisteNombreUsuario_351FI(usuario_351FI.NombreUsuario_351FI);
        public bool ValidarCorreoRepetido_351FI(SER_Usuario_351FI usuario_351FI) => dao_usuario_351FI.ValidarCorreoRepetido_351FI(usuario_351FI.Correo_351FI);
        public void SumarCantidadIntento_351FI(SER_Usuario_351FI usuario_351FI) => dao_usuario_351FI.SumarCantidadIntento_351FI(usuario_351FI.Dni_351FI);
        public void Bloquear_351FI(SER_Usuario_351FI usuario_351FI) => dao_usuario_351FI.Bloquear_351FI(usuario_351FI.Dni_351FI);
        public void ReiniciarIntentos_351FI(SER_Usuario_351FI usuario_351FI) => dao_usuario_351FI.ReiniciarIntentos_351FI(usuario_351FI.Dni_351FI);
        public void Desbloquear_351FI(SER_Usuario_351FI usuario_351FI) => dao_usuario_351FI.Desbloquear_351FI(usuario_351FI.Dni_351FI);
        public void CambiarEstadoActivo_351FI(SER_Usuario_351FI usuario_351FI) => dao_usuario_351FI.CambiarEstadoActivo_351FI(usuario_351FI.Dni_351FI, usuario_351FI.Activo_351FI);
        public void ModificarIdioma_351FI(SER_Usuario_351FI usuario_351FI)
        {
            dao_usuario_351FI.ModificarIdioma_351FI(usuario_351FI.Dni_351FI, usuario_351FI.IdIdioma_351FI);
        }
    }
}
