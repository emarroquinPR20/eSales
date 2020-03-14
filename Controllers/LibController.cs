using System;
using static System.Console;
using System.Collections.Generic;
using libPiky.Entities;
using libPiky.Interfaces;


namespace libPiky.Controllers
{
    public class LibController : IMantenimiento
    {
        private List<Proveedor> listaProveedores = new List<Proveedor>();
        private List<Articulo> listaArticulos = new List<Articulo>();
        private List<Cliente> listaClientes = new List<Cliente>();
        private List<Entrada> listaEntradas = new List<Entrada>();
        private List<Salida> listaSalidas = new List<Salida>();
        private List<Venta> listaVentas = new List<Venta>();
        public void Ingresar(object elemento)
        {
            if (elemento.GetType() == typeof(Proveedor))
            {
                this.listaProveedores.Add((Proveedor)elemento);
            }
            else if (elemento.GetType() == typeof(Articulo))
            {
                this.listaArticulos.Add((Articulo)elemento);
            }
            else if (elemento.GetType() == typeof(Cliente))
            {
                this.listaClientes.Add((Cliente)elemento);
            }
            else if (elemento.GetType() == typeof(Entrada))
            {
                this.listaEntradas.Add((Entrada)elemento);
            }
            else if (elemento.GetType() == typeof(Salida))
            {
                this.listaSalidas.Add((Salida)elemento);
            }
            else if (elemento.GetType() == typeof(Venta))
            {
                this.listaVentas.Add((Venta)elemento);
            }
        }
        public void Modificar(object elemento)
        {

        }
        public void Eliminar(object elemento)
        {
            if (elemento.GetType() == typeof(Proveedor))
            {
                this.listaProveedores.Remove((Proveedor)elemento);
            }
            else if (elemento.GetType() == typeof(Articulo))
            {
                this.listaArticulos.Remove((Articulo)elemento);
            }
            else if (elemento.GetType() == typeof(Cliente))
            {
                this.listaClientes.Remove((Cliente)elemento);
            }
            else if (elemento.GetType() == typeof(Entrada))
            {
                this.listaEntradas.Remove((Entrada)elemento);
            }
            else if (elemento.GetType() == typeof(Salida))
            {
                this.listaSalidas.Remove((Salida)elemento);
            }
            else if (elemento.GetType() == typeof(Venta))
            {
                this.listaVentas.Remove((Venta)elemento);
            }
        }
        public object Consultar(object elemento, int id)
        {
            Object resultado = null;
            if (elemento.GetType() == typeof(Proveedor))
            {
                foreach (var item in listaProveedores)
                {
                    if (item.IdProveedor == id)
                    {
                        resultado = item;
                        break;
                    }
                }
            }
            else if (elemento.GetType() == typeof(Articulo))
            {
                foreach (var item in listaArticulos)
                {
                    if (item.IdArticulo == id)
                    {
                        resultado = item;
                        break;
                    }
                }
            }
            else if (elemento.GetType() == typeof(Cliente))
            {
                foreach (var item in listaClientes)
                {
                    if (item.IdCliente == id)
                    {
                        resultado = item;
                        break;
                    }
                }
            }
            else if (elemento.GetType() == typeof(Entrada))
            {
                foreach (var item in listaEntradas)
                {
                    if (item.IdEntrada == id)
                    {
                        resultado = item;
                        break;
                    }
                }
            }
            else if (elemento.GetType() == typeof(Salida))
            {
                foreach (var item in listaSalidas)
                {
                    if (item.IdSalida == id)
                    {
                        resultado = item;
                        break;
                    }
                }
            }
            else if (elemento.GetType() == typeof(Venta))
            {
                foreach (var item in listaVentas)
                {
                    if (item.IdVenta == id)
                    {
                        resultado = item;
                        break;
                    }
                }
            }
            return resultado;
        }
        public void Listar(object elemento)
        {
            if (elemento.GetType() == typeof(Proveedor))
            {
                foreach (var item in listaProveedores)
                {
                    WriteLine(item.ToString());
                }
            }
            else if (elemento.GetType() == typeof(Articulo))
            {
                foreach (var item in listaArticulos)
                {
                    WriteLine(item.ToString());
                }
            }
            else if (elemento.GetType() == typeof(Cliente))
            {
                foreach (var item in listaClientes)
                {
                    WriteLine(item.ToString());
                }
            }
            else if (elemento.GetType() == typeof(Entrada))
            {
                foreach (var item in listaEntradas)
                {
                    WriteLine(item.ToString());
                }
            }
            else if (elemento.GetType() == typeof(Salida))
            {
                foreach (var item in listaSalidas)
                {
                    WriteLine(item.ToString());
                }
            }
            else if (elemento.GetType() == typeof(Venta))
            {
                foreach (var item in listaVentas)
                {
                    WriteLine(item.ToString());
                }
            }

        }
    }
}