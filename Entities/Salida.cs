namespace libPiky.Entities
{
    public class Salida
    {
        public int IdSalida { get; set; }
        public double ValorUnidad { get; set; }        
        public string Fecha { get; set; }        
        public int Cantidad { get; set; }
        public int IdArticulo { get; set; }

        public Salida()
        {
            
        }
        public Salida(int idSalida, double valorUnidad, string fecha, int cantidad, int idArticulo)
        {
            IdSalida = idSalida;
            ValorUnidad = valorUnidad;            
            Fecha = fecha;            
            Cantidad = cantidad;
            IdArticulo = idArticulo;
        }

    }
}