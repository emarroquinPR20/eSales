using System;
using static System.Console;
using System.Collections.Generic;
using libPiky.Entities;
using libPiky.Interfaces;

namespace libPiky.Controllers
{
    public class ControllerSalida : IMantenimiento
    {

        private List<Salida> listaSalidas = new List<Salida>();
        public void Ingresar(object elemento)
        {
            this.listaSalidas.Add((Salida)elemento);
        }
        public void Modificar()
        {

        }
        public void Eliminar(object elemento)
        {
            this.listaSalidas.Remove((Salida)elemento);
        }
        public object Consultar(string id)
        {
            object resultado = new object();
            foreach (var item in listaSalidas)
            {
                if (item.IdSalida.Equals(id))
                {
                    resultado = item;
                    break;
                }
            }
            return resultado;
        }
        public void Listar()
        {
            foreach (var item in listaSalidas)
            {
                WriteLine(item.ToString());
            }
        }        
        
    }
}