using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductos.view
{
    partial class ProductoModifyMultiple
    {
        private void InitializeComponent()
        {
            this.bNext = new System.Windows.Forms.Button();
            this.bPrevious = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNotAvailableId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bRegistrar
            // 
            this.bRegistrar.Location = new System.Drawing.Point(260, 680);
            this.bRegistrar.Size = new System.Drawing.Size(125, 23);
            this.bRegistrar.Text = "Guardar cambios";
            this.bRegistrar.Click += new System.EventHandler(this.bRegistrar_Click);
            // 
            // lInternalTitle
            // 
            this.lInternalTitle.Size = new System.Drawing.Size(206, 25);
            this.lInternalTitle.Text = "Modifique el producto ";
            // 
            // IId
            // 
            this.ttCursorCod.SetToolTip(this.IId, "El código es único para cada producto y no puede repetirse");
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(443, 301);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(23, 59);
            this.bNext.TabIndex = 16;
            this.bNext.Text = ">";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.NextProduct);
            // 
            // bPrevious
            // 
            this.bPrevious.Location = new System.Drawing.Point(23, 301);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(23, 59);
            this.bPrevious.TabIndex = 17;
            this.bPrevious.Text = "<";
            this.bPrevious.UseVisualStyleBackColor = true;
            this.bPrevious.Visible = false;
            this.bPrevious.Click += new System.EventHandler(this.PreviousProduct);
            // 
            // ProductoModifyMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(484, 715);
            this.Controls.Add(this.bPrevious);
            this.Controls.Add(this.bNext);
            this.Name = "ProductoModifyMultiple";
            this.Text = "Modificación productos";
            this.Controls.SetChildIndex(this.pbImage, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.IId, 0);
            this.Controls.SetChildIndex(this.tbNombre, 0);
            this.Controls.SetChildIndex(this.tbId, 0);
            this.Controls.SetChildIndex(this.tbDescripcion, 0);
            this.Controls.SetChildIndex(this.cbTipo, 0);
            this.Controls.SetChildIndex(this.lInternalTitle, 0);
            this.Controls.SetChildIndex(this.bRegistrar, 0);
            this.Controls.SetChildIndex(this.nudCantidad, 0);
            this.Controls.SetChildIndex(this.nudPrecio, 0);
            this.Controls.SetChildIndex(this.bNext, 0);
            this.Controls.SetChildIndex(this.bPrevious, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNotAvailableId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
