using EjercicioProductos.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductos.view
{
    public partial class ProductoModifyMultiple : ProductModify
    {
        private Button bNext;
        private Button bPrevious;
        private List<Product> products;
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
            Product currentProduct = products[currentPos];
            lInternalTitle.Text = "Modifique el producto ("+(currentPos+1)+"/"+products.Count+")";
            tbName.Text = currentProduct.Name;
            tbId.Text = currentProduct.Id;
            nudQuantity.Value = currentProduct.Quantity;
            nudPrice.Value = currentProduct.Price;
            cbType.SelectedIndex = (int)currentProduct.Type;
            tbDescription.Text = currentProduct.Description;
            pbImage.Image = currentProduct.Image;
            tbId.Enabled = false;
        }

        private void UpdateCurrentProductChanges()
        {
            products[currentPos].Name = tbName.Text;
            products[currentPos].Quantity = (int)nudQuantity.Value;
            products[currentPos].Type = (EComputerPartType)cbType.SelectedIndex;
            products[currentPos].Description = tbDescription.Text;
            products[currentPos].Price = nudPrice.Value;
            products[currentPos].Image = (Bitmap)pbImage.Image;
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
            //Guardamos en la carpeta del proyecto todas las imagenes precargadas (que no sean la de por defecto)
            products.ForEach(product => {
                if(product.Image.Tag != null && !product.Image.Tag.Equals("placeHolder")) //
                {
                    cachedImage = product.Image; //Ponemos la imagen actual como la cacheada actual
                    File.Delete(tbId.Text); //Si existe ya una imagen de ese
                    cachedImage.Save(tbId.Text);
                    using (FileStream fs = new FileStream(tbId.Text, FileMode.Open)) //Cargamos como un flujo para liberar el recurso y poder eliminarlo cuando se edite el Producto posteriormente
                    {
                        product.Image = (Bitmap)Bitmap.FromStream(fs);
                        fs.Close();
                    }
                }
                controller.ModifyProduct(product);
            });
            controller.SelectedProducts.Clear();
            this.Close();
        }
    }
}
