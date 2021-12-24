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
            pbImage.Image = currentProduct.Imagen;
            tbId.Enabled = false;
        }

        private void UpdateCurrentProductChanges()
        {
            products[currentPos].Nombre = tbNombre.Text;
            products[currentPos].Cantidad = (int)nudCantidad.Value;
            products[currentPos].Tipo = (ETipo)cbTipo.SelectedIndex;
            products[currentPos].Descripcion = tbDescripcion.Text;
            products[currentPos].Precio = nudPrecio.Value;
            products[currentPos].Imagen = (Bitmap)pbImage.Image;
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
                if(product.Imagen.Tag != null && !product.Imagen.Tag.Equals("placeHolder")) //
                {
                    cachedImage = product.Imagen; //Ponemos la imagen actual como la cacheada actual
                    File.Delete(tbId.Text); //Si existe ya una imagen de ese
                    cachedImage.Save(tbId.Text);
                    using (FileStream fs = new FileStream(tbId.Text, FileMode.Open)) //Cargamos como un flujo para liberar el recurso y poder eliminarlo cuando se edite el Producto posteriormente
                    {
                        product.Imagen = (Bitmap)Bitmap.FromStream(fs);
                        fs.Close();
                    }
                }
                controller.editaProducto(product);
            });
            controller.ProductosSeleccionados.Clear();
            this.Close();
        }
    }
}
