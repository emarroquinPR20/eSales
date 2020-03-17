using System;
namespace com.Libreria.coreV1.Entities
{
    public class Entrada
    {
        public string IdEntrada { get; set; }
        public double ValorUnidad { get; set; }
        public string Fecha { get; set; }
        public int Cantidad { get; set; }
        public int IdArticulo { get; set; }

        public Entrada()
        {
            IdEntrada =GeneraId();
        }
        public Entrada(double valorUnidad, string fecha, int cantidad, int idArticulo)
        {
            IdEntrada = GeneraId();
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
            return $"{{\"Id\": \"{this.IdEntrada}\", \"Valor Unidad\": \"{this.ValorUnidad}\", \"Fecha\": \"{this.Fecha}\", \"Cantidad\": \"{this.Cantidad}\", \"ID Articulo\": \"{this.IdArticulo}\"}}";
        }

    }
}