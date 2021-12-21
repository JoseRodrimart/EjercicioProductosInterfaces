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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoRegister));
            this.lNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.IId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lCantidad = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lTipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bRegistrar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.ttCursor = new System.Windows.Forms.ToolTip(this.components);
            this.errEmptyId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNotAvailableId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrEmptyName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmptyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNotAvailableId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrEmptyName)).BeginInit();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(73, 87);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(51, 15);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.Location = new System.Drawing.Point(148, 84);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(252, 23);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            this.tbNombre.Leave += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // IId
            // 
            this.IId.AutoSize = true;
            this.IId.Location = new System.Drawing.Point(73, 119);
            this.IId.Name = "IId";
            this.IId.Size = new System.Drawing.Size(49, 15);
            this.IId.TabIndex = 2;
            this.IId.Text = "Código ";
            // 
            // tbId
            // 
            this.tbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbId.Location = new System.Drawing.Point(148, 116);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(252, 23);
            this.tbId.TabIndex = 3;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            this.tbId.Leave += new System.EventHandler(this.tbId_TextChanged);
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Location = new System.Drawing.Point(73, 151);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(55, 15);
            this.lCantidad.TabIndex = 4;
            this.lCantidad.Text = "Cantidad";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(73, 183);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(40, 15);
            this.lPrecio.TabIndex = 6;
            this.lPrecio.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descripción";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescripcion.Location = new System.Drawing.Point(148, 244);
            this.tbDescripcion.MaxLength = 250;
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(252, 74);
            this.tbDescripcion.TabIndex = 11;
            this.tbDescripcion.TextChanged += new System.EventHandler(this.validateDescription);
            // 
            // lTipo
            // 
            this.lTipo.AutoSize = true;
            this.lTipo.Location = new System.Drawing.Point(73, 215);
            this.lTipo.Name = "lTipo";
            this.lTipo.Size = new System.Drawing.Size(30, 15);
            this.lTipo.TabIndex = 10;
            this.lTipo.Text = "Tipo";
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
            this.cbTipo.Location = new System.Drawing.Point(148, 212);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(154, 23);
            this.cbTipo.TabIndex = 9;
            this.cbTipo.ValueMember = "Seleccione";
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(73, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Registrar nuevo producto:";
            // 
            // bRegistrar
            // 
            this.bRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bRegistrar.Enabled = false;
            this.bRegistrar.Location = new System.Drawing.Point(316, 358);
            this.bRegistrar.Name = "bRegistrar";
            this.bRegistrar.Size = new System.Drawing.Size(75, 23);
            this.bRegistrar.TabIndex = 13;
            this.bRegistrar.Text = "Registrar";
            this.bRegistrar.UseVisualStyleBackColor = true;
            this.bRegistrar.Click += new System.EventHandler(this.bRegistrar_Click);
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
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(148, 149);
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
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(148, 181);
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
            this.nudPrecio.TabIndex = 15;
            this.nudPrecio.Value = new decimal(new int[] {
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
            // errEmptyId
            // 
            this.errEmptyId.ContainerControl = this;
            this.errEmptyId.Icon = ((System.Drawing.Icon)(resources.GetObject("errEmptyId.Icon")));
            // 
            // errNotAvailableId
            // 
            this.errNotAvailableId.ContainerControl = this;
            this.errNotAvailableId.Icon = ((System.Drawing.Icon)(resources.GetObject("errNotAvailableId.Icon")));
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // ErrEmptyName
            // 
            this.ErrEmptyName.ContainerControl = this;
            this.ErrEmptyName.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrEmptyName.Icon")));
            // 
            // ProductoRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 393);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bRegistrar);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 0);
            this.Name = "ProductoRegister";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductoRegister";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmptyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNotAvailableId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrEmptyName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lNombre;
        private TextBox tbNombre;
        private Label IId;
        private TextBox tbId;
        private Label lCantidad;
        private Label lPrecio;
        private Label label1;
        private TextBox tbDescripcion;
        private Label lTipo;
        private ComboBox cbTipo;
        private Label label2;
        private Button bCancelar;
        private NumericUpDown nudCantidad;
        private NumericUpDown nudPrecio;
        private ToolTip ttCursor;
        private ErrorProvider errEmptyId;
        private ErrorProvider errNotAvailableId;
        private ErrorProvider errorProvider1;
        private ErrorProvider ErrEmptyName;
        protected Button bRegistrar;
    }
}