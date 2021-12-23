using EjercicioProductos.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductos.view
{
    public partial class ProductoModifyMultiple : ProductoModify
    {
        private Button bNext;
        private Button bPrevious;
        private List<Producto> products;
        private int currentPos;

        public ProductoModifyMultiple() : base()
        {
            InitializeComponent();
            products = controller.GetSelectedProducts();
            currentPos = 0;
            DrawModifyingProduct();
        }

        private void DrawModifyingProduct()
        {
            Producto currentProduct = products[currentPos];
            lInternalTitle.Text = "Modifique el producto ("+(currentPos+1)+"/"+products.Count+")";
            tbNombre.Text = currentProduct.Nombre;
            tbId.Text = currentProduct.Id;
            nudCantidad.Value = currentProduct.Cantidad;
            nudPrecio.Value = currentProduct.Precio;
            cbTipo.SelectedIndex = (int)currentProduct.Tipo;
            tbDescripcion.Text = currentProduct.Descripcion;
            tbId.Enabled = false;
        }

        private void UpdateCurrentProductChanges()
        {
            products[currentPos].Nombre = tbNombre.Text;
            products[currentPos].Cantidad = (int)nudCantidad.Value;
            products[currentPos].Tipo = (ETipo)cbTipo.SelectedIndex;
            products[currentPos].Descripcion = tbDescripcion.Text;
            products[currentPos].Precio = nudPrecio.Value;
        }

        private void NextProduct(object sender, EventArgs e)
        {
            UpdateCurrentProductChanges();
            currentPos++;
            bNext.Visible = (currentPos == products.Count - 1) ? false : true;
            bPrevious.Visible = (currentPos == 0) ? false : true;
            DrawModifyingProduct();
        }

        private void PreviousProduct(object sender, EventArgs e)
        {
            UpdateCurrentProductChanges();
            currentPos--;
            bNext.Visible = (currentPos == products.Count - 1) ? false : true;
            bPrevious.Visible = (currentPos == 0) ? false : true;
            DrawModifyingProduct();
        }

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            UpdateCurrentProductChanges();
            products.ForEach(product => controller.editaProducto(product));
            controller.ProductosSeleccionados.Clear();
            this.Close();
        }
    }
}
