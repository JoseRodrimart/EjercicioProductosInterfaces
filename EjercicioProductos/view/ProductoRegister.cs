﻿using EjercicioProductos.controller;
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
    public partial class ProductoRegister : Form
    {
        protected ProductosController controller; 
        private bool idAvailable = false;
        private int iconPadding = 5;

        //Si se construye sin parámetros, crea uno nuevo
        public ProductoRegister()
        {
            InitializeComponent();
            controller = ProductosController.GetInstance();
        }
        //SI se construye con parámetros permite editar varios
        public ProductoRegister(List<Producto> productos)
        {
            controller = ProductosController.GetInstance();
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
                controller.RegistraProducto(new Producto(tbId.Text,tbNombre.Text,(int)nudCantidad.Value,nudPrecio.Value,tbDescripcion.Text,(ETipo)cbTipo.SelectedIndex));
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
                if (controller.CompruebaId(tbId.Text))
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
    }
}
