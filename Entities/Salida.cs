namespace libPiky.Entities
{
    public class Salida
    {
        public int IdSalida { get; set; }
        public int Cantidad { get; set; }
        public double ValorUnidad { get; set; }
        public string Fecha { get; set; }
        public int IdArticulo { get; set; }

        public Salida()
        {
            
        }
        public Salida(int idSalida, int cantidad, double valorUnidad, string fecha, int idArticulo)
        {
            IdSalida = idSalida;
            Cantidad = cantidad;
            ValorUnidad = valorUnidad;
            Fecha = fecha;
            IdArticulo = idArticulo;
        }

    }
}