namespace libPiky.Entities
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Cliente()
        {
            
        }
        public Cliente(int idCliente, string nombre, string documento, string correo, string direccion, string telefono)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Documento = documento;
            Correo = correo;
            Direccion = direccion;
            Telefono = telefono;
        }

    }
}