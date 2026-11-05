namespace Servicio
{
    public interface IABMC_351FI<T>
    {
        void Agregar_351FI(T obj_351FI);
        void Borrar_351FI(T obj_351FI);
        void Modificar_351FI(T obj_351FI);
        List<T> Consultar_351FI();
        T ConsultarPorId_351FI(T obj_351FI);
    }
}
