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
    public class ProductController
    {
        //Esta clase sigue el patrón SINGLETON, accedemos desde todos los puntos de nuestro programa a la misma referencia.
        private static readonly ProductController controller = new ProductController();

        public static ProductController GetInstance()
        {
            return controller;
        }
        private ProductController() {
            ProductList = new BindingList<Product>();
            ProductList.AllowEdit = true;
            ProductList.AllowRemove = true;
        }
        //FIN SINGLETON

        //List que contiene los productos de nuestro programa
        public BindingList<Product> ProductList { get; set; }


        //List que contiene los códigos de los productos seleccionados actualmente
        public List<String> SelectedProducts { get; private set; } = new List<string>();
        private List<Product> excludedProducts = new List<Product>();
        public Dictionary<string, string> Filter { get; private set; } = new Dictionary<string, string>() { { "Id", "" },{ "Name", "" },{ "Price", "" },{ "Quantity", "" },{"Type", "" }};

        //CRUD de productos

        //CREATE
        //Cuando tratamos de registrar un producto, si el id ya existe, lanzamos una excepción
        public void RegisterNewProduct(Product product)
        {
            if (ProductList.Contains(product)) throw new IdRepetidoException();
            ProductList.Add(product);
            
        }

        //READ
        public Product SearchProduct(String productId)
        {
            Product product = new Product(productId);
            if (CheckProduct(product))
            {
                return ProductList.FirstOrDefault(x => x.Equals(product));//(Producto)productos[id];
            }
            else
                throw new ProductoNoAlmacenadoException();
        }

        //UPDATE
        //Edita un producto, y permite cambiar la id si la nueva es diferente a la anterior, lanza una excepción si la id seleccionada no está disponible
        public void ModifyProduct(Product editedProduct)
        {
            if (CheckProduct(editedProduct)) //Primero comprobamos que si esté el producto que buscamos
            {
                int index = ProductList.IndexOf(editedProduct);
                ProductList[index].Name = editedProduct.Name;
                ProductList[index].Price = editedProduct.Price;
                ProductList[index].Quantity = editedProduct.Quantity;
                ProductList[index].Description = editedProduct.Description;
                ProductList[index].Type = editedProduct.Type;
                ProductList[index].Image = editedProduct.Image;
                ProductList.ResetBindings(); //Notifica a la vista de los cambios realizados
            }
            else
                throw new ProductoNoAlmacenadoException();
        }

        //DELETE
        public void EliminaProducto(String cod)
        {
            Product producto = new Product(cod);
            if (CheckProduct(producto))
            {
                ProductList.Remove(producto);
                this.SelectedProducts.Remove(cod);
            }
            else throw new ProductoNoAlmacenadoException();
        }

        internal void RemoveSelectedProducts()
        {
            String[] list = this.SelectedProducts.ToArray();
            foreach(string cod in list)
                this.EliminaProducto(cod);
        }

        //Devuelve true si ya está presente un producto con esa id
        public bool CheckProduct(Product producto)
        {
            return ProductList.Contains(producto);
        }

        public bool CheckProductById(String id)
        {
            return ProductList.Contains(new Product(id));
        }

        //Obtiene los productos correspondientes a la lista de codigos de los productos seleccionados
        internal List<Product> GetSelectedProducts()
        {
            List<Product> products = new List<Product>();
            SelectedProducts.ForEach(cod => products.Add(this.SearchProduct(cod)));
            return products;
        }

        //Toma el stream de un fichero csv y le escribe todos los productos actuales
        internal void ExportToCsv(Stream stream)
        {
            FileStream fs = (FileStream)stream;
            StringBuilder csvContent = new(); //El csv resultante en un string en memoria
            csvContent.AppendLine("Código;Nombre;Cantidad;Precio;Descripción;Tipo;Imagen");
            ProductList.ToList().ForEach(producto => csvContent.AppendLine(producto.ToString()));

            byte[] csvBinary = new UTF8Encoding(true).GetBytes(csvContent.ToString());
            fs.Write(csvBinary, 0, csvBinary.Length);

            fs.Close();
            fs.Close();
        }

        //Toma el stream de un fichero csv y carga los productos
        internal List<Product> ImportCsv(Stream stream)
        {

            List<Product> productos = new(); 
            String stProducto, codigo, nombre, descripcion;
            int cantidad;
            decimal precio;
            EComputerPartType tipo;
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
                tipo = (EComputerPartType)Enum.Parse(typeof(EComputerPartType), partes[5], true);
                imagen = 
                    (partes[6].Equals(String.Empty)) ?
                    new Bitmap(Properties.Resources.placeholderProduct) { Tag = "placeholder" } : //Si no hay imagen guardada, asignamos el placeholder
                    new Bitmap( new MemoryStream( Convert.FromBase64String(partes[6]))); //Si la hay, convertimos el base 64 a un bitmap

                //Agregamos a la lista el producto resultante
                productos.Add(new Product(codigo, nombre, cantidad, precio, descripcion, tipo, imagen));
            }

            return productos;
        }

        //Usamos este método al importar, para saber si se van a sobreescribir productos ya existentes
        internal int CountAlreadyPresentProducts(List<Product> importingProducts)
        {
            int repetitions = 0;
            importingProducts.ForEach(producto => { if(this.CheckProduct(producto)) repetitions++; });
            return repetitions;
        }

        //Recibe una lista de productos, y los registra todos, si alguno de ellos ya existe y se indica en shoulOverride, es sobreescrito
        internal void InsertProducts(List<Product> importingProducts, bool shouldOverride = true)
        {
            importingProducts.ForEach((product) =>
            {
                if (!this.CheckProduct(product)) // Si no hay repeticion se inserta
                    RegisterNewProduct(product);
                else if(shouldOverride) //En caso de que la haya, si se indica shouldOverride, se cambia el ya existente
                    ModifyProduct(product);
            });
        }

        //Filtra la lista de productos en base a los 
        internal void ApplyFilters()
        {
            excludedProducts.ForEach(e => ProductList.Add(e)); //Antes de filtrar, devolvemos los excluidos a la lista
            excludedProducts.Clear();
            ProductList.OrderByDescending(e => e.Name);
            ProductList.ResetBindings();
            ProductList.ToList().ForEach( producto =>
            {
                if (!Filter["Id"].Equals(String.Empty) && !producto.Id.StartsWith(Filter["Id"]))
                    excludedProducts.Add(producto); //ListaProductos.IndexOf(producto); //Reservar el indice para reinsertar
                
                else if (!Filter["Name"].Equals(String.Empty) && !producto.Name.StartsWith(Filter["Name"]))
                    excludedProducts.Add(producto);
                
                else if (!Filter["Quantity"].Equals(String.Empty))
                {
                    int quantity;
                    int.TryParse(Filter["Quantity"], out quantity);
                    if(quantity != null && producto.Quantity != quantity)
                        excludedProducts.Add(producto);
                }
                
                else if (!Filter["Price"].Equals(String.Empty))
                {
                    decimal price;
                    decimal.TryParse(Filter["Price"], out price);
                    if (price != null && producto.Price != price)
                        excludedProducts.Add(producto);
                }
                else if(!Filter["Type"].Equals(String.Empty) && !producto.Type.ToString().Equals(Filter["Type"]))
                    excludedProducts.Add(producto);

            });
            excludedProducts.ForEach(producto => ProductList.Remove(producto));
            ProductList.ResetBindings();
        }
    }
}
