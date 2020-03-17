using System;
namespace libPiky.Entities
{
    public class Venta
    {
        public string IdVenta { get; set; }
        public string Documento { get; set; }
        public int IdArticulo { get; set; }
        public string Fecha { get; set; }
        public int Cantidad { get; set; }
        public double ValorUnidad { get; set; }
        public int IdCliente { get; set; }

        public Venta()
        {
            IdVenta = GeneraId();
        }
        public Venta(string documento, int idArticulo, string fecha, int cantidad, double valorUnidad, int idCliente)
        {
            IdVenta = GeneraId();
            Documento = documento;
            IdArticulo = idArticulo;
            Fecha = fecha;
            Cantidad = cantidad;
            ValorUnidad = valorUnidad;
            IdCliente = idCliente;
        }

        private string GeneraId()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }

        public override string ToString()
        {
            return $"{{\"Id\": \"{this.IdVenta}\", \"Documento\": \"{this.Documento}\", \"Id Articulo\": \"{this.IdArticulo}\", \"Fecha\": \"{this.Fecha}\", \"Cantidad\": \"{this.Cantidad}\",\"Valor Unidad\": \"{this.ValorUnidad}\", \"Id Cliente\": \"{this.IdCliente}\"}}";
        }

    }
}