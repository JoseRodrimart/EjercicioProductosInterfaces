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
        private Producto oldProduct;

        //Para gestionar la edición múltiple, colocamos un indicador de cuantos productos de la lista actual se han modificado (x/n)
        /*protected ProductoModify() : base()
        {

        }*/
        public ProductoModify(): base() { 
        
        }

        public ProductoModify(String codProducto) : base()
        {
            oldProduct = controller.BuscaProducto(codProducto);
            bRegistrar.Text = "Modificar";
            tbNombre.Text = oldProduct.Nombre;
            tbId.Text = oldProduct.Id;
            nudCantidad.Value = oldProduct.Cantidad;
            cbTipo.SelectedIndex = (int)oldProduct.Tipo;
            tbDescripcion.Text = oldProduct.Descripcion;
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
            Producto newProduct = new Producto(tbId.Text, tbNombre.Text, (int)nudCantidad.Value, nudPrecio.Value, tbDescripcion.Text, (ETipo)cbTipo.SelectedIndex);
            try
            {
                controller.editaProducto(newProduct);
                Close();
            }
            catch (Exception ex) { Debug.Write(ex.Message); }
        }
    }
}
