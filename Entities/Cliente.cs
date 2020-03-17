using System;
namespace libPiky.Entities
{
    public class Cliente
    {
        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Cliente()
        {
            IdCliente = GeneraId();
        }

        public Cliente(string nombre, string documento, string direccion, string correo, string telefono)
        {
            IdCliente = GeneraId();
            Nombre = nombre;
            Documento = documento;
            Direccion = direccion;
            Correo = correo;
            Telefono = telefono;
        }

        private string GeneraId()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }

        public override string ToString()
        {
            return $"{{\"Id\": \"{this.IdCliente}\", \"Nombre\": \"{this.Nombre}\", \"Documento\": \"{this.Documento}\", \"Dirección\": \"{this.Direccion}\", \"Correo\": \"{this.Correo}\", \"Telefóno\": \"{this.Telefono}\"}}";
        }

    }
}