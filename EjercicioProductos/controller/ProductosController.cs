using EjercicioProductos.exceptions;
using EjercicioProductos.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductos.controller
{
    internal class ProductosController
    {
        //Esta clase sigue el patrón SINGLETON, accedemos desde todos los puntos de nuestro programa a la misma referencia.
        private static readonly ProductosController controller = new ProductosController();
        public static ProductosController GetInstance()
        {
            return controller;
        }
        private ProductosController() {
            ListaProductos = new BindingList<Producto>();
        }
        //FIN SINGLETON

        //HashSet que contiene los productos de nuestro programa. Este tipo de estructura no puede contener repeticiones
        public BindingList<Producto> ListaProductos { get; set; }
        public BindingSource Source { get; set; } //Enlace de datos

        //CRUD de productos

        //CREATE
        //Cuando tratamos de registrar un producto, si el id ya existe, lanzamos una excepción
        public void RegistraProducto(Producto producto)
        {
            if (ListaProductos.Contains(producto)) throw new IdRepetidoException();
            ListaProductos.Add(producto);
            
        }

        //READ
        public Producto BuscaProducto(Producto producto)
        {
            if (CompruebaProducto(producto))
            {
                return ListaProductos.FirstOrDefault(x => x.Equals(producto));//(Producto)productos[id];
            }
            else
                throw new ProductoNoAlmacenadoException();
        }

        //UPDATE
        //Edita un producto, y permite cambiar la id si la nueva es diferente a la anterior, lanza una excepción si la id seleccionada no está disponible
        public void editaProducto(Producto oldProducto, Producto newProducto)
        {
            if (CompruebaProducto(oldProducto)) //Primero comprobamos que si esté el producto que buscamos
            {
                if (CompruebaProducto(newProducto)) //Si la id se ha alterado, debemos comprobar 
                {
                    ListaProductos.Remove(oldProducto);
                    ListaProductos.Add(newProducto);
                }
            }
            else
                throw new ProductoNoAlmacenadoException();
        }

        //DELETE
        public void EliminaProducto(Producto producto)
        {
            if (CompruebaProducto(producto))
            {
                ListaProductos.Remove(producto);
            }
            else throw new ProductoNoAlmacenadoException();
        }

        //Devuelve true si ya está presente un producto con esa id
        public bool CompruebaProducto(Producto producto)
        {
            return ListaProductos.Contains(producto);
        }

        public bool CompruebaId(String id)
        {
            return ListaProductos.Contains(new Producto(id));
        }
    }
}
