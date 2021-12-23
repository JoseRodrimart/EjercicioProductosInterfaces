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
            dgProductos.DataSource = null;
            dgProductos.DataSource = controller.ListaProductos;
        }

        //En la carga vamos a "bindear" o enlazar el origen de datos del DataGrid a una propiedad de tipo BindingList de nuestro controlador,
        //  donde almacenamos la lista actual de productos.
        private void ProductManager_Load(object sender, EventArgs e)
        {
            //dgProductos.DataSource = null;
            //dgProductos.DataSource = controller.ListaProductos;
        
        }

        //Gestiona las pulsaciones en celdas del datagrid
        private void HandleDataGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgProductos.EndEdit(); //Es necesario actualizar los cambios antes de extraer los productos seleccionados, ya que si se consulta la lista sin salir del foco del último checkbox no se registra ese último
            DataGridViewRow row = dgProductos.Rows[e.RowIndex];
            DataGridViewTextBoxCell cell = row.Cells["Cod"] as DataGridViewTextBoxCell;
            String cod = cell.Value as String;
            switch (dgProductos.CurrentCell.OwningColumn.Name)
            {
                case "seleccionado":
                    if (Convert.ToBoolean(((DataGridViewCheckBoxCell)row.Cells["Seleccionado"]).Value))
                        controller.ProductosSeleccionados.Add(cod);
                    else
                        controller.ProductosSeleccionados.Remove(cod);
                    break;
                
                case "iconoEditar":
                    ProductoModify pr = new ProductoModify(cod);
                    pr.ShowDialog();
                    break;
                
                case "iconoEliminar":
                    controller.EliminaProducto(cod);
                    break;
                default: break;
            }
        }

        //Apertura del formulario de registro de producto
        private void RegisterProduct(object sender, EventArgs e)
        {
            ProductoRegister registerForm = new ProductoRegister();
            registerForm.ShowDialog();
        }

        //Cuando se pulsa el botón de eliminar seleccionados, se borran las filas con el checkbox clicado
        private void DeleteSelectedItems(object sender, EventArgs e)
        {
            int rowsToDelete = controller.ProductosSeleccionados.Count;
            if (rowsToDelete > 0)
            {
                var decision = MessageBox.Show("Desea eliminar " + rowsToDelete + " productos de la lista?", "Confirm Delete!!", MessageBoxButtons.YesNo);
                if (decision == DialogResult.Yes)
                    controller.RemoveSelectedProducts();
            }
            else NoProductsSelected();
        }

        private void EditSelectedProducts(object sender, EventArgs e)
        {
            int rowsToDelete = controller.ProductosSeleccionados.Count;
            if (rowsToDelete > 0)
            {
                if (rowsToDelete == 1)
                {
                    ProductoModify pm = new ProductoModify(controller.ProductosSeleccionados[0]);
                    pm.ShowDialog();
                }
                else
                {
                    ProductoModifyMultiple pmm = new ProductoModifyMultiple();
                    pmm.ShowDialog();
                }


            }
            else this.NoProductsSelected();
        }

        //Mensaje para cuando se trata de realizar una accion que requiere tener seleccionados productos
        private void NoProductsSelected()
        {
            MessageBox.Show("No hay productos seleccionado, utilize la casilla de la derecha de los productos para seleccionarlos.",
                                "No hay productos seleccionados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }

        //Botón auxiliar para rellenar la lista rápidamente y debgear
        private void CreateDemoProduct(object sender, EventArgs e)
        {
            controller.ListaProductos.Add(new Producto("a", "a", 1, 1, "a", ETipo.RAM));
        }
        //Botón auxiliar para rellenar la lista rápidamente y debgear
        private void CreateDemoProductB(object sender, EventArgs e)
        {
            controller.ListaProductos.Add(new Producto("b", "a", 1, 1, "a", ETipo.RAM));
        }//Botón auxiliar para rellenar la lista rápidamente y debgear
        private void CreateDemoProductC(object sender, EventArgs e)
        {
            controller.ListaProductos.Add(new Producto("c", "a", 1, 1, "a", ETipo.RAM));
        }





















        //Deprecated
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

        private List<string> GetSelectedCod()
        {
            dgProductos.EndEdit(); //Es necesario actualizar los cambios antes de extraer los productos seleccionados, ya que si se consulta la lista sin salir del foco del último checkbox no se registra ese último
            List<string> selectedRowsCod = new List<string>();
            foreach (DataGridViewRow row in dgProductos.Rows)
            {
                if (Convert.ToBoolean(((DataGridViewCheckBoxCell)row.Cells["Seleccionado"]).Value))
                {
                    DataGridViewTextBoxCell cell = row.Cells["Cod"] as DataGridViewTextBoxCell;
                    String cod = cell.Value as String;
                    selectedRowsCod.Add(cod);

                }
            }
            return selectedRowsCod;
        }
    }
}
