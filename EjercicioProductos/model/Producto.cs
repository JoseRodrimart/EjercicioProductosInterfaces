using EjercicioProductos.exceptions;
using System;
using System.Collections.Generic;
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

        //Siempre que se crea un Producto, debe contener todos los elementos
        public Producto(String id, string nombre, int cantidad, decimal precio, string descripcion, ETipo tipo)
        {
            Id = id;
            Nombre = nombre;
            Cantidad = cantidad;
            Descripcion = descripcion;
            Precio = precio;
            Tipo = tipo;
        }

        public Producto(string id)
        {
            Id = id;
            Nombre = " ";
            Cantidad = 0;
            Descripcion = " ";
            Precio = 0;
            Tipo = ETipo.RAM;
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

        //VER OVERRIDE HASHSET
    }

    //Enumerador con los posibles tipos de producto
    public enum ETipo { Procesador, PlacaBase, RAM, TarjetaGrafica, FuentaAlimentacion, DiscoDuro }

}
