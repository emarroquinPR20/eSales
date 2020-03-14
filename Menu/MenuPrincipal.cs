using System;
using static System.Console;

using libPiky.Controllers;
using libPiky.Entities;
using static libPiky.Util.Printer;

namespace libPiky.Menu
{
    public class MenuPrincipal
    {
        private LibController controller = new LibController();
        public void MostrarMenu()
        {
            try
            {
                int opcion = 0;
                do
                {
                    Clear();
                    WriteTiTle("Administración Libreria");
                    WriteLine("0. Salir");
                    WriteLine("1. Proveedores");
                    WriteLine("2. Articulos");
                    WriteLine("3. Clientes");
                    WriteLine("4. Ingresos");
                    WriteLine("5. Egresos");
                    WriteLine("6. Ventas");
                    WriteLine("Ingrese opción");
                    string opcionElegida = ReadLine();
                    opcion = Convert.ToByte(opcionElegida);
                    switch (opcion)
                    {
                        case 0:
                            break;
                        case 1:
                            MenuOpciones("Proveedor");
                            break;
                        case 2:
                            MenuOpciones("Articulo");
                            break;
                        case 3:
                            MenuOpciones("Cliente");
                            break;
                        case 4:
                            MenuOpciones("Entrada");
                            break;
                        case 5:
                            MenuOpciones("Salida");
                            break;
                        case 6:
                            MenuOpciones("Venta");
                            break;
                    }
                } while (opcion != 0);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                ReadLine();
            }
        }
        private void MenuOpciones(string tipoObjeto)
        {
            try
            {
                int opcion = 0;
                do
                {
                    Clear();
                    WriteTiTle("Administración Libreria");
                    WriteLine($"1. Agregar {tipoObjeto}");
                    WriteLine($"2. Modificar {tipoObjeto}");
                    WriteLine($"3. Eliminar {tipoObjeto}");
                    WriteLine($"4. Consultar {tipoObjeto}");
                    WriteLine("Ingrese opción");
                    string opcionElegida = ReadLine();
                    opcion = Convert.ToByte(opcionElegida);
                    switch (opcion)
                    {
                        case 0:
                            break;
                        case 1:
                            AgregarObjeto(tipoObjeto);
                            break;
                        case 2:
                            ModificarObjeto(tipoObjeto);
                            break;
                        case 3:
                            ElimnarObjeto(tipoObjeto);
                            break;
                        case 4:
                            ConsultarObjeto(tipoObjeto);
                            break;
                        default:
                            WriteLine("No existe la Opción");
                            break;
                    }

                } while (opcion != 0);

            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
        private void AgregarObjeto(string tipoObjeto)
        {
            Clear();
            WriteTiTle($"Ingrese Informacíon de {tipoObjeto}");
            if (tipoObjeto.Equals("Proveedor"))
            {
                WriteLine("ID :");
                int id = Convert.ToInt16(ReadLine());
                WriteLine("Nombre :");
                string nombre = ReadLine();
                WriteLine("Documento :");
                string documento = ReadLine();
                WriteLine("Direccion :");
                string direccion = ReadLine();
                WriteLine("Correo :");
                string correo = ReadLine();
                WriteLine("Telefóno :");
                string telefono = ReadLine();
                Proveedor nProveedor = new Proveedor(id, nombre, documento, direccion, correo, telefono);
                controller.Ingresar(nProveedor);
            }
            else if (tipoObjeto.Equals("Articulo"))
            {
                WriteLine("ID :");
                int id = Convert.ToInt16(ReadLine());
                WriteLine("Nombre :");
                string nombre = ReadLine();
                WriteLine("Marca :");
                string marca = ReadLine();
                WriteLine("Referencia :");
                string referencia = ReadLine();
                WriteLine("ID Proveedor :");
                int idproveedor = Convert.ToInt16(ReadLine());
                WriteLine("Stock :");
                int stock = Convert.ToInt16(ReadLine());
                Articulo nArticulo = new Articulo(id, nombre, marca, referencia, idproveedor, stock);
                controller.Ingresar(nArticulo);
            }
            else if (tipoObjeto.Equals("Cliente"))
            {
                WriteLine("ID :");
                int id = Convert.ToInt16(ReadLine());
                WriteLine("Nombre :");
                string nombre = ReadLine();
                WriteLine("Documento :");
                string documento = ReadLine();
                WriteLine("Direccion :");
                string direccion = ReadLine();
                WriteLine("Correo :");
                string correo = ReadLine();
                WriteLine("Telefóno :");
                string telefono = ReadLine();
                Cliente nCliente = new Cliente(id, nombre, documento, direccion, correo, telefono);
                controller.Ingresar(nCliente);
            }
            else if (tipoObjeto.Equals("Entrada"))
            {
                WriteLine("ID :");
                int id = Convert.ToInt16(ReadLine());
                WriteLine("Valor de Unidad :");
                double valorunidad = Convert.ToDouble(ReadLine());
                WriteLine("Fecha");
                string fecha = ReadLine();
                WriteLine("Cantidad");
                int cantidad = Convert.ToInt16(ReadLine());
                WriteLine("ID Articulo");
                int idarticulo = Convert.ToInt16(ReadLine());
                Entrada nEntrada = new Entrada(id, valorunidad, fecha, cantidad, idarticulo);
                controller.Ingresar(nEntrada);
            }
            else if (tipoObjeto.Equals("Salida"))
            {
                WriteLine("ID :");
                int id = Convert.ToInt16(ReadLine());
                WriteLine("Valor de Unidad :");
                double valorunidad = Convert.ToDouble(ReadLine());
                WriteLine("Fecha");
                string fecha = ReadLine();
                WriteLine("Cantidad");
                int cantidad = Convert.ToInt16(ReadLine());
                WriteLine("ID Articulo");
                int idarticulo = Convert.ToInt16(ReadLine());
                Salida nSalida = new Salida(id, valorunidad, fecha, cantidad, idarticulo);
                controller.Ingresar(nSalida);
            }
            else if (tipoObjeto.Equals("Venta"))
            {
                WriteLine("ID :");
                int id = Convert.ToInt16(ReadLine());
                WriteLine("ID Documento");
                string documento = ReadLine();
                WriteLine("ID Articulo");
                int idarticulo = Convert.ToInt16(ReadLine());
                WriteLine("Fecha");
                string fecha = ReadLine();
                WriteLine("Cantidad");
                int cantidad = Convert.ToInt16(ReadLine());
                WriteLine("Valor de Unidad :");
                double valorunidad = Convert.ToDouble(ReadLine());
                WriteLine("ID Cliente");
                int idcliente = Convert.ToInt16(ReadLine());
                Venta nVenta = new Venta(id, documento, idarticulo, fecha, cantidad, valorunidad, idcliente);
                controller.Ingresar(nVenta);
            }
        }
        private void ModificarObjeto(string tipoObjeto)
        {

        }
        private void ElimnarObjeto(string tipoObjeto)
        {
            WriteLine($"Ingrese el ID de {tipoObjeto} a Eliminar :");
            int ideliminar = Convert.ToInt16(ReadLine());
            if (tipoObjeto.Equals("Proveedor"))
            {
                object objeto = new Proveedor();
                Proveedor eProveedor = (Proveedor)controller.Consultar(objeto,ideliminar);
                controller.Eliminar(eProveedor);
            }
            else if (tipoObjeto.Equals("Articulo"))
            {
                object objeto = new Articulo();
                Articulo eArticulo = (Articulo)controller.Consultar(objeto,ideliminar);
                controller.Eliminar(eArticulo);
            }
            else if (tipoObjeto.Equals("Cliente"))
            {
                object objeto = new Cliente();
                Cliente eCliente = (Cliente)controller.Consultar(objeto,ideliminar);
                controller.Eliminar(eCliente);
            }
            else if (tipoObjeto.Equals("Entrada"))
            {
                object objeto = new Entrada();
                Entrada eEntrada = (Entrada)controller.Consultar(objeto,ideliminar);
                controller.Eliminar(eEntrada);
            }
            else if (tipoObjeto.Equals("Salida"))
            {
                object objeto = new Salida();
                Salida eSalida = (Salida)controller.Consultar(objeto,ideliminar);
                controller.Eliminar(eSalida);
            }
            else if (tipoObjeto.Equals("Venta"))
            {
                object objeto = new Venta();
                Venta eVenta = (Venta)controller.Consultar(objeto,ideliminar);
                controller.Eliminar(eVenta);
            }
        }
        public void ConsultarObjeto(string tipoObjeto)
        {
            WriteLine($"Ingrese el ID de {tipoObjeto} a Consultar :");
            int ideliminar = Convert.ToInt16(ReadLine());
            if (tipoObjeto.Equals("Proveedor"))
            {
                object objeto = new Proveedor();
                Proveedor cProveedor = (Proveedor)controller.Consultar(objeto,ideliminar);
                WriteLine($"{tipoObjeto} : {cProveedor.IdProveedor} {cProveedor.Nombre}");
            }
            else if (tipoObjeto.Equals("Articulo"))
            {
                object objeto = new Articulo();
                Articulo cArticulo = (Articulo)controller.Consultar(objeto,ideliminar);
                WriteLine($"{tipoObjeto} : {cArticulo.IdArticulo} {cArticulo.Nombre}");
            }
            else if (tipoObjeto.Equals("Cliente"))
            {
                object objeto = new Cliente();
                Cliente cCliente = (Cliente)controller.Consultar(objeto,ideliminar);
                WriteLine($"{tipoObjeto} : {cCliente.IdCliente} {cCliente.Nombre}");
            }
            else if (tipoObjeto.Equals("Entrada"))
            {
                object objeto = new Entrada();
                Entrada cEntrada = (Entrada)controller.Consultar(objeto,ideliminar);
                WriteLine($"{tipoObjeto} : {cEntrada.IdEntrada} {cEntrada.Fecha}");
            }
            else if (tipoObjeto.Equals("Salida"))
            {
                object objeto = new Salida();
                Salida cSalida = (Salida)controller.Consultar(objeto,ideliminar);
                WriteLine($"{tipoObjeto} : {cSalida.IdSalida} {cSalida.Fecha}");
            }
            else if (tipoObjeto.Equals("Venta"))
            {
                object objeto = new Venta();
                Venta cVenta = (Venta)controller.Consultar(objeto,ideliminar);
                WriteLine($"{tipoObjeto} : {cVenta.IdVenta} {cVenta.Fecha}");
            }
        }
    }
}