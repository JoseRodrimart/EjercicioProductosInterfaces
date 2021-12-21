namespace EjercicioProductos.view
{
    partial class ProductEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lTipo = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            this.lCantidad = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.IId = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(120, 177);
            this.nudPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(91, 23);
            this.nudPrecio.TabIndex = 28;
            this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(120, 145);
            this.nudCantidad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(91, 23);
            this.nudCantidad.TabIndex = 21;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Editar producto:";
            // 
            // cbTipo
            // 
            this.cbTipo.DisplayMember = "Seleccione";
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Procesador",
            "Placa Base",
            "RAM",
            "Tarjeta Gráfica",
            "Fuente de Alimentación",
            "Disco Duro"});
            this.cbTipo.Location = new System.Drawing.Point(120, 208);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(154, 23);
            this.cbTipo.TabIndex = 24;
            this.cbTipo.ValueMember = "Seleccione";
            // 
            // lTipo
            // 
            this.lTipo.AutoSize = true;
            this.lTipo.Location = new System.Drawing.Point(45, 211);
            this.lTipo.Name = "lTipo";
            this.lTipo.Size = new System.Drawing.Size(30, 15);
            this.lTipo.TabIndex = 25;
            this.lTipo.Text = "Tipo";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(120, 240);
            this.tbDescripcion.MaxLength = 250;
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(252, 74);
            this.tbDescripcion.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Descripción";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(45, 179);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(40, 15);
            this.lPrecio.TabIndex = 22;
            this.lPrecio.Text = "Precio";
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Location = new System.Drawing.Point(45, 147);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(55, 15);
            this.lCantidad.TabIndex = 20;
            this.lCantidad.Text = "Cantidad";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(120, 80);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(252, 23);
            this.tbId.TabIndex = 19;
            // 
            // IId
            // 
            this.IId.AutoSize = true;
            this.IId.Location = new System.Drawing.Point(45, 83);
            this.IId.Name = "IId";
            this.IId.Size = new System.Drawing.Size(49, 15);
            this.IId.TabIndex = 18;
            this.IId.Text = "Código ";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(120, 112);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(252, 23);
            this.tbNombre.TabIndex = 17;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(45, 115);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(51, 15);
            this.lNombre.TabIndex = 16;
            this.lNombre.Text = "Nombre";
            // 
            // ProductEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 407);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lTipo);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.lCantidad);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.IId);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lNombre);
            this.Name = "ProductEditor";
            this.Text = "ProductEditor";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nudPrecio;
        private NumericUpDown nudCantidad;
        private Label label2;
        private ComboBox cbTipo;
        private Label lTipo;
        private TextBox tbDescripcion;
        private Label label1;
        private Label lPrecio;
        private Label lCantidad;
        private TextBox tbId;
        private Label IId;
        private TextBox tbNombre;
        private Label lNombre;
        private PageSetupDialog pageSetupDialog1;
    }
}