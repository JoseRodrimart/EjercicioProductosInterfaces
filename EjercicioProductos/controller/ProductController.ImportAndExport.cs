using EjercicioProductos.model;
using System.Text;

namespace EjercicioProductos.controller
{
    public partial class ProductController
    {
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
            stream.Close();
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
                stProducto = reader.ReadLine().Replace("\"", String.Empty);
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
                    new Bitmap(new MemoryStream(Convert.FromBase64String(partes[6]))); //Si la hay, convertimos el base 64 a un bitmap

                //Agregamos a la lista el producto resultante
                productos.Add(new Product(codigo, nombre, cantidad, precio, descripcion, tipo, imagen));
            }
            reader.Close();
            stream.Close();
            return productos;
        }

        //Usamos este método al importar, para saber si se van a sobreescribir productos ya existentes
        internal int CountAlreadyPresentProducts(List<Product> importingProducts)
        {
            int repetitions = 0;
            importingProducts.ForEach(producto => { if (this.CheckProduct(producto)) repetitions++; });
            return repetitions;
        }

    }
}