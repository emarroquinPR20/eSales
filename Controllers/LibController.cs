using System;
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
        private List<Entrada> listaEntrada = new List<Entrada>();
        private List<Salida> listaSalidas = new List<Salida>();
        private List<Venta> listaVentas = new List<Venta>();
        public void Ingresar(object Elemento)
        {

        }
        public void Modificar(object Elemento)
        {

        }
        public void Eliminar(object Elemento)
        {

        }
        public void Consultar(int id)
        {

        }
    }
}