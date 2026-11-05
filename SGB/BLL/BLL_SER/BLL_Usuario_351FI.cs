using MAP.MAP_SER;
using Servicio;

namespace BLL.BLL_SER
{
    public class BLL_Usuario_351FI : IABMC_351FI<SER_Usuario_351FI>
    {
        MAP_Usuario_351FI map_usuario_351FI;
        BLL_Bitacora_351FI bll_bitacora_351FI;
        BLL_Idioma_351FI bll_idioma_351FI;
        MAP_Rol_351FI map_rol_351FI;
        BLL_DV_351FI bll_dv_351FI;
        public BLL_Usuario_351FI()
        {
            map_usuario_351FI = new MAP_Usuario_351FI();
            bll_bitacora_351FI = new BLL_Bitacora_351FI();
            bll_idioma_351FI = new BLL_Idioma_351FI();
            map_rol_351FI = new MAP_Rol_351FI();
            bll_dv_351FI = new BLL_DV_351FI();
        }

        public void Agregar_351FI(SER_Usuario_351FI usuario_351FI)
        {
            try
            {
                if (map_usuario_351FI.ValidarDniRepetido_351FI(usuario_351FI)) throw new Exception("El DNI está repetido!");
                if (map_usuario_351FI.ValidarCorreoRepetido_351FI(usuario_351FI)) throw new Exception("El correo electrónico está repetido!");
                string passwordHasheado = SER_Cripto_351FI.Encriptar_351FI(usuario_351FI.Password_351FI);
                usuario_351FI.Password_351FI = passwordHasheado;
                map_usuario_351FI.Agregar_351FI(usuario_351FI);
                
                bll_dv_351FI.GenerarDVH_351FI("usuario_351FI", usuario_351FI.Dni_351FI);
                bll_dv_351FI.GenerarDVV_351FI("usuario_351FI");
                
                SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Usuarios", "Crear usuario", 2);
                bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Borrar_351FI(SER_Usuario_351FI usuario_351FI)
        {
            throw new NotImplementedException();
        }

        public void Modificar_351FI(SER_Usuario_351FI usuario_351FI)
        {
            SER_Usuario_351FI usuAux = map_usuario_351FI.ConsultarPorNombreUsuario_351FI(usuario_351FI);
            if (usuAux != null && usuAux.Dni_351FI != usuario_351FI.Dni_351FI) throw new Exception("Ya existe usuario con este nombre de usuario");
            map_usuario_351FI.Modificar_351FI(usuario_351FI);
            
            bll_dv_351FI.GenerarDVH_351FI("usuario_351FI", usuario_351FI.Dni_351FI);
            bll_dv_351FI.GenerarDVV_351FI("usuario_351FI");
            
            SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Usuarios", "Modificar usuario", 2);
            bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);
        }
        public void ModificarPassword_351FI(string claveActual_351FI, string claveNueva_351FI)
        {
            if (claveActual_351FI == claveNueva_351FI) throw new Exception("No puede usar la misma contraseña");

            SER_Usuario_351FI usuario = SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI;
            if (SER_Cripto_351FI.Encriptar_351FI(claveActual_351FI) != usuario.Password_351FI) throw new Exception("Contraseña incorrecta");
            string claveNuevaHasheada = SER_Cripto_351FI.Encriptar_351FI(claveNueva_351FI);
            map_usuario_351FI.ModificarPassword_351FI(usuario, claveNuevaHasheada);

            usuario.Password_351FI = claveNuevaHasheada;
            bll_dv_351FI.GenerarDVH_351FI("usuario_351FI", usuario.Dni_351FI);
            bll_dv_351FI.GenerarDVV_351FI("usuario_351FI");
            
            SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(usuario, DateTime.Now, "Usuarios", "Cambiar clave", 1);
            bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);
        }
        public List<SER_Usuario_351FI> Consultar_351FI() => map_usuario_351FI.Consultar_351FI();
        public List<object> ConsultarParaGrilla_351FI()
        {
            var consulta = from u in Consultar_351FI()
                           select new
                           {
                               DNI = u.Dni_351FI,
                               Nombre = u.Nombre_351FI,
                               Apellido = u.Apellido_351FI,
                               Usuario = u.NombreUsuario_351FI,
                               Activo = u.Activo_351FI,
                               Bloqueado = u.Bloqueo_351FI,
                               Rol = u.Rol_351FI.Nombre_351FI
                           };
            return consulta.ToList<object>();
        }

