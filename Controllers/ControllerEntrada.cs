using System;
using static System.Console;
using System.Collections.Generic;
using libPiky.Entities;
using libPiky.Interfaces;

namespace libPiky.Controllers
{
    public class CobtrollerEntrada : IMantenimiento
    {
        
        private List<Entrada> listaEntradas = new List<Entrada>();
        public void Ingresar(object elemento)
        {
            this.listaEntradas.Add((Entrada)elemento);
        }
        public void Modificar()
        {

        }
        public void Eliminar(object elemento)
        {
            this.listaEntradas.Remove((Entrada)elemento);
        }
        public object Consultar(int id)
        {
            object resultado = new object();
            foreach (var item in listaEntradas)
            {
                if (item.IdEntrada == id)
                {
                    resultado = item;
                    break;
                }
            }
            return resultado;
        }
        public void Listar(object elemento)
        {
            foreach (var item in listaEntradas)
            {
                WriteLine(item.ToString());
            }
        }
        
    }
}