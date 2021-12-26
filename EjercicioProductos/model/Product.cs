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
    public class Product
    {
        public String Id { get; private set; }
        public string Name { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }
        public string Description { set; get; }
        public EComputerPartType Type { set; get; }
        public Bitmap Image { set; get; }

        //Siempre que se crea un Producto, debe contener todos los elementos
        public Product(String id, string name, int quantity, decimal price, string description, EComputerPartType type, Bitmap image)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Description = description;
            Price = price;
            Type = type;
            Image = image;
        }

        public Product(string id)
        {
            Id = id;
            Name = " ";
            Quantity = 0;
            Description = " ";
            Price = 0;
            Type = EComputerPartType.RAM;
            Image = null;
        }

        //Dos productos son iguales si su id coincide
        public override bool Equals(object? obj)
        {
            return obj is Product product && Id == product.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        //Reservamos el método ToString para registrarlo en csv
        public override string ToString()
        {
            string img;
            if (Image.Tag != null && Image.Tag == "placeholder") { //Si no hay imagen guardad, asignamos el placeholder
                img = "";
            }
            else //Si la hay, la convertimos a base64
            {
                byte[] bytes = new byte[1];
                MemoryStream ms = new MemoryStream();
                Image.Save(ms, ImageFormat.Jpeg);
                bytes = ms.ToArray();
                img = Convert.ToBase64String(bytes);
            }
            

            return "\"" + this.Id +"\";"
                + "\"" + this.Name + "\";"
                + "\"" + this.Quantity + "\";"
                + "\"" + this.Price + "\";"
                + "\"" + this.Description + "\";"
                + "\"" + this.Type + "\";"
                + "\"" + img + "\";"; //La imagen serializada en un array de bytes
        }
    }

    //Enumerador con los posibles tipos de producto
    public enum EComputerPartType { CPU, MotherBoard, RAM, GPU, PSU, HDD }

}
