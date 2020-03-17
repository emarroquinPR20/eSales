using System;
namespace libPiky.Entities
{
    public class Salida
    {
        public string IdSalida { get; set; }
        public double ValorUnidad { get; set; }        
        public string Fecha { get; set; }        
        public int Cantidad { get; set; }
        public int IdArticulo { get; set; }

        public Salida()
        {
            IdSalida = GeneraId();
        }
        public Salida(double valorUnidad, string fecha, int cantidad, int idArticulo)
        {
            IdSalida = GeneraId();
            ValorUnidad = valorUnidad;            
            Fecha = fecha;            
            Cantidad = cantidad;
            IdArticulo = idArticulo;
        }

        private string GeneraId()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }

        public override string ToString()
        {
            return $"{{\"Id\": \"{this.IdSalida}\", \"Valor Unidad\": \"{this.ValorUnidad}\", \"Fecha\": \"{this.Fecha}\", \"Cantidad\": \"{this.Cantidad}\", \"ID Articulo\": \"{this.IdArticulo}\"}}";
        }

    }
}