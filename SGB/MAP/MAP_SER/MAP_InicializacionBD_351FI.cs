using DAL.DAL_SER;

namespace MAP.MAP_SER
{
    public class MAP_InicializacionBD_351FI
    {
        DAO_InicializacionBD_351FI dao_inicializacion_351FI;
        public MAP_InicializacionBD_351FI() { dao_inicializacion_351FI = new(); }
        public bool ExisteBase_351FI() => dao_inicializacion_351FI.ExisteBase_351FI();
        public void CrearBase_351FI(List<string> scripts_351FI) => dao_inicializacion_351FI.CrearBase_351FI(scripts_351FI);
        public void VerificarAcceso_351FI() => dao_inicializacion_351FI.VerificarAcceso_351FI();
    }
}
