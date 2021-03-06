using System;
using static System.Console;

using com.Libreria.coreV1.Controllers;
using com.Libreria.coreV1.Entities;
using static libPiky.Util.Printer;

namespace libPiky.Menu
{
    public class MenuPrincipal
    {        
        public string NombreEmpresa { get; set; }
        private ControllerProveedor cProveedor = new ControllerProveedor();
        private ControllerArticulo cArticulo = new ControllerArticulo();
        private ControllerCliente cCliente = new ControllerCliente();
        private ControllerEntrada cEntrada = new ControllerEntrada();
        private ControllerSalida cSalida = new ControllerSalida();
        private ControllerVenta cVenta = new ControllerVenta();
        public void MostrarMenu()
        {
            try
            {
                int opcion = 0;
                do
                {
                    Clear();
                    WriteTiTle(NombreEmpresa);
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
                        default:
                            WriteLine("No existe la Opción");
                            PrecionarEnter();
                            break;
                    }
                } while (opcion != 0);
            }
            catch (Exception e)
            {
                Clear();
                WriteTiTle(NombreEmpresa);
                WriteLine(e.Message);
                PrecionarEnter();
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
                    WriteTiTle($"{NombreEmpresa} - {tipoObjeto}");
                    WriteLine("0. Salir");
                    WriteLine("1. Agregar ");
                    WriteLine("2. Modificar ");
                    WriteLine("3. Eliminar ");
                    WriteLine("4. Consultar ");
                    WriteLine("5. Listar ");
                    WriteLine("Ingrese opción");
                    string opcionElegida = ReadLine();
                    opcion = Convert.ToByte(opcionElegida);
                    switch (opcion)
                    {
                        case 0:
                            break;
                        case 1:
                            AgregarObjeto(tipoObjeto);
                            PrecionarEnter();
                            break;
                        case 2:
                            ModificarObjeto(tipoObjeto);
                            PrecionarEnter();
                            break;
                        case 3:
                            ElimnarObjeto(tipoObjeto);
                            PrecionarEnter();
                            break;
                        case 4:
                            ConsultarObjeto(tipoObjeto);
                            PrecionarEnter();
                            break;
                        case 5:
                            ListarObjeto(tipoObjeto);
                            PrecionarEnter();
                            break;
                        default:
                            WriteLine("No existe la Opción");
                            PrecionarEnter();
                            break;
                    }

                } while (opcion != 0);

            }
            catch (Exception e)
            {
                Clear();
                WriteTiTle($"{NombreEmpresa} - {tipoObjeto}");
                WriteLine(e.Message);
                PrecionarEnter();
            }
        }
        private void AgregarObjeto(string tipoObjeto)
        {
            Clear();
            WriteTiTle($"{NombreEmpresa} - Información de: {tipoObjeto}");
            if (tipoObjeto.Equals("Proveedor"))
            {
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
                Proveedor nProveedor = new Proveedor(nombre, documento, direccion, correo, telefono);
                cProveedor.Ingresar(nProveedor);
            }
            else if (tipoObjeto.Equals("Articulo"))
            {
                WriteLine("Nombre :");
                string nombre = ReadLine();
                WriteLine("Marca :");
                string marca = ReadLine();
                WriteLine("Referencia :");
                string referencia = ReadLine();
                WriteLine("ID Proveedor :");
                string idproveedor = ReadLine();
                WriteLine("Stock :");
                int stock = Convert.ToInt16(ReadLine());
                Articulo nArticulo = new Articulo(nombre, marca, referencia, idproveedor, stock);
                cArticulo.Ingresar(nArticulo);
            }
            else if (tipoObjeto.Equals("Cliente"))
            {
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
                Cliente nCliente = new Cliente(nombre, documento, direccion, correo, telefono);
                cCliente.Ingresar(nCliente);
            }
            else if (tipoObjeto.Equals("Entrada"))
            {
                WriteLine("Valor de Unidad :");
                double valorunidad = Convert.ToDouble(ReadLine());
                WriteLine("Fecha");
                string fecha = ReadLine();
                WriteLine("Cantidad");
                int cantidad = Convert.ToInt16(ReadLine());
                WriteLine("ID Articulo");
                int idarticulo = Convert.ToInt16(ReadLine());
                Entrada nEntrada = new Entrada(valorunidad, fecha, cantidad, idarticulo);
                cEntrada.Ingresar(nEntrada);
            }
            else if (tipoObjeto.Equals("Salida"))
            {
                WriteLine("Valor de Unidad :");
                double valorunidad = Convert.ToDouble(ReadLine());
                WriteLine("Fecha");
                string fecha = ReadLine();
                WriteLine("Cantidad");
                int cantidad = Convert.ToInt16(ReadLine());
                WriteLine("ID Articulo");
                int idarticulo = Convert.ToInt16(ReadLine());
                Salida nSalida = new Salida(valorunidad, fecha, cantidad, idarticulo);
                cSalida.Ingresar(nSalida);
            }
            else if (tipoObjeto.Equals("Venta"))
            {
                WriteLine("ID Documento");
                string documento = ReadLine();
                WriteLine("ID Articulo");
                string idarticulo = ReadLine();
                WriteLine("Fecha");
                string fecha = ReadLine();
                WriteLine("Cantidad");
                int cantidad = Convert.ToInt16(ReadLine());
                WriteLine("Valor de Unidad :");
                double valorunidad = Convert.ToDouble(ReadLine());
                WriteLine("ID Cliente");
                string idcliente = ReadLine();
                Venta nVenta = new Venta(documento, idarticulo, fecha, cantidad, valorunidad, idcliente);
                cVenta.Ingresar(nVenta);
            }
        }
        private void ModificarObjeto(string tipoObjeto)
        {

        }
        private void ElimnarObjeto(string tipoObjeto)
        {
            Clear();
            WriteTiTle(NombreEmpresa);
            WriteLine($"Ingrese el ID de {tipoObjeto} a Eliminar :");
            string ideliminar = ReadLine();
            if (tipoObjeto.Equals("Proveedor"))
            {
                Proveedor eProveedor = (Proveedor)cProveedor.Consultar(ideliminar);
                cProveedor.Eliminar(eProveedor);
            }
            else if (tipoObjeto.Equals("Articulo"))
            {
                Articulo eArticulo = (Articulo)cArticulo.Consultar(ideliminar);
                cArticulo.Eliminar(eArticulo);
            }
            else if (tipoObjeto.Equals("Cliente"))
            {
                Cliente eCliente = (Cliente)cCliente.Consultar(ideliminar);
                cCliente.Eliminar(eCliente);
            }
            else if (tipoObjeto.Equals("Entrada"))
            {
                Entrada eEntrada = (Entrada)cEntrada.Consultar(ideliminar);
                cEntrada.Eliminar(eEntrada);
            }
            else if (tipoObjeto.Equals("Salida"))
            {
                Salida eSalida = (Salida)cSalida.Consultar(ideliminar);
                cSalida.Eliminar(eSalida);
            }
            else if (tipoObjeto.Equals("Venta"))
            {
                Venta eVenta = (Venta)cVenta.Consultar(ideliminar);
                cVenta.Eliminar(eVenta);
            }
        }
        public void ConsultarObjeto(string tipoObjeto)
        {
            Clear();
            WriteTiTle(NombreEmpresa);
            WriteLine($"Ingrese el ID de {tipoObjeto} a Consultar :");
            string idconsultar = ReadLine();
            if (tipoObjeto.Equals("Proveedor"))
            {
                Proveedor elemento = (Proveedor)cProveedor.Consultar(idconsultar);
                if (elemento != null)
                {
                    WriteLine(elemento.ToString());
                }
                else
                {
                    WriteLine("No se encontro información");
                }
            }
            else if (tipoObjeto.Equals("Articulo"))
            {
                Articulo elemento = (Articulo)cArticulo.Consultar(idconsultar);
                if (elemento != null)
                {
                    WriteLine(elemento.ToString());
                }
                else
                {
                    WriteLine("No se encontro información");
                }
            }
            else if (tipoObjeto.Equals("Cliente"))
            {
                Cliente elemento = (Cliente)cCliente.Consultar(idconsultar);
                if (elemento != null)
                {
                    WriteLine(elemento.ToString());
                }
                else
                {
                    WriteLine("No se encontro información");
                }
            }
            else if (tipoObjeto.Equals("Entrada"))
            {
                Entrada elemento = (Entrada)cEntrada.Consultar(idconsultar);
                if (elemento != null)
                {
                    WriteLine(elemento.ToString());
                }
                else
                {
                    WriteLine("No se encontro información");
                }
            }
            else if (tipoObjeto.Equals("Salida"))
            {
                Salida elemento = (Salida)cSalida.Consultar(idconsultar);
                if (elemento != null)
                {
                    WriteLine(elemento.ToString());
                }
                else
                {
                    WriteLine("No se encontro información");
                }
            }
            else if (tipoObjeto.Equals("Venta"))
            {
                Venta elemento = (Venta)cVenta.Consultar(idconsultar);
                if (elemento != null)
                {
                    WriteLine(elemento.ToString());
                }
                else
                {
                    WriteLine("No se encontro información");
                }

            }
        }
        public void ListarObjeto(string tipoObjeto)
        {
            Clear();
            WriteTiTle("Administración Libreria ");
            WriteLine($"Listado de {tipoObjeto} :");
            if (tipoObjeto.Equals("Proveedor"))
            {
                cProveedor.Listar();
            }
            else if (tipoObjeto.Equals("Articulo"))
            {
                cArticulo.Listar();
            }
            else if (tipoObjeto.Equals("Cliente"))
            {
                cCliente.Listar();
            }
            else if (tipoObjeto.Equals("Entrada"))
            {
                cEntrada.Listar();
            }
            else if (tipoObjeto.Equals("Salida"))
            {
                cSalida.Listar();
            }
            else if (tipoObjeto.Equals("Venta"))
            {
                cVenta.Listar();
            }
        }
    }
}