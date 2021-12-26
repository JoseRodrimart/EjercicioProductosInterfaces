using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductos.view
{
    partial class ProductModify
    {
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNotAvailableId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bRegistrar
            // 
            this.bRegister.Location = new System.Drawing.Point(266, 680);
            this.bRegister.Size = new System.Drawing.Size(125, 23);
            this.bRegister.Text = "Guardar Cambios";
            this.bRegister.Click += new System.EventHandler(this.RegisterProduct);
            // 
            // lInternalTitle
            // 
            this.lInternalTitle.Size = new System.Drawing.Size(296, 25);
            this.lInternalTitle.Text = "Modifique los datos del producto:";
            // 
            // IId
            // 
            this.ttCursorCod.SetToolTip(this.IId, "El código es único para cada producto y no puede repetirse");
            // 
            // ttCursorCod
            // 
            this.ttCursorCod.ToolTipTitle = "Código";
            // 
            // ProductoModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(484, 715);
            this.Name = "ProductoModify";
            this.Text = "Modificación de producto";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNotAvailableId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
