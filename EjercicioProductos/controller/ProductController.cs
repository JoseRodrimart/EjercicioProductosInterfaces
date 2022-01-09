using EjercicioProductos.exceptions;
using EjercicioProductos.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductos.controller
{
    public partial class ProductController
    {
        //Esta clase sigue el patrón SINGLETON, accedemos desde todos los puntos de nuestro programa a la misma referencia.
        private static readonly ProductController controller = new ProductController();

        public static ProductController GetInstance()
        {
            return controller;
        }
        private ProductController() {
            Source.DataSource = showingProducts; //El DataSource hace de Wrapper del ProductList
            ProductList.ListChanged += ProductList_ListChanged;
        }

        private void ProductList_ListChanged(object? sender, ListChangedEventArgs e)
        {
            Debug.WriteLine("asdf");
        }

        //FIN SINGLETON

        //BindingList que contiene todos los productos de nuestro programa
        public BindingList<Product> ProductList { get; set; } = new BindingList<Product>();
        
        //BindingList que contiene todos los productos a mostrar en cada momento
        private BindingList<Product> showingProducts = new BindingList<Product>();

        //BindingSource, hace de "Wrapper" de la lista de productos a mostrar
        public BindingSource Source { get; set; } = new BindingSource( );

        //List que contiene los códigos de los productos seleccionados actualmente
        public List<String> SelectedProducts { get; private set; } = new List<string>();
        
        //Propiedad Diccionario con los filtros establecidos para cada propiedad y atributos con los campos de ordenado y dirección
        public Dictionary<string, string> Filter { get; private set; } = new Dictionary<string, string>() { { "Id", "" },{ "Name", "" },{ "Price", "" },{ "Quantity", "" },{"Type", "" }};
        private String orderField = "Id";
        private bool orderDirection = true; //true ascendente, false descendente

        //Filtra la lista de productos en base a los 
        internal void UpdateShowingProducts()
        {
            SelectedProducts.Clear();
            showingProducts.Clear();

            //Filtramos la vista en función de los filtros seleccionados
            var x = ProductList.Where(p =>
            {
                bool ret = true;
                if (!Filter["Id"].Equals(String.Empty))
                    ret = (p.Id.Contains(Filter["Id"]));
                if (!Filter["Name"].Equals(String.Empty))
                    ret = (p.Name.Contains(Filter["Name"]));
                if (!Filter["Quantity"].Equals(String.Empty))
                {
                    int quantity;
                    int.TryParse(Filter["Quantity"], out quantity);
                    ret = (quantity != null && p.Quantity == quantity);
                }
                if (!Filter["Price"].Equals(String.Empty))
                {
                    decimal price;
                    decimal.TryParse(Filter["Price"], out price);
                    ret = (price != null && p.Price == price);
                }
                if (!Filter["Type"].Equals(String.Empty))
                    ret = (p.Type.ToString() == Filter["Type"]);
                return ret;
            }).ToList();

            //Los ordenamos según el criterio establecido
            if (orderDirection)
            {
                switch (orderField)
                {
                    case "Id": x=x.OrderBy(p =>p.Id).ToList(); break;
                    case "Name": x = x.OrderBy(p => p.Name).ToList(); break;
                    case "Quantity": x=x.OrderBy(p =>p.Quantity).ToList() ;break;
                    case "Price": x=x.OrderBy(p =>p.Price).ToList() ;break;
                    case "Description": x=x.OrderBy(p =>p.Description).ToList() ;break;
                    case "Type": x=x.OrderBy(p =>p.Type.ToString()).ToList() ;break;
                }
            }
            else
            {
                switch (orderField)
                {
                    case "Id": x = x.OrderByDescending(p => p.Id).ToList(); break;
                    case "Name": x = x.OrderByDescending(p => p.Name).ToList(); break;
                    case "Quantity": x = x.OrderByDescending(p => p.Quantity).ToList(); break;
                    case "Price": x = x.OrderByDescending(p => p.Price).ToList(); break;
                    case "Description": x = x.OrderByDescending(p => p.Description).ToList(); break;
                    case "Type": x = x.OrderByDescending(p => p.Type.ToString()).ToList(); break;
                }
            }
            x.ForEach(p=>showingProducts.Add(p));
        }

        internal void SetOrderingRules(string field, bool direction)
        {
            orderField = field;
            orderDirection = direction;
            UpdateShowingProducts();
        }
    }
}
