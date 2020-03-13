namespace libPiky.Entities
{
    public class Articulo
    {

        public int IdArticulo { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Referencia { get; set; }
        public int IdProveedor { get; set; }
        public int Stock { get; set; }

        public Articulo()
        {

        }
        public Articulo(int idArticulo, string nombre, string marca, string referencia, int idProveedor, int stock)
        {
            IdArticulo = idArticulo;
            Nombre = nombre;
            Marca = marca;
            Referencia = referencia;
            IdProveedor = idProveedor;
            Stock = stock;
        }


    }
}