        public SER_Usuario_351FI ConsultarPorId_351FI(SER_Usuario_351FI usuario_351FI)
        {
            return map_usuario_351FI.ConsultarPorId_351FI(usuario_351FI);
        }
        public List<object> ConsultarFiltrado_351FI(SER_Usuario_351FI us_351FI)
        {
            var consulta = from user in map_usuario_351FI.Consultar_351FI()
                           where
                           (string.IsNullOrWhiteSpace(us_351FI.Dni_351FI) || user.Dni_351FI.Contains(us_351FI.Dni_351FI))
                           &&
                           (string.IsNullOrWhiteSpace(us_351FI.Nombre_351FI) || user.Nombre_351FI.Contains(us_351FI.Nombre_351FI))
                           &&
                           (string.IsNullOrWhiteSpace(us_351FI.Apellido_351FI) || user.Apellido_351FI.Contains(us_351FI.Apellido_351FI))
                           &&
                           (string.IsNullOrWhiteSpace(us_351FI.Correo_351FI) || user.Correo_351FI.Contains(us_351FI.Correo_351FI))
                           &&
                           (string.IsNullOrWhiteSpace(us_351FI.NombreUsuario_351FI) || user.NombreUsuario_351FI.Contains(us_351FI.NombreUsuario_351FI))
                           &&
                           (string.IsNullOrWhiteSpace(us_351FI.Rol_351FI.Nombre_351FI) || user.Rol_351FI.Nombre_351FI.Contains(us_351FI.Rol_351FI.Nombre_351FI))
                           select new
                           {
                               DNI = user.Dni_351FI,
                               Nombre = user.Nombre_351FI,
                               Apellido = user.Apellido_351FI,
                               Usuario = user.NombreUsuario_351FI,
                               Activo = user.Activo_351FI,
                               Bloqueado = user.Bloqueo_351FI,
                               Rol = user.Rol_351FI.Nombre_351FI
                           };

            return consulta.ToList<object>();
        }
        public List<object> ConsultarActivos_351FI() 
        {
            var consulta = from u in Consultar_351FI()
                           where u.Activo_351FI
                           select new
                           {
                               DNI = u.Dni_351FI,
                               Nombre = u.Nombre_351FI,
                               Apellido = u.Apellido_351FI,
                               Usuario = u.NombreUsuario_351FI,
                               Activo = u.Activo_351FI,
                               Bloqueado = u.Bloqueo_351FI,
                               Rol = u.Rol_351FI.Nombre_351FI
                           };
            return consulta.ToList<object>();
        }

        public bool Login_351FI(SER_Usuario_351FI usuario_351FI, out string mensajeInconsistencia_351FI)
        {
            mensajeInconsistencia_351FI = null;

            bool rdo = false;

            SER_Usuario_351FI obj = map_usuario_351FI.ConsultarPorNombreUsuario_351FI(usuario_351FI);
            if (obj == null) throw new Exception("Datos erróneos!");

            if (EstaBloqueado_351FI(obj)) throw new Exception("La cuenta está bloqueada!");
            if (!EstaActivo_351FI(obj)) throw new Exception("El usuario se encuentra desactivado!");

            if (!CompararPassword_351FI(obj, usuario_351FI.Password_351FI))
            {
                map_usuario_351FI.SumarCantidadIntento_351FI(obj);
                obj.CantIntentos_351FI += 1;

                bll_dv_351FI.GenerarDVH_351FI("usuario_351FI", obj.Dni_351FI);
                bll_dv_351FI.GenerarDVV_351FI("usuario_351FI");

                if (map_usuario_351FI.ConsultarPorNombreUsuario_351FI(usuario_351FI).CantIntentos_351FI >= 3)
                {
                    map_usuario_351FI.Bloquear_351FI(obj);
                    obj.Bloqueo_351FI = true;

                    bll_dv_351FI.GenerarDVH_351FI("usuario_351FI", obj.Dni_351FI);
                    bll_dv_351FI.GenerarDVV_351FI("usuario_351FI");

                    throw new Exception("Se bloqueó el usuario por motivos de seguridad!");
                }

                throw new Exception("No se pudo iniciar sesión");
            }

            bool integro = true;

           try
           {
               bll_dv_351FI.VerificarIntegridad_351FI();
           }
           catch (Exception ex)
           {
               integro = false;
               mensajeInconsistencia_351FI = ex.Message;
           }

           bool esAdmin = obj.Rol_351FI.Id_351FI == 1;

           if (!integro && !esAdmin)throw new Exception("El sistema no se encuentra disponible. Contacte con un administrador si el problema persiste."); 


            try
            {
                bll_idioma_351FI.CambiarIdioma_351FI(obj.IdIdioma_351FI);
            }
            catch
            {
                try { bll_idioma_351FI.CambiarIdioma_351FI("es-AR"); } catch { }
            }

            rdo = true;

            SER_SesionManager_351FI sesion = SER_SesionManager_351FI.ObtenerSesion_351FI();

            map_usuario_351FI.ReiniciarIntentos_351FI(obj);

            obj.CantIntentos_351FI = 0;
            
            if (integro)
            {
                bll_dv_351FI.GenerarDVH_351FI("usuario_351FI", obj.Dni_351FI);
                bll_dv_351FI.GenerarDVV_351FI("usuario_351FI");
            }

           
            obj.Rol_351FI = map_rol_351FI.ObtenerArbol_351FI(obj.Rol_351FI.Id_351FI);

            sesion.Usuario_351FI = obj;

            SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(obj, DateTime.Now, "Usuarios", "Login", 1);
            bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);

