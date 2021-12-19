using EjercicioProductos.controller;
using EjercicioProductos.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioProductos.view
{
    public partial class ProductManager : Form
    {
        private ProductosController controller = ProductosController.GetInstance();

        public ProductManager()
        {
            InitializeComponent();
        }

        //En la carga vamos a "bindear" o enlazar el origen de datos del DataGrid a una propiedad de tipo BindingList de nuestro controlador,
        //  donde almacenamos la lista actual de productos.
        private void ProductManager_Load(object sender, EventArgs e)
        {
            dgProductos.DataSource = null;
            dgProductos.DataSource = controller.ListaProductos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.ListaProductos.Add(new Producto("a","a",1,1,"a",ETipo.RAM));
        }

        private void OpenProductRegisterForm(object sender, EventArgs e)
        {
            ProductoRegister registerForm = new ProductoRegister();
            registerForm.ShowDialog();
        }
    }
}
