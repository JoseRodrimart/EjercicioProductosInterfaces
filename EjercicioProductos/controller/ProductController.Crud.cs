using EjercicioProductos.exceptions;
using EjercicioProductos.model;

namespace EjercicioProductos.controller
{
    public partial class ProductController
    {
        //CRUD de productos

        //CREATE
        //Cuando tratamos de registrar un producto, si el id ya existe, lanzamos una excepción
        public void RegisterNewProduct(Product product)
        {
            if (ProductList.Contains(product)) throw new IdRepetidoException();
            ProductList.Add(product);
            UpdateShowingProducts();
        }

        //Recibe una lista de productos, y los registra todos, si alguno de ellos ya existe y se indica en shoulOverride, es sobreescrito
        internal void InsertProducts(List<Product> importingProducts, bool shouldOverride = true)
        {
            importingProducts.ForEach((product) =>
            {
                if (!this.CheckProduct(product)) // Si no hay repeticion se inserta
                    RegisterNewProduct(product);
                else if (shouldOverride) //En caso de que la haya, si se indica shouldOverride, se cambia el ya existente
                    ModifyProduct(product);
                UpdateShowingProducts();
            });
        }

        //READ
        public Product SearchProduct(String productId)
        {
            Product product = new Product(productId);
            if (!CheckProduct(product)) throw new ProductoNoAlmacenadoException();
            return ProductList.FirstOrDefault(x => x.Equals(product));//(Producto)productos[id];
        }

        //UPDATE
        //Edita un producto, y permite cambiar la id si la nueva es diferente a la anterior, lanza una excepción si la id seleccionada no está disponible
        public void ModifyProduct(Product editedProduct)
        {
            //Primero comprobamos que si esté el producto que buscamos
            if (!CheckProduct(editedProduct))
                throw new ProductoNoAlmacenadoException();

            int index = ProductList.IndexOf(editedProduct);
            ProductList[index].Name = editedProduct.Name;
            ProductList[index].Price = editedProduct.Price;
            ProductList[index].Quantity = editedProduct.Quantity;
            ProductList[index].Description = editedProduct.Description;
            ProductList[index].Type = editedProduct.Type;
            ProductList[index].Image = editedProduct.Image;

            UpdateShowingProducts();
        }

        //DELETE
        public void EliminaProducto(String cod)
        {
            Product producto = new Product(cod);
            if (!CheckProduct(producto)) throw new ProductoNoAlmacenadoException();
            ProductList.Remove(producto);
            this.SelectedProducts.Remove(cod);
            UpdateShowingProducts();
        }

        internal void RemoveSelectedProducts()
        {
            String[] list = this.SelectedProducts.ToArray();
            foreach (string cod in list)
                this.EliminaProducto(cod);
        }

        //Helpers
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
    }
}