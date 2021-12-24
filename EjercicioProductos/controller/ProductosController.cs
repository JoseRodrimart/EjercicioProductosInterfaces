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
                ListaProductos[index].Imagen = editedProduct.Imagen;
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

        //Toma el stream de un fichero csv y le escribe todos los productos actuales
        internal void ExportToCsv(Stream stream)
        {
            FileStream fs = (FileStream)stream;
            StringBuilder csvContent = new(); //El csv resultante en un string en memoria
            csvContent.AppendLine("Código;Nombre;Cantidad;Precio;Descripción;Tipo;Imagen");
            ListaProductos.ToList().ForEach(producto => csvContent.AppendLine(producto.ToString()));

            byte[] csvBinary = new UTF8Encoding(true).GetBytes(csvContent.ToString());
            fs.Write(csvBinary, 0, csvBinary.Length);

            fs.Close();
            fs.Close();
        }

        //Toma el stream de un fichero csv y carga los productos
        internal List<Producto> ImportCsv(Stream stream)
        {

            List<Producto> productos = new(); 
            String stProducto, codigo, nombre, descripcion;
            int cantidad;
            decimal precio;
            ETipo tipo;
            Bitmap imagen;
            byte[] bytes;

            StreamReader reader = new StreamReader(stream);
            reader.ReadLine(); //Descartamos la linea del título
            while (reader.Peek() >= 0)
            {
                //Por cada vuelta, leemos una linea, le limpiamos los caracteres innecesarios y la dividimos sirviendonos de los ;
                stProducto = reader.ReadLine().Replace("\"",String.Empty);
                string[] partes = stProducto.Split(";");
                
                //Cada una de las partes se corresponde con uno de los argumentes de un producto
                codigo = partes[0];
                nombre = partes[1];
                cantidad = int.Parse(partes[2]);
                precio = decimal.Parse(partes[3]);
                descripcion = partes[4];
                tipo = (ETipo)Enum.Parse(typeof(ETipo), partes[5], true);
                imagen = 
                    (partes[6].Equals(String.Empty)) ?
                    new Bitmap(Properties.Resources.placeholderProduct) { Tag = "placeholder" } : //Si no hay imagen guardada, asignamos el placeholder
                    new Bitmap( new MemoryStream( Convert.FromBase64String(partes[6]))); //Si la hay, convertimos el base 64 a un bitmap

                //Agregamos a la lista el producto resultante
                productos.Add(new Producto(codigo, nombre, cantidad, precio, descripcion, tipo, imagen));
            }

            return productos;
        }
        internal int CuentaRepeticiones(List<Producto> productosImportados)
        {
            int repeticiones = 0;
            productosImportados.ForEach(producto => { if(this.CompruebaProducto(producto)) repeticiones++; });
            return repeticiones;
        }

        //Recibe una lista de productos, y los registra todos, si alguno de ellos ya existe, es sobreescrito
        internal void RegistraOSobreescribe(List<Producto> productosImportados)
        {
            productosImportados.ForEach((producto) =>
            {
                if (this.CompruebaProducto(producto)) editaProducto(producto);
                else RegistraProducto(producto);
            });
        }

    }
}