            return rdo;
        }

        public void Logout_351FI()
        {
            SER_Usuario_351FI usuario = SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI;
            if (usuario != null)
            {
                usuario.IdIdioma_351FI = bll_idioma_351FI.IdiomaActual_351FI;
                map_usuario_351FI.ModificarIdioma_351FI(usuario);
                
                bll_dv_351FI.GenerarDVH_351FI("usuario_351FI", usuario.Dni_351FI);
                bll_dv_351FI.GenerarDVV_351FI("usuario_351FI");
                
                bll_bitacora_351FI.RegistrarBitacora_351FI(new SER_Bitacora_351FI(usuario, DateTime.Now, "Usuarios", "Logout", 2));
                bll_bitacora_351FI.RegistrarBitacora_351FI(new SER_Bitacora_351FI(usuario, DateTime.Now, "Usuarios", "Cambiar Idioma", 3));
                SER_SesionManager_351FI.CerrarSesion_351FI();
            }
            bll_idioma_351FI.CambiarIdioma_351FI("es-AR");
        }

        private bool CompararPassword_351FI(SER_Usuario_351FI usuario_351FI, string password_351FI)
        {
            bool rdo = false;
            string passwordHasheada = SER_Cripto_351FI.Encriptar_351FI(password_351FI);
            if (passwordHasheada == usuario_351FI.Password_351FI) rdo = true;
            return rdo;
        }
        private bool EstaBloqueado_351FI(SER_Usuario_351FI usuario_351FI)
        {
            bool rdo = false;
            if (usuario_351FI.Bloqueo_351FI) rdo = true;
            return rdo;
        }
        private bool EstaActivo_351FI(SER_Usuario_351FI usuario_351FI)
        {
            bool rdo = false;
            if (usuario_351FI.Activo_351FI) rdo = true;
            return rdo;
        }
        public void Desbloquear_351FI(SER_Usuario_351FI usuario_351FI)
        {
            try
            {
                SER_Usuario_351FI usuarioAux = ConsultarPorId_351FI(usuario_351FI);
                if (!EstaBloqueado_351FI(usuarioAux)) throw new Exception("El usuario no está bloqueado!");

                map_usuario_351FI.Desbloquear_351FI(usuarioAux);
                usuarioAux.Bloqueo_351FI = false;

                string nuevaPasswordHasheada = SER_Cripto_351FI.Encriptar_351FI(usuarioAux.Dni_351FI + usuarioAux.Apellido_351FI);
                map_usuario_351FI.ModificarPassword_351FI(usuarioAux, nuevaPasswordHasheada);
                usuarioAux.Password_351FI = nuevaPasswordHasheada;

                map_usuario_351FI.ReiniciarIntentos_351FI(usuarioAux);
                usuarioAux.CantIntentos_351FI = 0;

                bll_dv_351FI.GenerarDVH_351FI("usuario_351FI", usuarioAux.Dni_351FI);
                bll_dv_351FI.GenerarDVV_351FI("usuario_351FI");

                SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Usuarios", "Desbloquear usuario", 2);
                bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void CambiarEstadoActivo_351FI(SER_Usuario_351FI usuario_351FI)
        {
            SER_Usuario_351FI usuarioAux = map_usuario_351FI.ConsultarPorId_351FI(usuario_351FI);
            if (usuarioAux != null)
            {
                usuarioAux.Activo_351FI = !usuarioAux.Activo_351FI;
                map_usuario_351FI.CambiarEstadoActivo_351FI(usuarioAux);

                bll_dv_351FI.GenerarDVH_351FI("usuario_351FI", usuarioAux.Dni_351FI);
                bll_dv_351FI.GenerarDVV_351FI("usuario_351FI");
                
                if (usuarioAux.Activo_351FI)
                {
                    SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Usuarios", "Activar usuario", 3);
                    
                    bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);
                }
                else
                {
                    SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Usuarios", "Desactivar usuario", 3);
                    bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);
                }
            }
        }
    }
}
