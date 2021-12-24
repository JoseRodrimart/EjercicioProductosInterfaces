using EjercicioProductos.model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductos.view
{
    public partial class ProductoModify : ProductoRegister
    {
        private Producto product;

        //Para gestionar la edición múltiple, colocamos un indicador de cuantos productos de la lista actual se han modificado (x/n)
        /*protected ProductoModify() : base()
        {

        }*/
        public ProductoModify(): base() { 
        
        }

        public ProductoModify(String codProducto) : base()
        {
            product = controller.BuscaProducto(codProducto);
            bRegistrar.Text = "Modificar";
            tbNombre.Text = product.Nombre;
            tbId.Text = product.Id;
            nudCantidad.Value = product.Cantidad;
            cbTipo.SelectedIndex = (int)product.Tipo;
            tbDescripcion.Text = product.Descripcion;
            pbImage.Image = product.Imagen;
            tbId.Enabled = false;
        }

        protected override void ValidateRegister()
        {
            if (tbId.Text.Length != 0 && tbNombre.Text.Length != 0 && cbTipo.SelectedItem != null) bRegistrar.Enabled = true;
            else bRegistrar.Enabled = false;
        }

        protected override void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void bAccept_Click(object sender, EventArgs e)
        {
            StoreCachedImage();
            Producto newProduct = new Producto(tbId.Text, tbNombre.Text, (int)nudCantidad.Value, nudPrecio.Value, tbDescripcion.Text, (ETipo)cbTipo.SelectedIndex, Image);
            try
            {
                controller.editaProducto(newProduct);
                Close();
            }
            catch (Exception ex) { Debug.Write(ex.Message); }
        }

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            StoreCachedImage();

        }
    }
}
