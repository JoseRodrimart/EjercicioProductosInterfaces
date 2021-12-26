using EjercicioProductos.model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductos.view
{
    public partial class ProductModify : ProductRegister
    {
        private Product product;

        public ProductModify(): base() { 
        
        }

        public ProductModify(String codProducto) : base() //Iniciamos el editor con la id del producto que se ha seleccionado editar
        {
            lInternalTitle.Text = "Modifique los datos del producto:";
            bRegister.Text = "Modificar";
            tbId.Enabled = false; //No se puede editar la id de un producto por consistencia de la lógica
            
            product = controller.SearchProduct(codProducto); //Cargamos los datos de ese producto desde el controlador
            tbName.Text = product.Name;
            tbId.Text = product.Id;
            nudQuantity.Value = product.Quantity;
            cbType.SelectedIndex = (int)product.Type;
            tbDescription.Text = product.Description;
            pbImage.Image = product.Image;
            Image = product.Image;
        }

        //No nos deja guardar si dejamos en blanco el nombre
        protected override void ValidateRegister()
        {
            if (tbName.Text.Length > 0) bRegister.Enabled = true;
            else bRegister.Enabled = false;
        }

        //Sobreescribimos el metodo que reacciona al cambio de id y lo dejamos sin funcionalidad
        protected override void IdTextChanged(object sender, EventArgs e)
        {

        }

        protected override void RegisterProduct(object sender, EventArgs e)
        {
            StoreCachedImage();
            Product newProduct = new Product(tbId.Text, tbName.Text, (int)nudQuantity.Value, nudPrice.Value, tbDescription.Text, (EComputerPartType)cbType.SelectedIndex, Image);
            try
            {
                controller.ModifyProduct(newProduct);
                Close();
            }
            catch (Exception ex) { Debug.Write(ex.Message); }
        }
    }
}
