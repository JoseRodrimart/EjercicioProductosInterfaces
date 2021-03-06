namespace EjercicioProductos.view
{
    partial class ProductManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManager));
            this.dgProductsGrid = new System.Windows.Forms.DataGridView();
            this.SelectCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topStrip = new System.Windows.Forms.ToolStrip();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tbsExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCreateProduct = new System.Windows.Forms.ToolStripButton();
            this.tsbEditProducts = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveProducts = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.tscbOrderDirection = new System.Windows.Forms.ToolStripComboBox();
            this.tscbOrderField = new System.Windows.Forms.ToolStripComboBox();
            this.tslOrdenar = new System.Windows.Forms.ToolStripLabel();
            this.dExport = new System.Windows.Forms.SaveFileDialog();
            this.dImport = new System.Windows.Forms.OpenFileDialog();
            this.tsFilters = new System.Windows.Forms.ToolStrip();
            this.lFilter = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.lCode = new System.Windows.Forms.ToolStripLabel();
            this.tbCodeFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lNameFilter = new System.Windows.Forms.ToolStripLabel();
            this.tbNameFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lQuantityFilter = new System.Windows.Forms.ToolStripLabel();
            this.tbQuantityFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lPriceFilter = new System.Windows.Forms.ToolStripLabel();
            this.tbPriceFIlter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.lTypeFilter = new System.Windows.Forms.ToolStripLabel();
            this.cbTypeFilter = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClearFilters = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductsGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.topStrip.SuspendLayout();
            this.tsFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgProductsGrid
            // 
            this.dgProductsGrid.AllowUserToAddRows = false;
            this.dgProductsGrid.AllowUserToDeleteRows = false;
            this.dgProductsGrid.AllowUserToOrderColumns = true;
            this.dgProductsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProductsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProductsGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgProductsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProductsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectCheckBox,
            this.Id,
            this.Nombre,
            this.Cantidad,
            this.Precio,
            this.Descripcion,
            this.Tipo,
            this.Imagen,
            this.EditButton,
            this.DeleteButton});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProductsGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgProductsGrid.Location = new System.Drawing.Point(0, 52);
            this.dgProductsGrid.Name = "dgProductsGrid";
            this.dgProductsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgProductsGrid.RowHeadersVisible = false;
            this.dgProductsGrid.RowTemplate.Height = 50;
            this.dgProductsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductsGrid.Size = new System.Drawing.Size(1005, 542);
            this.dgProductsGrid.TabIndex = 1;
            this.dgProductsGrid.TabStop = false;
            this.dgProductsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HandleDataGridCellClick);
            // 
            // SelectCheckBox
            // 
            this.SelectCheckBox.FillWeight = 20F;
            this.SelectCheckBox.HeaderText = "";
            this.SelectCheckBox.Name = "SelectCheckBox";
            this.SelectCheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SelectCheckBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Name";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Quantity";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Price";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Description";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Type";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Imagen
            // 
            this.Imagen.DataPropertyName = "Image";
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EditButton
            // 
            this.EditButton.FillWeight = 20F;
            this.EditButton.HeaderText = "";
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.Name = "EditButton";
            this.EditButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DeleteButton
            // 
            this.DeleteButton.FillWeight = 20F;
            this.DeleteButton.HeaderText = "";
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteButton.ToolTipText = "eliminar producto";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.fileToolStripMenuItem.Text = "Archivo";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("importToolStripMenuItem.Image")));
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.importToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.OpenImportDialog);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportToolStripMenuItem.Image")));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.OpenExportDialog);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editToolStripMenuItem.Text = "Editar";
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("insertarToolStripMenuItem.Image")));
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertarToolStripMenuItem.Text = "Insertar";
            this.insertarToolStripMenuItem.Click += new System.EventHandler(this.RegisterProduct);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.DeleteSelectedItems);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripMenuItem.Image")));
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.EditSelectedProducts);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("informaciónToolStripMenuItem.Image")));
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informaciónToolStripMenuItem.Text = "Información";
            this.informaciónToolStripMenuItem.Click += new System.EventHandler(this.OpenAboutForm);
            // 
            // topStrip
            // 
            this.topStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.topStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbImport,
            this.tbsExport,
            this.toolStripSeparator1,
            this.tsbCreateProduct,
            this.tsbEditProducts,
            this.tsbRemoveProducts,
            this.toolStripSeparator7,
            this.tsbAbout,
            this.tscbOrderDirection,
            this.tscbOrderField,
            this.tslOrdenar});
            this.topStrip.Location = new System.Drawing.Point(0, 24);
            this.topStrip.Name = "topStrip";
            this.topStrip.Padding = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.topStrip.Size = new System.Drawing.Size(1005, 25);
            this.topStrip.TabIndex = 0;
            this.topStrip.TabStop = true;
            this.topStrip.Text = "toolStrip1";
            // 
            // tsbImport
            // 
            this.tsbImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImport.Image = ((System.Drawing.Image)(resources.GetObject("tsbImport.Image")));
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(23, 22);
            this.tsbImport.Text = "Importar";
            this.tsbImport.Click += new System.EventHandler(this.OpenImportDialog);
            // 
            // tbsExport
            // 
            this.tbsExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsExport.Image = ((System.Drawing.Image)(resources.GetObject("tbsExport.Image")));
            this.tbsExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsExport.Name = "tbsExport";
            this.tbsExport.Size = new System.Drawing.Size(23, 22);
            this.tbsExport.Text = "Exportar";
            this.tbsExport.Click += new System.EventHandler(this.OpenExportDialog);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCreateProduct
            // 
            this.tsbCreateProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCreateProduct.Image = ((System.Drawing.Image)(resources.GetObject("tsbCreateProduct.Image")));
            this.tsbCreateProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCreateProduct.Name = "tsbCreateProduct";
            this.tsbCreateProduct.Size = new System.Drawing.Size(23, 22);
            this.tsbCreateProduct.Tag = "Crear";
            this.tsbCreateProduct.Text = "Producto nuevo";
            this.tsbCreateProduct.Click += new System.EventHandler(this.RegisterProduct);
            // 
            // tsbEditProducts
            // 
            this.tsbEditProducts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditProducts.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditProducts.Image")));
            this.tsbEditProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditProducts.Name = "tsbEditProducts";
            this.tsbEditProducts.Size = new System.Drawing.Size(23, 22);
            this.tsbEditProducts.Text = "Editar";
            this.tsbEditProducts.Click += new System.EventHandler(this.EditSelectedProducts);
            // 
            // tsbRemoveProducts
            // 
            this.tsbRemoveProducts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveProducts.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveProducts.Image")));
            this.tsbRemoveProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveProducts.Name = "tsbRemoveProducts";
            this.tsbRemoveProducts.Size = new System.Drawing.Size(23, 22);
            this.tsbRemoveProducts.Text = "Eliminar productos";
            this.tsbRemoveProducts.Click += new System.EventHandler(this.DeleteSelectedItems);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAbout
            // 
            this.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbout.Image")));
            this.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbout.Name = "tsbAbout";
            this.tsbAbout.Size = new System.Drawing.Size(23, 22);
            this.tsbAbout.Text = "Información";
            this.tsbAbout.Click += new System.EventHandler(this.OpenAboutForm);
            // 
            // tscbOrderDirection
            // 
            this.tscbOrderDirection.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscbOrderDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbOrderDirection.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tscbOrderDirection.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.tscbOrderDirection.Name = "tscbOrderDirection";
            this.tscbOrderDirection.Size = new System.Drawing.Size(121, 25);
            this.tscbOrderDirection.SelectedIndexChanged += new System.EventHandler(this.SetOrderingRules);
            // 
            // tscbOrderField
            // 
            this.tscbOrderField.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscbOrderField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbOrderField.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tscbOrderField.Items.AddRange(new object[] {
            "Id",
            "Nombre",
            "Cantidad",
            "Precio",
            "Descripción",
            "Tipo"});
            this.tscbOrderField.Name = "tscbOrderField";
            this.tscbOrderField.Size = new System.Drawing.Size(121, 25);
            this.tscbOrderField.SelectedIndexChanged += new System.EventHandler(this.SetOrderingRules);
            // 
            // tslOrdenar
            // 
            this.tslOrdenar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslOrdenar.Name = "tslOrdenar";
            this.tslOrdenar.Size = new System.Drawing.Size(74, 22);
            this.tslOrdenar.Text = "Ordenar por:";
            // 
            // dExport
            // 
            this.dExport.Filter = "Fichero CSV | *.csv";
            this.dExport.Title = "Exportar productos";
            // 
            // dImport
            // 
            this.dImport.FileName = "productos";
            this.dImport.Filter = "Fichero CSV | *.csv";
            this.dImport.Title = "Importar productos";
            // 
            // tsFilters
            // 
            this.tsFilters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsFilters.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsFilters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lFilter,
            this.toolStripSeparator6,
            this.lCode,
            this.tbCodeFilter,
            this.toolStripSeparator2,
            this.lNameFilter,
            this.tbNameFilter,
            this.toolStripSeparator3,
            this.lQuantityFilter,
            this.tbQuantityFilter,
            this.toolStripSeparator4,
            this.lPriceFilter,
            this.tbPriceFIlter,
            this.toolStripSeparator5,
            this.lTypeFilter,
            this.cbTypeFilter,
            this.toolStripSeparator8,
            this.tsbClearFilters});
            this.tsFilters.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsFilters.Location = new System.Drawing.Point(0, 597);
            this.tsFilters.Name = "tsFilters";
            this.tsFilters.Padding = new System.Windows.Forms.Padding(10, 5, 1, 5);
            this.tsFilters.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsFilters.Size = new System.Drawing.Size(1005, 33);
            this.tsFilters.TabIndex = 2;
            this.tsFilters.TabStop = true;
            this.tsFilters.Text = "toolStrip2";
            // 
            // lFilter
            // 
            this.lFilter.Name = "lFilter";
            this.lFilter.Size = new System.Drawing.Size(107, 20);
            this.lFilter.Text = "Filtros de producto";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
            // 
            // lCode
            // 
            this.lCode.Name = "lCode";
            this.lCode.Size = new System.Drawing.Size(46, 20);
            this.lCode.Text = "Código";
            // 
            // tbCodeFilter
            // 
            this.tbCodeFilter.Name = "tbCodeFilter";
            this.tbCodeFilter.Size = new System.Drawing.Size(100, 23);
            this.tbCodeFilter.Tag = "Id";
            this.tbCodeFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FilterModified);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // lNameFilter
            // 
            this.lNameFilter.Name = "lNameFilter";
            this.lNameFilter.Size = new System.Drawing.Size(57, 20);
            this.lNameFilter.Text = "Nombre: ";
            // 
            // tbNameFilter
            // 
            this.tbNameFilter.Name = "tbNameFilter";
            this.tbNameFilter.Size = new System.Drawing.Size(100, 23);
            this.tbNameFilter.Tag = "Name";
            this.tbNameFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FilterModified);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // lQuantityFilter
            // 
            this.lQuantityFilter.Name = "lQuantityFilter";
            this.lQuantityFilter.Size = new System.Drawing.Size(55, 20);
            this.lQuantityFilter.Text = "Cantidad";
            // 
            // tbQuantityFilter
            // 
            this.tbQuantityFilter.Name = "tbQuantityFilter";
            this.tbQuantityFilter.Size = new System.Drawing.Size(100, 23);
            this.tbQuantityFilter.Tag = "Quantity";
            this.tbQuantityFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantityFilter_KeyPress);
            this.tbQuantityFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FilterModified);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // lPriceFilter
            // 
            this.lPriceFilter.Name = "lPriceFilter";
            this.lPriceFilter.Size = new System.Drawing.Size(40, 20);
            this.lPriceFilter.Text = "Precio";
            // 
            // tbPriceFIlter
            // 
            this.tbPriceFIlter.Name = "tbPriceFIlter";
            this.tbPriceFIlter.Size = new System.Drawing.Size(100, 23);
            this.tbPriceFIlter.Tag = "Price";
            this.tbPriceFIlter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPriceFIlter_KeyPress);
            this.tbPriceFIlter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FilterModified);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // lTypeFilter
            // 
            this.lTypeFilter.Name = "lTypeFilter";
            this.lTypeFilter.Size = new System.Drawing.Size(30, 20);
            this.lTypeFilter.Text = "Tipo";
            // 
            // cbTypeFilter
            // 
            this.cbTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeFilter.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbTypeFilter.Items.AddRange(new object[] {
            "",
            "CPU",
            "MotherBoard",
            "RAM",
            "GPU",
            "PSU",
            "HDD"});
            this.cbTypeFilter.Name = "cbTypeFilter";
            this.cbTypeFilter.Size = new System.Drawing.Size(100, 23);
            this.cbTypeFilter.SelectedIndexChanged += new System.EventHandler(this.TypeFilterModified);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbClearFilters
            // 
            this.tsbClearFilters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClearFilters.Image = ((System.Drawing.Image)(resources.GetObject("tsbClearFilters.Image")));
            this.tsbClearFilters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearFilters.Name = "tsbClearFilters";
            this.tsbClearFilters.Size = new System.Drawing.Size(23, 20);
            this.tsbClearFilters.Text = "Limpiar filtros";
            this.tsbClearFilters.Click += new System.EventHandler(this.RemoveFilters);
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 630);
            this.Controls.Add(this.tsFilters);
            this.Controls.Add(this.topStrip);
            this.Controls.Add(this.dgProductsGrid);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Product Manager 0.1";
            this.Shown += new System.EventHandler(this.ProductManagerShownEvent);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductsGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.topStrip.ResumeLayout(false);
            this.topStrip.PerformLayout();
            this.tsFilters.ResumeLayout(false);
            this.tsFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgProductsGrid;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem insertarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStrip topStrip;
        private ToolStripButton tsbCreateProduct;
        private ToolStripButton tsbEditProducts;
        private ToolStripButton tsbRemoveProducts;
        private SaveFileDialog dExport;
        private OpenFileDialog dImport;
        private ToolStrip tsFilters;
        private ToolStripLabel lFilter;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel lNameFilter;
        private ToolStripTextBox tbNameFilter;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel lQuantityFilter;
        private ToolStripTextBox tbQuantityFilter;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripLabel lPriceFilter;
        private ToolStripTextBox tbPriceFIlter;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripLabel lTypeFilter;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripLabel lCode;
        private ToolStripTextBox tbCodeFilter;
        private ToolStripButton tbsExport;
        private ToolStripButton tsbImport;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbAbout;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton tsbClearFilters;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem informaciónToolStripMenuItem;
        private ToolStripComboBox cbTypeFilter;
        private ToolStripComboBox tscbOrderDirection;
        private ToolStripComboBox tscbOrderField;
        private ToolStripLabel tslOrdenar;
        private DataGridViewCheckBoxColumn SelectCheckBox;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewImageColumn Imagen;
        private DataGridViewImageColumn EditButton;
        private DataGridViewImageColumn DeleteButton;
    }
}