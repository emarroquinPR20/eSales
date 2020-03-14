namespace libPiky.Entities
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Proveedor()
        {
            
        }
        public Proveedor(int idProveedor, string nombre, string documento, string direccion, string correo, string telefono)
        {
            IdProveedor = idProveedor;
            Nombre = nombre;
            Documento = documento;
            Direccion = direccion;
            Correo = correo;
            Telefono = telefono;
        }
        public override string ToString()
        {
            return $"{{\"Id\": \"{this.IdProveedor}\", \"Nombre\": \"{this.Nombre}\", \"Documento\": \"{this.Documento}\", \"Dirección\": \"{this.Direccion}\", \"Correo\": \"{this.Correo}\", \"Telefóno\": \"{this.Telefono}\"}}";
        }

    }
}