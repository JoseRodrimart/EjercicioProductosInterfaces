using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductos.exceptions
{
    public class IdRepetidoException : Exception
    {
        public IdRepetidoException()
        {
        }

        public IdRepetidoException(string? message) : base(message)
        {
        }

        public IdRepetidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }


    internal class ProductoNoAlmacenadoException : Exception
    {
        public ProductoNoAlmacenadoException()
        {
        }

        public ProductoNoAlmacenadoException(string? message) : base(message)
        {
        }

        public ProductoNoAlmacenadoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
