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
    public class ProductosController
    {
        //Esta clase sigue el patrón SINGLETON, accedemos desde todos los puntos de nuestro programa a la misma referencia.
        private static readonly ProductosController controller = new ProductosController();

        public static ProductosController GetInstance()
        {
            return controller;
        }
        private ProductosController() {
            ListaProductos = new BindingList<Producto>();
            ListaProductos.AllowEdit = true;
            ListaProductos.AllowRemove = true;
        }
        //FIN SINGLETON

        //List que contiene los productos de nuestro programa
        public BindingList<Producto> ListaProductos { get; set; }

        //List que contiene los códigos de los productos seleccionados actualmente
        public List<String> ProductosSeleccionados { get; private set; } = new List<string>();

        //CRUD de productos

        //CREATE
        //Cuando tratamos de registrar un producto, si el id ya existe, lanzamos una excepción
        public void RegistraProducto(Producto producto)
        {
            if (ListaProductos.Contains(producto)) throw new IdRepetidoException();
            ListaProductos.Add(producto);
            
        }

        //READ
        public Producto BuscaProducto(String codProducto)
        {
            Producto producto = new Producto(codProducto);
            if (CompruebaProducto(producto))
            {
                return ListaProductos.FirstOrDefault(x => x.Equals(producto));//(Producto)productos[id];
            }
            else
                throw new ProductoNoAlmacenadoException();
        }

        //UPDATE
        //Edita un producto, y permite cambiar la id si la nueva es diferente a la anterior, lanza una excepción si la id seleccionada no está disponible
        public void editaProducto(Producto editedProduct)
        {
            if (CompruebaProducto(editedProduct)) //Primero comprobamos que si esté el producto que buscamos
            {
                int index = ListaProductos.IndexOf(editedProduct);
                ListaProductos[index].Nombre = editedProduct.Nombre;
                ListaProductos[index].Precio = editedProduct.Precio;
                ListaProductos[index].Cantidad = editedProduct.Cantidad;
                ListaProductos[index].Descripcion = editedProduct.Descripcion;
                ListaProductos[index].Tipo = editedProduct.Tipo;
                ListaProductos.ResetBindings(); //Notifica a la vista de los cambios realizados
            }
            else
                throw new ProductoNoAlmacenadoException();
        }

        //DELETE
        public void EliminaProducto(String cod)
        {
            Producto producto = new Producto(cod);
            if (CompruebaProducto(producto))
            {
                ListaProductos.Remove(producto);
                this.ProductosSeleccionados.Remove(cod);
            }
            else throw new ProductoNoAlmacenadoException();
        }

        internal void RemoveSelectedProducts()
        {
            String[] list = this.ProductosSeleccionados.ToArray();
            foreach(string cod in list)
                this.EliminaProducto(cod);
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

        //Obtiene los productos correspondientes a la lista de codigos de los productos seleccionados
        internal List<Producto> GetSelectedProducts()
        {
            List<Producto> products = new List<Producto> ();
            ProductosSeleccionados.ForEach(cod => products.Add(this.BuscaProducto(cod)));
            return products;
        }
    }
}
