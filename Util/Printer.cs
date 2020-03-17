using System;
using static System.Console;
namespace libPiky.Util
{
    public class Printer
    {
        public static void DrawLine (int size = 0)
        {
            WriteLine("".PadLeft(size,'='));
        }
        public static void WriteTiTle(string titulo)
        {
            var longitud = titulo.Length*3;
            DrawLine(longitud);
            WriteLine($"|{titulo}|");
            DrawLine(longitud);
        }
        public static void PrecionarEnter()
        {
            WriteLine("Precione Enter Para Continuar...");
            ReadLine();
        }
    }
}