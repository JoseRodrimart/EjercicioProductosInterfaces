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
        private ProductController controller = ProductController.GetInstance();
        List<int> selectedRows = new List<int>();

        public ProductManager()
        {
            InitializeComponent();
            dgProductsGrid.DataSource = null;
            dgProductsGrid.DataSource = controller.ProductList;
            dgProductsGrid.Columns["Precio"].DefaultCellStyle.Format = "c"; //Establece el formato de la columna de Precio en "c" (currency)
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
            dgProductsGrid.EndEdit(); //Es necesario actualizar los cambios antes de extraer los productos seleccionados, ya que si se consulta la lista sin salir del foco del último checkbox no se registra ese último
            DataGridViewRow row = dgProductsGrid.Rows[e.RowIndex];
            DataGridViewTextBoxCell cell = row.Cells["Id"] as DataGridViewTextBoxCell;
            String cod = cell.Value as String;
            switch (dgProductsGrid.CurrentCell.OwningColumn.Name)
            {
                case "seleccionado":
                    if (Convert.ToBoolean(((DataGridViewCheckBoxCell)row.Cells["Seleccionado"]).Value))
                        controller.SelectedProducts.Add(cod);
                    else
                        controller.SelectedProducts.Remove(cod);
                    break;

                case "iconoEditar":
                    RemoveFilters();
                    ProductModify pr = new ProductModify(cod);
                    pr.ShowDialog();
                    break;

                case "iconoEliminar":
                    RemoveFilters();
                    controller.EliminaProducto(cod);
                    break;
                default: break;
            }
        }

        //Apertura del formulario de registro de producto
        private void RegisterProduct(object sender, EventArgs e)
        {
            ProductRegister registerForm = new ProductRegister();
            registerForm.ShowDialog();
        }

        //Cuando se pulsa el botón de eliminar seleccionados, se borran las filas con el checkbox clicado
        private void DeleteSelectedItems(object sender, EventArgs e)
        {
            int rowsToDelete = controller.SelectedProducts.Count;
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
            int rowsToDelete = controller.SelectedProducts.Count;
            if (rowsToDelete > 0)
            {
                RemoveFilters();
                if (rowsToDelete == 1)
                {
                    ProductModify pm = new ProductModify(controller.SelectedProducts[0]);
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
            controller.ProductList.Add(new Product("a", "a", 1, 1, "a", EComputerPartType.RAM, new Bitmap(Properties.Resources.placeholderProduct)));
        }
        //Botón auxiliar para rellenar la lista rápidamente y debgear
        private void CreateDemoProductB(object sender, EventArgs e)
        {
            controller.ProductList.Add(new Product("b", "a", 1, 1, "a", EComputerPartType.RAM, new Bitmap(Properties.Resources.placeholderProduct)));
        }//Botón auxiliar para rellenar la lista rápidamente y debgear
        private void CreateDemoProductC(object sender, EventArgs e)
        {
            controller.ProductList.Add(new Product("c", "a", 1, 1, "a", EComputerPartType.RAM, new Bitmap(Properties.Resources.placeholderProduct)));
        }


        //Dialogo de Importar CSV
        private void OpenImportDialog(object sender, EventArgs e)
        {
            if (dImport.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<Product> importingProducts = controller.ImportCsv(dImport.OpenFile());
                    int repeticiones = controller.CountAlreadyPresentProducts(importingProducts);
                    if (repeticiones > 0)
                    {
                        var response = MessageBox.Show("Hay " + repeticiones + " productos coincidentes. ¿Desea sobreescribir los productos actuales?",
                                "Productos ya existentes",
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Warning);
                        if (response == DialogResult.Yes)
                        {
                            controller.InsertProducts(importingProducts);
                        }
                        else if(response == DialogResult.No)
                        {
                            controller.InsertProducts(importingProducts, false); //el método de insertar productos acepta un parámetro bool para indicar si se deben de sobreescribir las coincidencias
                        }
                    }
                    else controller.InsertProducts(importingProducts);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido un error al importar el fichero",
                                "Error durante la importación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
            }  
        }

        private void OpenExportDialog(object sender, EventArgs e)
        {
            if (controller.ProductList.Count > 0)
            {
                if (dExport.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        controller.ExportToCsv(dExport.OpenFile());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se ha producido un error durante la exportación",
                                    "Error durante la exportación",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    }
                }
                    
            }
            else MessageBox.Show("No hay productos para exportar.",
                                "Lista de productos vacía",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }

        private void RemoveFilters(object sender, EventArgs e)
        {
            RemoveFilters();
        }

        private void RemoveFilters()
        {
            //Limpiamos todos los campos de filtro
            tbNameFilter.Text = tbCodeFilter.Text = tbQuantityFilter.Text = tbPriceFIlter.Text = cbTypeFilter.Text = String.Empty;
            //Limpiamos los filtros del controlador
            controller.Filter.Values.ToList().ForEach(value => value = String.Empty);
            controller.ApplyFilters();
        }

        private void FilterModified(object sender, KeyEventArgs e)
        {
            ToolStripTextBox writedElement = (ToolStripTextBox)sender;

            controller.Filter[(String)writedElement.Tag] = writedElement.Text;

            /*controller.Filter["Id"] = tbCodeFilter.Text;
            controller.Filter["Name"] = tbNameFilter.Text;
            controller.Filter["Quantity"] = tbQuantityFilter.Text;
            controller.Filter["Price"] = tbPriceFIlter.Text;*/
            controller.ApplyFilters();
        }

        private void OpenAboutForm(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.ShowDialog();
        }

        private void TypeFilterModified(object sender, EventArgs e)
        {
            controller.Filter["Type"] = cbTypeFilter.Text;
            controller.ApplyFilters();
        }
    }
}
