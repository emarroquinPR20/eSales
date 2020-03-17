using System;
namespace com.Libreria.coreV1.Entities
{
    public class Venta
    {
        public string IdVenta { get; set; }
        public string Documento { get; set; }
        public string IdArticulo { get; set; }
        public string Fecha { get; set; }
        public int Cantidad { get; set; }
        public double ValorUnidad { get; set; }
        public string IdCliente { get; set; }

        public Venta()
        {
            IdVenta = GeneraId();
        }
        public Venta(string documento, string idArticulo, string fecha, int cantidad, double valorUnidad, string idCliente)
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