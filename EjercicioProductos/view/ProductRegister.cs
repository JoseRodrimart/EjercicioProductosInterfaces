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
    public partial class ProductRegister : Form
    {
        protected ProductController controller; 
        private bool idAvailable = false;
        private int iconPadding = 5;
        protected Bitmap Image = new Bitmap(Properties.Resources.placeholderProduct) { Tag = "placeholder" }; //Por defecto llevan una imagen placeholder, con un tag para identificarlo
        protected Bitmap cachedImage = null;

        public ProductRegister()
        {
            InitializeComponent();
            controller = ProductController.GetInstance();
        }

        protected virtual void RegisterProduct(object sender, EventArgs e)
        {
            try
            {
                StoreCachedImage();
                Product storingProduct = new Product(tbId.Text, tbName.Text, (int)nudQuantity.Value, nudPrice.Value, tbDescription.Text, (EComputerPartType)cbType.SelectedIndex, Image);
                controller.RegisterNewProduct(storingProduct);
                Close();
            }
            catch (Exception ex) { Debug.Write(ex.Message); }
        }

        //Nos impide registrar cuando no hay id, nombre, tipo o la id coincide con uno ya existente
        protected virtual void ValidateRegister()
        {
            if(tbId.Text.Length != 0 && tbName.Text.Length != 0 && cbType.SelectedItem != null && idAvailable) bRegister.Enabled = true;
            else bRegister.Enabled = false;    
        }

        private void CancelRegister(object sender, EventArgs e)
        {
            Close();
        }

        private void IndexChanged(object sender, EventArgs e)
        {
            ValidateRegister();
        }

        private void NameChanged(object sender, EventArgs e)
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

        protected virtual void IdTextChanged(object sender, EventArgs e)
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

        //Metodo para guardar dentro del proyecto la imagen seleccionada, y no depender de una referencia externa
        protected void StoreCachedImage()
        {
            if(cachedImage != null)
            {
                File.Delete(tbId.Text); //Si existe ya una imagen de ese id se elimina
                cachedImage.Save(tbId.Text);
                using (FileStream fs = new FileStream(tbId.Text, FileMode.Open)) //Cargamos la imagen como un flujo para liberar el recurso y poder eliminarlo cuando se edite el Producto
                {
                    Image = (Bitmap)Bitmap.FromStream(fs); 
                    fs.Close();
                }
            }
        }
    }
}
