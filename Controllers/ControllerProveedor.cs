using System;
using static System.Console;
using System.Collections.Generic;
using libPiky.Entities;
using libPiky.Interfaces;

namespace libPiky.Controllers
{
    public class ControllerProveedor : IMantenimiento
    {
        
        private List<Proveedor> listaProveedores = new List<Proveedor>();
        public void Ingresar(object elemento)
        {
            this.listaProveedores.Add((Proveedor)elemento);
        }
        public void Modificar()
        {

        }
        public void Eliminar(object elemento)
        {
            this.listaProveedores.Remove((Proveedor)elemento);
        }
        public object Consultar(int id)
        {
            object resultado = new object();
            foreach (var item in listaProveedores)
            {
                if (item.IdProveedor == id)
                {
                    resultado = item;
                    break;
                }
            }
            return resultado;
        }
        public void Listar()
        {
            foreach (var item in listaProveedores)
            {
                WriteLine(item.ToString());
            }
        }

    }
}