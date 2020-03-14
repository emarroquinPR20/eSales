namespace libPiky.Entities
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public string Documento { get; set; }
        public int IdArticulo { get; set; }
        public string Fecha { get; set; }
        public int Cantidad { get; set; }
        public double ValorUnidad { get; set; }
        public int IdCliente { get; set; }

        public Venta()
        {
            
        }
        public Venta(int idVenta, string documento, int idArticulo, string fecha, int cantidad, double valorUnidad, int idCliente)
        {
            IdVenta = idVenta;
            Documento = documento;
            IdArticulo = idArticulo;
            Fecha = fecha;
            Cantidad = cantidad;
            ValorUnidad = valorUnidad;
            IdCliente = idCliente;
        }
        public override string ToString()
        {
            return $"{{\"Id\": \"{this.IdVenta}\", \"Documento\": \"{this.Documento}\", \"Id Articulo\": \"{this.IdArticulo}\", \"Fecha\": \"{this.Fecha}\", \"Cantidad\": \"{this.Cantidad}\",\"Valor Unidad\": \"{this.ValorUnidad}\", \"Id Cliente\": \"{this.IdCliente}\"}}";
        }

    }
}