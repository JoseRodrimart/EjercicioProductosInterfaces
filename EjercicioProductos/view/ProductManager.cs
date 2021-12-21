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
        List<int> selectedRows = new List<int>();

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

        //Botón auxiliar para rellenar la lista rápidamente y debgear
        private void button1_Click(object sender, EventArgs e)
        {
            controller.ListaProductos.Add(new Producto("a","a",1,1,"a",ETipo.RAM));
        }

        //Apertura del formulario de registro
        private void OpenProductRegisterForm(object sender, EventArgs e)
        {
            ProductoRegister registerForm = new ProductoRegister();
            registerForm.ShowDialog();
        }

        //Cuando se pulsa el botón de eliminar, se borran las filas con el checkbox clicado
        private void DeleteSelectedItems(object sender, EventArgs e)
        {
            List<int> rowsToDelete = GetSelectedIndexes();
            if (rowsToDelete.Count > 0)
            {
                var decision = MessageBox.Show("Desea eliminar " + rowsToDelete.Count + " productos de la lista?", "Confirm Delete!!", MessageBoxButtons.YesNo);
                if (decision == DialogResult.Yes)
                    rowsToDelete.ForEach(x => dgProductos.Rows.RemoveAt(x));
            }
            else
                MessageBox.Show("No hay productos seleccionado, utilize la casilla de la derecha de los productos para seleccionarlos.",
                                "No hay productos seleccionados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }

        //Devuelve los índices de las filas seleccionadas
        private List<int> GetSelectedIndexes()
        {
            dgProductos.EndEdit(); //Es necesario actualizar los cambios antes de extraer los productos seleccionados, ya que si se consulta la lista sin salir del foco del último checkbox no se registra ese último
            List<int> selectedRowsIndexes = new List<int>();
            foreach (DataGridViewRow row in dgProductos.Rows)
            {
                if (Convert.ToBoolean(((DataGridViewCheckBoxCell)row.Cells["Seleccionado"]).Value))
                    selectedRowsIndexes.Add(row.Index);
            }
            selectedRowsIndexes.Sort();
            selectedRowsIndexes.Reverse();
            return selectedRowsIndexes;
        }
    }
}
