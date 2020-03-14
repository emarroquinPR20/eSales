namespace libPiky.Entities
{
    public class Entrada
    {
        public int IdEntrada { get; set; }
        public double ValorUnidad { get; set; }
        public string Fecha { get; set; }
        public int Cantidad { get; set; }
        public int IdArticulo { get; set; }

        public Entrada()
        {

        }
        public Entrada(int idEntrada, double valorUnidad, string fecha, int cantidad, int idArticulo)
        {
            IdEntrada = idEntrada;
            ValorUnidad = valorUnidad;
            Fecha = fecha;
            Cantidad = cantidad;
            IdArticulo = idArticulo;
        }
        public override string ToString()
        {
            return $"{{\"Id\": \"{this.IdEntrada}\", \"Valor Unidad\": \"{this.ValorUnidad}\", \"Fecha\": \"{this.Fecha}\", \"Cantidad\": \"{this.Cantidad}\", \"ID Articulo\": \"{this.IdArticulo}\"}}";
        }

    }
}