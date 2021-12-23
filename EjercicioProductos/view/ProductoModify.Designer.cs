using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductos.view
{
    partial class ProductoModify
    {
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNotAvailableId)).BeginInit();
            this.SuspendLayout();
            // 
            // bRegistrar
            // 
            this.bRegistrar.Location = new System.Drawing.Point(266, 358);
            this.bRegistrar.Size = new System.Drawing.Size(125, 23);
            this.bRegistrar.Text = "Guardar Cambios";
            // 
            // lInternalTitle
            // 
            this.lInternalTitle.Size = new System.Drawing.Size(296, 25);
            this.lInternalTitle.Text = "Modifique los datos del producto:";
            // 
            // ttCursorCod
            // 
            this.ttCursorCod.ToolTipTitle = "Código";
            // 
            // ProductoModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(484, 393);
            this.Name = "ProductoModify";
            this.Text = "Modificación de producto";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNotAvailableId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
