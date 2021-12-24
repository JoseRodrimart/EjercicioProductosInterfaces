using EjercicioProductos.exceptions;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductos.model
{
    //Modelo de producto
    public class Producto
    {
        public string Nombre { set; get; }
        public String Id { get; private set; }
        public int Cantidad { set; get; }
        public decimal Precio { set; get; }
        public string Descripcion { set; get; }
        public ETipo Tipo { set; get; }
        public Bitmap Imagen { set; get; }

        //Siempre que se crea un Producto, debe contener todos los elementos
        public Producto(String id, string nombre, int cantidad, decimal precio, string descripcion, ETipo tipo, Bitmap imagen)
        {
            Id = id;
            Nombre = nombre;
            Cantidad = cantidad;
            Descripcion = descripcion;
            Precio = precio;
            Tipo = tipo;
            Imagen = imagen;
        }

        public Producto(string id)
        {
            Id = id;
            Nombre = " ";
            Cantidad = 0;
            Descripcion = " ";
            Precio = 0;
            Tipo = ETipo.RAM;
            Imagen = null;
        }

        //Dos productos son iguales si su id coincide
        public override bool Equals(object? obj)
        {
            return obj is Producto producto && Id == producto.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        //Reservamos el método ToString para registrarlo en csv
        public override string ToString()
        {
            string img;
            if (Imagen.Tag != null && Imagen.Tag == "placeholder") {
                img = "";
            }
            else
            {
                byte[] bytes = new byte[1];
                MemoryStream ms = new MemoryStream();
                Imagen.Save(ms, ImageFormat.Jpeg);
                bytes = ms.ToArray();
                img = Convert.ToBase64String(bytes);
            }
            

            return "\"" + this.Id +"\";"
                + "\"" + this.Nombre + "\";"
                + "\"" + this.Cantidad + "\";"
                + "\"" + this.Precio + "\";"
                + "\"" + this.Descripcion + "\";"
                + "\"" + this.Tipo + "\";"
                + "\"" + img + "\";"; //La imagen serializada en un array de bytes
        }
    }

    //Enumerador con los posibles tipos de producto
    public enum ETipo { Procesador, PlacaBase, RAM, TarjetaGrafica, FuentaAlimentacion, DiscoDuro }

}
