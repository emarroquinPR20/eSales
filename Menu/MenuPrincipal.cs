using System;
using static System.Console;

using libPiky.Controllers;
using libPiky.Entities;
using static libPiky.Util.Printer;

namespace libPiky.Menu
{
    public class MenuPrincipal
    {
        private LibController controller =  new LibController();
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
                            MenuOpciones("Ingreso");
                            break;
                        case 5:
                            MenuOpciones("Egreso");
                            break;
                        case 6:
                            MenuOpciones("Venta");
                            break;
                    }
                }while (opcion != 0);
            }
            catch(Exception e)
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
                            AgregarObjeto();
                            break;
                        case 2:
                            ModificarObjeto();
                            break;
                        case 3:
                            ElimnarObjeto();
                            break;
                        case 4:
                            ConsultarObjeto();
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
        private void AgregarObjeto()
        {

        }
        private void ModificarObjeto()
        {

        }
        private void ElimnarObjeto()
        {

        }
        public void ConsultarObjeto()
        {

        }
    }
}