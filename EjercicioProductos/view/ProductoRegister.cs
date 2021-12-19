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
    public partial class ProductoRegister : Form
    {
        public ProductoRegister()
        {
            InitializeComponent();
        }

        private void validateDescription(object sender, EventArgs e)
        {
            if (tbDescription.Text.Length == 250)
                ttCursor.Show("prueba",this);
        }

        private void showToolTip(object sender, EventArgs e)
        {
            //Si se llega a 250 caracteres se muestra
            ttCursor.Show("prueba", this, 0, 0);
        }

        private void EvaluateID(object sender, EventArgs e)
        {
            //Comprobamos si la id está disponible
        }

        private void CheckNotEmpty(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                errorProvider.SetError((TextBox)sender, "prueba");
        }
    }
}
