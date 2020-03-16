using System;
using static System.Console;
using System.Collections.Generic;
using libPiky.Entities;
using libPiky.Interfaces;

namespace libPiky.Controllers
{
    public class ControllerArticulo : IMantenimiento
    {

        private List<Articulo> listaArticulos = new List<Articulo>();
        public void Ingresar(object elemento)
        {
            this.listaArticulos.Add((Articulo)elemento);
        }
        public void Modificar()
        {

        }
        public void Eliminar(object elemento)
        {
            this.listaArticulos.Remove((Articulo)elemento);
        }
        public object Consultar(int id)
        {
            object resultado = new object();
            foreach (var item in listaArticulos)
            {
                if (item.IdArticulo == id)
                {
                    resultado = item;
                    break;
                }
            }
            return resultado;
        }
        public void Listar(object elemento)
        {
            foreach (var item in listaArticulos)
            {
                WriteLine(item.ToString());
            }
        }
        
    }
    
}