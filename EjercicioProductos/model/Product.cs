using EjercicioProductos.exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductos.model
{
    //Modelo de producto, implementa una interfaz que permite al datagrid actualizarse automáticamente cuando alguna de las propiedades de un Product cambia.
    //Todos los campos están encapsulados por rendimientos, permite emitir notificación solo cuando la modificación de un atributo es con valor distinto al anterior, evitando actualizaciones de vista innecesarias. 
    public class Product : INotifyPropertyChanged
    {
        public String Id { get; private set; }

        private String _name;
        public string Name { 
            set 
            { 
                if(value != this._name)
                {
                    this._name = value;
                    NotifyPropertyChanged("Name");
                } 
            }
            get { return this._name; }
        }

        private int _quantity;
        public int Quantity
        {
            set
            {
                if (value != this._quantity)
                {
                    this._quantity = value;
                    NotifyPropertyChanged("Quantity");
                }
            }
            get { return this._quantity; }
        }

        private decimal _price;
        public decimal Price
        {
            set
            {
                if (value != this._price)
                {
                    this._price = value;
                    NotifyPropertyChanged("Price");
                }
            }
            get { return this._price; }
        }

        private string _description;
        public string Description
        {
            set
            {
                if (value != this._description)
                {
                    this._description = value;
                    NotifyPropertyChanged("Description");
                }
            }
            get { return this._description; }
        }

        private EComputerPartType _type;
        public EComputerPartType Type
        {
            set
            {
                if (value != this._type)
                {
                    this._type = value;
                    NotifyPropertyChanged("Type");
                }
            }
            get { return this._type; }
        }

        private Bitmap _image;
        public Bitmap Image
        {
            set
            {
                if (value != this._image)
                {
                    this._image = value;
                    NotifyPropertyChanged("Image");
                }
            }
            get { return this._image; }
        }

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

        //Evento que notifica un cambio en una de las propiedade.
        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged(String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }

    //Enumerador con los posibles tipos de producto
    public enum EComputerPartType { CPU, MotherBoard, RAM, GPU, PSU, HDD }

}
