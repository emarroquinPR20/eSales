using System;
using static System.Console;
using System.Collections.Generic;
using libPiky.Entities;
using libPiky.Interfaces;

namespace libPiky.Controllers
{
    public class ControllerCliente : IMantenimiento
    {
        
        private List<Cliente> listaClientes = new List<Cliente>();
        public void Ingresar(object elemento)
        {
            this.listaClientes.Add((Cliente)elemento);
        }
        public void Modificar()
        {

        }
        public void Eliminar(object elemento)
        {
            this.listaClientes.Remove((Cliente)elemento);
        }
        public object Consultar(string id)
        {
            object resultado = new object();
            foreach (var item in listaClientes)
            {
                if (item.IdCliente.Equals(id))
                {
                    resultado = item;
                    break;
                }
            }
            return resultado;
        }
        public void Listar()
        {
            foreach (var item in listaClientes)
            {
                WriteLine(item.ToString());
            }
        }
        
    }
}