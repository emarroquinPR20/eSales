using System;
namespace libPiky.Entities
{
    public class Articulo
    {

        public string IdArticulo { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Referencia { get; set; }
        public int IdProveedor { get; set; }
        public int Stock { get; set; }

        public Articulo()
        {
            this.IdArticulo = GeneraId();
        }
        public Articulo(string nombre, string marca, string referencia, int idProveedor, int stock)
        {
            IdArticulo = GeneraId();
            Nombre = nombre;
            Marca = marca;
            Referencia = referencia;
            IdProveedor = idProveedor;
            Stock = stock;
        }

        private string GeneraId()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }

        public override string ToString()
        {
            return $"{{\"Id\": \"{this.IdArticulo}\", \"Nombre\": \"{this.Nombre}\", \"Marca\": \"{this.Marca}\", \"Referencia\": \"{this.Referencia}\", \"Id Proveedor\": \"{this.IdProveedor}\", \"Stock\": \"{this.Stock}\"}}";
        }

    }
}