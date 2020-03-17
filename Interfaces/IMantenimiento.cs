namespace libPiky.Interfaces
{
    public interface IMantenimiento
    {
        void Ingresar(object Elemento);
        void Modificar();
        void Eliminar(object Elemento);
        object Consultar(string id);
        void Listar();
    }
}