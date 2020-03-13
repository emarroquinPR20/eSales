namespace libPiky.Interfaces
{
    public interface IMantenimiento
    {
         void Ingresar(object Elemento);
        void Modificar(object Elemento);
        void Eliminar(object Elemento);
        void Consultar(int id);
    }
}