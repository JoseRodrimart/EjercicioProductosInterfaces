namespace EjercicioProductos.view
{
    partial class ProductRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductRegister));
            this.lName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.IId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lQuantity = new System.Windows.Forms.Label();
            this.lPrice = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lInternalTitle = new System.Windows.Forms.Label();
            this.bRegister = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.ttCursorCod = new System.Windows.Forms.ToolTip(this.components);
            this.errEmptyId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNotAvailableId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCharacter = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrEmptyName = new System.Windows.Forms.ErrorProvider(this.components);
            this.lImage = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.dialogImagePicker = new System.Windows.Forms.OpenFileDialog();
            this.tbImagePath = new System.Windows.Forms.TextBox();
            this.bSelectImage = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmptyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNotAvailableId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrEmptyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(73, 119);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(59, 15);
            this.lName.TabIndex = 0;
            this.lName.Text = "Nombre *";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(148, 116);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(256, 23);
            this.tbName.TabIndex = 3;
            this.tbName.TextChanged += new System.EventHandler(this.NameChanged);
            this.tbName.Leave += new System.EventHandler(this.NameChanged);
            // 
            // IId
            // 
            this.IId.AutoSize = true;
            this.IId.Location = new System.Drawing.Point(73, 87);
            this.IId.Name = "IId";
            this.IId.Size = new System.Drawing.Size(54, 15);
            this.IId.TabIndex = 2;
            this.IId.Text = "Código *";
            this.ttCursorCod.SetToolTip(this.IId, "El código es único para cada producto y no puede repetirse");
            // 
            // tbId
            // 
            this.tbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbId.Location = new System.Drawing.Point(148, 84);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(256, 23);
            this.tbId.TabIndex = 1;
            this.tbId.TextChanged += new System.EventHandler(this.IdTextChanged);
            this.tbId.Leave += new System.EventHandler(this.IdTextChanged);
            // 
            // lQuantity
            // 
            this.lQuantity.AutoSize = true;
            this.lQuantity.Location = new System.Drawing.Point(73, 151);
            this.lQuantity.Name = "lQuantity";
            this.lQuantity.Size = new System.Drawing.Size(63, 15);
            this.lQuantity.TabIndex = 4;
            this.lQuantity.Text = "Cantidad *";
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(73, 183);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(48, 15);
            this.lPrice.TabIndex = 6;
            this.lPrice.Text = "Precio *";
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(73, 244);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(69, 15);
            this.lDescription.TabIndex = 8;
            this.lDescription.Text = "Descripción";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(148, 244);
            this.tbDescription.MaxLength = 250;
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(256, 74);
            this.tbDescription.TabIndex = 11;
            this.tbDescription.TextChanged += new System.EventHandler(this.DescriptionChanged);
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(73, 215);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(38, 15);
            this.lType.TabIndex = 10;
            this.lType.Text = "Tipo *";
            // 
            // cbType
            // 
            this.cbType.DisplayMember = "Seleccione";
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "CPU",
            "Motherboard",
            "RAM",
            "GPU",
            "PSU",
            "HDD"});
            this.cbType.Location = new System.Drawing.Point(148, 212);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(154, 23);
            this.cbType.TabIndex = 9;
            this.cbType.ValueMember = "Seleccione";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.IndexChanged);
            // 
            // lInternalTitle
            // 
            this.lInternalTitle.AutoSize = true;
            this.lInternalTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lInternalTitle.Location = new System.Drawing.Point(73, 31);
            this.lInternalTitle.Name = "lInternalTitle";
            this.lInternalTitle.Size = new System.Drawing.Size(229, 25);
            this.lInternalTitle.TabIndex = 12;
            this.lInternalTitle.Text = "Registrar nuevo producto:";
            // 
            // bRegister
            // 
            this.bRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bRegister.Enabled = false;
            this.bRegister.Location = new System.Drawing.Point(316, 680);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(75, 23);
            this.bRegister.TabIndex = 13;
            this.bRegister.Text = "Registrar";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.RegisterProduct);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.Location = new System.Drawing.Point(397, 680);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 14;
            this.bCancel.Text = "Cancelar";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.CancelRegister);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(148, 149);
            this.nudQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(91, 23);
            this.nudQuantity.TabIndex = 5;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(148, 181);
            this.nudPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(91, 23);
            this.nudPrice.TabIndex = 15;
            this.nudPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ttCursorCod
            // 
            this.ttCursorCod.IsBalloon = true;
            this.ttCursorCod.ToolTipTitle = "TItulo";
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
            // errorCharacter
            // 
            this.errorCharacter.ContainerControl = this;
            this.errorCharacter.Icon = ((System.Drawing.Icon)(resources.GetObject("errorCharacter.Icon")));
            // 
            // ErrEmptyName
            // 
            this.ErrEmptyName.ContainerControl = this;
            this.ErrEmptyName.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrEmptyName.Icon")));
            // 
            // lImage
            // 
            this.lImage.AutoSize = true;
            this.lImage.Location = new System.Drawing.Point(73, 339);
            this.lImage.Name = "lImage";
            this.lImage.Size = new System.Drawing.Size(47, 15);
            this.lImage.TabIndex = 16;
            this.lImage.Text = "Imagen";
            // 
            // pbImage
            // 
            this.pbImage.Image = global::EjercicioProductos.Properties.Resources.placeholderProduct;
            this.pbImage.Location = new System.Drawing.Point(148, 379);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(256, 256);
            this.pbImage.TabIndex = 17;
            this.pbImage.TabStop = false;
            // 
            // dialogImagePicker
            // 
            this.dialogImagePicker.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            this.dialogImagePicker.Title = "Selecciona la imagen";
            // 
            // tbImagePath
            // 
            this.tbImagePath.Location = new System.Drawing.Point(148, 336);
            this.tbImagePath.Name = "tbImagePath";
            this.tbImagePath.Size = new System.Drawing.Size(222, 23);
            this.tbImagePath.TabIndex = 18;
            // 
            // bSelectImage
            // 
            this.bSelectImage.Location = new System.Drawing.Point(376, 336);
            this.bSelectImage.Name = "bSelectImage";
            this.bSelectImage.Size = new System.Drawing.Size(28, 23);
            this.bSelectImage.TabIndex = 19;
            this.bSelectImage.Text = "...";
            this.bSelectImage.UseVisualStyleBackColor = true;
            this.bSelectImage.Click += new System.EventHandler(this.SelectImage);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // ProductRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 715);
            this.Controls.Add(this.bSelectImage);
            this.Controls.Add(this.tbImagePath);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lImage);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bRegister);
            this.Controls.Add(this.lInternalTitle);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.lQuantity);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.IId);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 0);
            this.Name = "ProductRegister";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de nuevo producto";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmptyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNotAvailableId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrEmptyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lName;
        private Label lQuantity;
        private Label lPrice;
        private Label lDescription;
        private Label lType;
        private Button bCancel;
        private ErrorProvider errEmptyId;
        private ErrorProvider errorCharacter;
        private ErrorProvider ErrEmptyName;
        protected Button bRegister;
        protected TextBox tbName;
        protected TextBox tbId;
        protected TextBox tbDescription;
        protected ComboBox cbType;
        protected NumericUpDown nudQuantity;
        protected NumericUpDown nudPrice;
        protected ErrorProvider errNotAvailableId;
        protected Label lInternalTitle;
        protected Label IId;
        protected ToolTip ttCursorCod;
        private Label lImage;
        private OpenFileDialog dialogImagePicker;
        private TextBox tbImagePath;
        protected PictureBox pbImage;
        protected Button bSelectImage;
        protected ErrorProvider errorProvider2;
    }
}