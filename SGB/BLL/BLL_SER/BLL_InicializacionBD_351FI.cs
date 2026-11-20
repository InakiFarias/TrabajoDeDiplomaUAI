using MAP.MAP_SER;

namespace BLL.BLL_SER
{
    public class BLL_InicializacionBD_351FI
    {
        MAP_InicializacionBD_351FI map_inicializacion_351FI;
        public BLL_InicializacionBD_351FI() { map_inicializacion_351FI = new(); }

        // Se llama antes del login. Si la base no existe, la crea con los scripts de BD_SQL y
        // genera sus dígitos verificadores, para que el primer login no marque inconsistencias.
        // Devuelve true si creó la base.
        public bool InicializarBase_351FI()
        {
            bool creada = false;
            if (!map_inicializacion_351FI.ExisteBase_351FI())
            {
                map_inicializacion_351FI.CrearBase_351FI(new List<string>
                {
                    "01_seguridad.sql",
                    "02_negocio.sql",
                    "03_carga_inicial.sql",
                    "04_datos_prueba.sql"
                });
                new BLL_DV_351FI().GenerarDVInicial_351FI();
                creada = true;
            }
            map_inicializacion_351FI.VerificarAcceso_351FI();
            return creada;
        }
    }
}
