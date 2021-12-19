namespace EjercicioProductos.view
{
    partial class ProductoRegister
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
            this.components = new System.ComponentModel.Container();
            this.lNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IId = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lCantidad = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lTipo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bRegistrar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ttCursor = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(68, 87);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(51, 15);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(143, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Enter += new System.EventHandler(this.showToolTip);
            this.textBox1.Leave += new System.EventHandler(this.CheckNotEmpty);
            // 
            // IId
            // 
            this.IId.AutoSize = true;
            this.IId.Location = new System.Drawing.Point(68, 119);
            this.IId.Name = "IId";
            this.IId.Size = new System.Drawing.Size(49, 15);
            this.IId.TabIndex = 2;
            this.IId.Text = "Código ";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(143, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.Leave += new System.EventHandler(this.EvaluateID);
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Location = new System.Drawing.Point(68, 151);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(55, 15);
            this.lCantidad.TabIndex = 4;
            this.lCantidad.Text = "Cantidad";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(68, 183);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(40, 15);
            this.lPrecio.TabIndex = 6;
            this.lPrecio.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descripción";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(143, 244);
            this.tbDescription.MaxLength = 250;
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(257, 74);
            this.tbDescription.TabIndex = 11;
            this.tbDescription.TextChanged += new System.EventHandler(this.validateDescription);
            // 
            // lTipo
            // 
            this.lTipo.AutoSize = true;
            this.lTipo.Location = new System.Drawing.Point(68, 215);
            this.lTipo.Name = "lTipo";
            this.lTipo.Size = new System.Drawing.Size(30, 15);
            this.lTipo.TabIndex = 10;
            this.lTipo.Text = "Tipo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Procesador",
            "Placa Base",
            "RAM",
            "Tarjeta Gráfica",
            "Fuente de Alimentación",
            "Disco Duro"});
            this.comboBox1.Location = new System.Drawing.Point(143, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(68, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Registrar nuevo producto:";
            // 
            // bRegistrar
            // 
            this.bRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bRegistrar.Location = new System.Drawing.Point(316, 358);
            this.bRegistrar.Name = "bRegistrar";
            this.bRegistrar.Size = new System.Drawing.Size(75, 23);
            this.bRegistrar.TabIndex = 13;
            this.bRegistrar.Text = "Registrar";
            this.bRegistrar.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelar.Location = new System.Drawing.Point(397, 358);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 14;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(143, 149);
            this.nudCantidad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(91, 23);
            this.nudCantidad.TabIndex = 5;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(143, 181);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(91, 23);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ttCursor
            // 
            this.ttCursor.IsBalloon = true;
            this.ttCursor.ToolTipTitle = "TItulo";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ProductoRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 393);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lTipo);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.lCantidad);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.IId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lNombre);
            this.MinimumSize = new System.Drawing.Size(500, 0);
            this.Name = "ProductoRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductoRegister";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lNombre;
        private TextBox textBox1;
        private Label IId;
        private TextBox textBox2;
        private Label lCantidad;
        private Label lPrecio;
        private Label label1;
        private TextBox tbDescription;
        private Label lTipo;
        private ComboBox comboBox1;
        private Label label2;
        private Button bRegistrar;
        private Button bCancelar;
        private NumericUpDown nudCantidad;
        private NumericUpDown numericUpDown1;
        private ToolTip ttCursor;
        private ErrorProvider errorProvider;
    }
}