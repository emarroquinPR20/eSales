namespace libPiky.Interfaces
{
    public interface IMantenimiento
    {
        void Ingresar(object Elemento);
        void Modificar();
        void Eliminar(object Elemento);
        object Consultar(int id);
        void Listar(object Elemento);
    }
}