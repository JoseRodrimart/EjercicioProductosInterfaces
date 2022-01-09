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

        public ProductManager()
        {
            InitializeComponent();
            dgProductsGrid.DataSource = null;
            dgProductsGrid.DataSource = controller.Source;
            var a = dgProductsGrid.DataSource;
            dgProductsGrid.Columns["Precio"].DefaultCellStyle.Format = "c"; //Establece el formato de la columna de Precio en "c" (currency)
            tscbOrderField.SelectedIndex = 0;
            tscbOrderDirection.SelectedIndex = 0;
        }

        //La primera vez que se termina de mostrar la ventana principal, sobreponemos una ventana de información
        private void ProductManagerShownEvent(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.ShowDialog();
        }

        //Gestiona las pulsaciones en celdas del datagrid
        private void HandleDataGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex == -1)) //Evitamos los clicks en los títulos
            {
                dgProductsGrid.EndEdit(); //Es necesario actualizar los cambios antes de extraer los productos seleccionados, ya que si se consulta la lista sin salir del foco del último checkbox no se registra ese último
                DataGridViewRow row = dgProductsGrid.Rows[e.RowIndex];
                DataGridViewTextBoxCell cell = row.Cells["Id"] as DataGridViewTextBoxCell;
                String cod = cell.Value as String;
                switch (dgProductsGrid.CurrentCell.OwningColumn.Name)
                {
                    case "SelectCheckBox":
                        if (Convert.ToBoolean(((DataGridViewCheckBoxCell)row.Cells["SelectCheckBox"]).Value))
                            controller.SelectedProducts.Add(cod);
                        else
                            controller.SelectedProducts.Remove(cod);
                        break;

                    case "EditButton":
                        //RemoveFilters();
                        ProductModify pr = new ProductModify(cod);
                        pr.ShowDialog();
                        break;

                    case "DeleteButton":
                        //RemoveFilters();
                        controller.EliminaProducto(cod);
                        break;
                    default: break;
                }
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
                //RemoveFilters();
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

        private void OpenAboutForm(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.ShowDialog();
        }
    }
}
