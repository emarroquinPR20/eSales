using System;
using libPiky.Menu;

namespace libPiky
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            MenuPrincipal mp = new MenuPrincipal();
            mp.NombreEmpresa = "Libreria Piky";
            mp.MostrarMenu();
        }
    }
}
