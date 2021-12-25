using EjercicioProductos.controller;
using EjercicioProductos.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioProductos.view
{
    public partial class ProductoRegister : Form
    {
        protected ProductController controller; 
        private bool idAvailable = false;
        private int iconPadding = 5;
        protected Bitmap Image = new Bitmap(Properties.Resources.placeholderProduct) { Tag = "placeholder" }; //Por defecto llevan una imagen placeholder, con un tag para identificarlo
        protected Bitmap cachedImage = null;

        public ProductoRegister()
        {
            InitializeComponent();
            controller = ProductController.GetInstance();
            //pbImage.Image = new Bitmap()
        }

        private void validateDescription(object sender, EventArgs e)
        {
            if (tbDescripcion.Text.Length == 250)
                ttCursorCod.Show("prueba",this);
        }

        protected virtual void bAccept_Click(object sender, EventArgs e)
        {
            try
            {
                StoreCachedImage();
                Product storingProduct = new Product(tbId.Text, tbNombre.Text, (int)nudCantidad.Value, nudPrecio.Value, tbDescripcion.Text, (EComputerPartType)cbTipo.SelectedIndex, Image);
                controller.RegisterNewProduct(storingProduct);
                Close();
            }
            catch (Exception ex) { Debug.Write(ex.Message); }
        }

        protected virtual void ValidateRegister()
        {
            if(tbId.Text.Length != 0 && tbNombre.Text.Length != 0 && cbTipo.SelectedItem != null && idAvailable) bRegistrar.Enabled = true;
            else bRegistrar.Enabled = false;    
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateRegister();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ErrEmptyName.SetError((TextBox)sender, "el nombre no puede estar vacío");
                ErrEmptyName.SetIconPadding((TextBox)sender, iconPadding);
            }
            else
                ErrEmptyName.Clear();
            ValidateRegister();
        }

        protected virtual void tbId_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                errEmptyId.Clear();
                errEmptyId.SetError((TextBox)sender, "El código no puede estar vacío");
                errEmptyId.SetIconPadding((TextBox)sender, iconPadding);
                errNotAvailableId.Clear();
            }
            else
            {
                errEmptyId.Clear();
                if (controller.CheckProductById(tbId.Text))
                {
                    errNotAvailableId.SetError(tbId, "El código ya está en uso");
                    errNotAvailableId.SetIconPadding((TextBox)sender, iconPadding);
                    idAvailable = false;
                }
                else
                {
                    errNotAvailableId.Clear();
                    idAvailable = true;
                }
            }
            ValidateRegister();
        }

        private void SelectImage(object sender, EventArgs e)
        {
            if (dialogImagePicker.ShowDialog() == DialogResult.OK)
            {
                var imageLocalPath = dialogImagePicker.FileName;
                tbImagePath.Text = imageLocalPath;
                cachedImage = new Bitmap(new Bitmap(imageLocalPath), new Size(256,256));
                pbImage.Image = cachedImage;
            }
        }

        protected void StoreCachedImage()
        {
            if(cachedImage != null)
            {
                File.Delete(tbId.Text); //Si existe ya una imagen de ese
                cachedImage.Save(tbId.Text);
                using (FileStream fs = new FileStream(tbId.Text, FileMode.Open)) //Cargamos como un flujo para liberar el recurso y poder eliminarlo cuando se edite el Producto
                {
                    Image = (Bitmap)Bitmap.FromStream(fs); 
                    fs.Close();
                }
            }
        }
    }
}
