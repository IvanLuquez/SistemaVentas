namespace LayerViews.Inventory
{
    partial class ProductForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            lblNameProduct = new Label();
            txtNameProduct = new TextBox();
            lblMinAmountProduct = new Label();
            txtCodeProduct = new TextBox();
            lblDataCodeProduct = new Label();
            lblDataPriceBuyProduct = new Label();
            numericAmountMintProduct = new NumericUpDown();
            lblAmountProduct = new Label();
            numericAmountProduct = new NumericUpDown();
            lblDescriptionProduct = new Label();
            txtDescriptionProduct = new TextBox();
            lblDateCreateProduct = new Label();
            lblCreateProduct = new Label();
            lblDateUpdateProduct = new Label();
            lblUpdateProduct = new Label();
            gridViewProduct = new DataGridView();
            idProduct = new DataGridViewTextBoxColumn();
            name_product = new DataGridViewTextBoxColumn();
            minAmount = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            date_create = new DataGridViewTextBoxColumn();
            date_update = new DataGridViewTextBoxColumn();
            code = new DataGridViewTextBoxColumn();
            priceBuy = new DataGridViewTextBoxColumn();
            fk_idcategory = new DataGridViewTextBoxColumn();
            fk_idsupplier = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            btnDelete = new DataGridViewButtonColumn();
            lblCategory = new Label();
            lblProveedor = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            numericPriceBuy = new NumericUpDown();
            btnAddProduct = new Button();
            btnUpdateProduct = new Button();
            btnCloseProduct = new Button();
            btnCancelProduct = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericAmountMintProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAmountProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPriceBuy).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 11;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(lblNameProduct, 0, 1);
            tableLayoutPanel1.Controls.Add(txtNameProduct, 0, 2);
            tableLayoutPanel1.Controls.Add(lblMinAmountProduct, 0, 3);
            tableLayoutPanel1.Controls.Add(txtCodeProduct, 2, 2);
            tableLayoutPanel1.Controls.Add(lblDataCodeProduct, 2, 1);
            tableLayoutPanel1.Controls.Add(lblDataPriceBuyProduct, 3, 1);
            tableLayoutPanel1.Controls.Add(numericAmountMintProduct, 0, 4);
            tableLayoutPanel1.Controls.Add(lblAmountProduct, 1, 3);
            tableLayoutPanel1.Controls.Add(numericAmountProduct, 1, 4);
            tableLayoutPanel1.Controls.Add(lblDescriptionProduct, 0, 5);
            tableLayoutPanel1.Controls.Add(txtDescriptionProduct, 0, 6);
            tableLayoutPanel1.Controls.Add(lblDateCreateProduct, 0, 9);
            tableLayoutPanel1.Controls.Add(lblCreateProduct, 0, 10);
            tableLayoutPanel1.Controls.Add(lblDateUpdateProduct, 2, 9);
            tableLayoutPanel1.Controls.Add(lblUpdateProduct, 2, 10);
            tableLayoutPanel1.Controls.Add(gridViewProduct, 5, 2);
            tableLayoutPanel1.Controls.Add(lblCategory, 2, 3);
            tableLayoutPanel1.Controls.Add(lblProveedor, 2, 5);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 4);
            tableLayoutPanel1.Controls.Add(comboBox2, 2, 6);
            tableLayoutPanel1.Controls.Add(numericPriceBuy, 3, 2);
            tableLayoutPanel1.Controls.Add(btnAddProduct, 0, 11);
            tableLayoutPanel1.Controls.Add(btnUpdateProduct, 2, 11);
            tableLayoutPanel1.Controls.Add(btnCloseProduct, 9, 11);
            tableLayoutPanel1.Controls.Add(btnCancelProduct, 4, 11);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 13;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Size = new Size(1225, 412);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 11);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1219, 31);
            label1.TabIndex = 0;
            label1.Text = "GESTION DE PRODUCTOS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNameProduct
            // 
            lblNameProduct.AutoSize = true;
            lblNameProduct.Dock = DockStyle.Bottom;
            lblNameProduct.Location = new Point(3, 47);
            lblNameProduct.Name = "lblNameProduct";
            lblNameProduct.Size = new Size(105, 15);
            lblNameProduct.TabIndex = 1;
            lblNameProduct.Text = "Nombre Producto";
            // 
            // txtNameProduct
            // 
            txtNameProduct.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(txtNameProduct, 2);
            txtNameProduct.Font = new Font("Arial", 12F);
            txtNameProduct.Location = new Point(3, 65);
            txtNameProduct.Name = "txtNameProduct";
            txtNameProduct.Size = new Size(196, 19);
            txtNameProduct.TabIndex = 12;
            // 
            // lblMinAmountProduct
            // 
            lblMinAmountProduct.AutoSize = true;
            lblMinAmountProduct.Dock = DockStyle.Bottom;
            lblMinAmountProduct.Location = new Point(3, 109);
            lblMinAmountProduct.Name = "lblMinAmountProduct";
            lblMinAmountProduct.Size = new Size(105, 15);
            lblMinAmountProduct.TabIndex = 8;
            lblMinAmountProduct.Text = "Cantidad Minima";
            // 
            // txtCodeProduct
            // 
            txtCodeProduct.BorderStyle = BorderStyle.None;
            txtCodeProduct.Font = new Font("Arial", 12F);
            txtCodeProduct.Location = new Point(225, 65);
            txtCodeProduct.Name = "txtCodeProduct";
            txtCodeProduct.Size = new Size(81, 19);
            txtCodeProduct.TabIndex = 21;
            // 
            // lblDataCodeProduct
            // 
            lblDataCodeProduct.AutoSize = true;
            lblDataCodeProduct.Dock = DockStyle.Bottom;
            lblDataCodeProduct.Location = new Point(225, 47);
            lblDataCodeProduct.Name = "lblDataCodeProduct";
            lblDataCodeProduct.Size = new Size(105, 15);
            lblDataCodeProduct.TabIndex = 11;
            lblDataCodeProduct.Text = "Codigo";
            // 
            // lblDataPriceBuyProduct
            // 
            lblDataPriceBuyProduct.AutoSize = true;
            lblDataPriceBuyProduct.Dock = DockStyle.Bottom;
            lblDataPriceBuyProduct.Location = new Point(336, 47);
            lblDataPriceBuyProduct.Name = "lblDataPriceBuyProduct";
            lblDataPriceBuyProduct.Size = new Size(105, 15);
            lblDataPriceBuyProduct.TabIndex = 9;
            lblDataPriceBuyProduct.Text = "Precio de compra";
            // 
            // numericAmountMintProduct
            // 
            numericAmountMintProduct.BorderStyle = BorderStyle.FixedSingle;
            numericAmountMintProduct.Font = new Font("Arial", 12F);
            numericAmountMintProduct.Location = new Point(3, 127);
            numericAmountMintProduct.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericAmountMintProduct.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericAmountMintProduct.Name = "numericAmountMintProduct";
            numericAmountMintProduct.Size = new Size(105, 26);
            numericAmountMintProduct.TabIndex = 23;
            numericAmountMintProduct.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblAmountProduct
            // 
            lblAmountProduct.AutoSize = true;
            lblAmountProduct.Dock = DockStyle.Bottom;
            lblAmountProduct.Location = new Point(114, 109);
            lblAmountProduct.Name = "lblAmountProduct";
            lblAmountProduct.Size = new Size(105, 15);
            lblAmountProduct.TabIndex = 3;
            lblAmountProduct.Text = "Cantidad Actual";
            // 
            // numericAmountProduct
            // 
            numericAmountProduct.BorderStyle = BorderStyle.FixedSingle;
            numericAmountProduct.Font = new Font("Arial", 12F);
            numericAmountProduct.Location = new Point(114, 127);
            numericAmountProduct.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericAmountProduct.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericAmountProduct.Name = "numericAmountProduct";
            numericAmountProduct.Size = new Size(105, 26);
            numericAmountProduct.TabIndex = 22;
            numericAmountProduct.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDescriptionProduct
            // 
            lblDescriptionProduct.AutoSize = true;
            lblDescriptionProduct.Dock = DockStyle.Bottom;
            lblDescriptionProduct.Location = new Point(3, 171);
            lblDescriptionProduct.Name = "lblDescriptionProduct";
            lblDescriptionProduct.Size = new Size(105, 15);
            lblDescriptionProduct.TabIndex = 2;
            lblDescriptionProduct.Text = "Descripcion";
            // 
            // txtDescriptionProduct
            // 
            txtDescriptionProduct.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(txtDescriptionProduct, 2);
            txtDescriptionProduct.Font = new Font("Arial", 12F);
            txtDescriptionProduct.Location = new Point(3, 189);
            txtDescriptionProduct.Multiline = true;
            txtDescriptionProduct.Name = "txtDescriptionProduct";
            tableLayoutPanel1.SetRowSpan(txtDescriptionProduct, 2);
            txtDescriptionProduct.Size = new Size(216, 56);
            txtDescriptionProduct.TabIndex = 14;
            // 
            // lblDateCreateProduct
            // 
            lblDateCreateProduct.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblDateCreateProduct, 2);
            lblDateCreateProduct.Dock = DockStyle.Bottom;
            lblDateCreateProduct.Location = new Point(3, 295);
            lblDateCreateProduct.Name = "lblDateCreateProduct";
            lblDateCreateProduct.Size = new Size(216, 15);
            lblDateCreateProduct.TabIndex = 4;
            lblDateCreateProduct.Text = "Fecha de creacion";
            // 
            // lblCreateProduct
            // 
            lblCreateProduct.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblCreateProduct, 2);
            lblCreateProduct.Font = new Font("Arial", 11.25F);
            lblCreateProduct.Location = new Point(3, 310);
            lblCreateProduct.Name = "lblCreateProduct";
            lblCreateProduct.Size = new Size(46, 17);
            lblCreateProduct.TabIndex = 6;
            lblCreateProduct.Text = "--/--/--";
            // 
            // lblDateUpdateProduct
            // 
            lblDateUpdateProduct.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblDateUpdateProduct, 2);
            lblDateUpdateProduct.Dock = DockStyle.Bottom;
            lblDateUpdateProduct.Location = new Point(225, 295);
            lblDateUpdateProduct.Name = "lblDateUpdateProduct";
            lblDateUpdateProduct.Size = new Size(216, 15);
            lblDateUpdateProduct.TabIndex = 5;
            lblDateUpdateProduct.Text = "Fecha de actualizacion";
            // 
            // lblUpdateProduct
            // 
            lblUpdateProduct.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblUpdateProduct, 2);
            lblUpdateProduct.Font = new Font("Arial", 11.25F);
            lblUpdateProduct.Location = new Point(225, 310);
            lblUpdateProduct.Name = "lblUpdateProduct";
            lblUpdateProduct.Size = new Size(46, 17);
            lblUpdateProduct.TabIndex = 7;
            lblUpdateProduct.Text = "--/--/--";
            // 
            // gridViewProduct
            // 
            gridViewProduct.AllowUserToAddRows = false;
            gridViewProduct.AllowUserToDeleteRows = false;
            gridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProduct.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            gridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProduct.Columns.AddRange(new DataGridViewColumn[] { idProduct, name_product, minAmount, description, date_create, date_update, code, priceBuy, fk_idcategory, fk_idsupplier, amount, btnDelete });
            tableLayoutPanel1.SetColumnSpan(gridViewProduct, 6);
            gridViewProduct.Location = new Point(558, 65);
            gridViewProduct.Name = "gridViewProduct";
            gridViewProduct.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(gridViewProduct, 8);
            gridViewProduct.Size = new Size(664, 242);
            gridViewProduct.TabIndex = 24;
            gridViewProduct.CellClick += gridViewProduct_CellClick;
            // 
            // idProduct
            // 
            idProduct.HeaderText = "id";
            idProduct.Name = "idProduct";
            idProduct.ReadOnly = true;
            idProduct.Visible = false;
            // 
            // name_product
            // 
            name_product.HeaderText = "Nombre";
            name_product.Name = "name_product";
            name_product.ReadOnly = true;
            // 
            // minAmount
            // 
            minAmount.HeaderText = "Cantidad Minima";
            minAmount.Name = "minAmount";
            minAmount.ReadOnly = true;
            // 
            // description
            // 
            description.HeaderText = "Descripcion";
            description.Name = "description";
            description.ReadOnly = true;
            description.Visible = false;
            // 
            // date_create
            // 
            date_create.HeaderText = "Fecha Creado";
            date_create.Name = "date_create";
            date_create.ReadOnly = true;
            date_create.Visible = false;
            // 
            // date_update
            // 
            date_update.HeaderText = "Fecha Actualizado";
            date_update.Name = "date_update";
            date_update.ReadOnly = true;
            date_update.Visible = false;
            // 
            // code
            // 
            code.HeaderText = "Codigo";
            code.Name = "code";
            code.ReadOnly = true;
            // 
            // priceBuy
            // 
            priceBuy.HeaderText = "Precio Comprado";
            priceBuy.Name = "priceBuy";
            priceBuy.ReadOnly = true;
            // 
            // fk_idcategory
            // 
            fk_idcategory.HeaderText = "idcategoria";
            fk_idcategory.Name = "fk_idcategory";
            fk_idcategory.ReadOnly = true;
            fk_idcategory.Visible = false;
            // 
            // fk_idsupplier
            // 
            fk_idsupplier.HeaderText = "idvproveedor";
            fk_idsupplier.Name = "fk_idsupplier";
            fk_idsupplier.ReadOnly = true;
            fk_idsupplier.Visible = false;
            // 
            // amount
            // 
            amount.HeaderText = "Cantidad Disponible";
            amount.Name = "amount";
            amount.ReadOnly = true;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Accion";
            btnDelete.Name = "btnDelete";
            btnDelete.ReadOnly = true;
            btnDelete.Text = "Borrar";
            btnDelete.UseColumnTextForButtonValue = true;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Bottom;
            lblCategory.Location = new Point(225, 109);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(105, 15);
            lblCategory.TabIndex = 26;
            lblCategory.Text = "Categoria";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Dock = DockStyle.Bottom;
            lblProveedor.Location = new Point(225, 171);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(105, 15);
            lblProveedor.TabIndex = 27;
            lblProveedor.Text = "Proveedor";
            // 
            // comboBox1
            // 
            tableLayoutPanel1.SetColumnSpan(comboBox1, 2);
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Arial", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(225, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 26);
            comboBox1.TabIndex = 28;
            // 
            // comboBox2
            // 
            tableLayoutPanel1.SetColumnSpan(comboBox2, 2);
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Arial", 12F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(225, 189);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(216, 26);
            comboBox2.TabIndex = 29;
            // 
            // numericPriceBuy
            // 
            numericPriceBuy.BorderStyle = BorderStyle.None;
            numericPriceBuy.DecimalPlaces = 2;
            numericPriceBuy.Font = new Font("Arial", 12F);
            numericPriceBuy.Location = new Point(336, 65);
            numericPriceBuy.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericPriceBuy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericPriceBuy.Name = "numericPriceBuy";
            numericPriceBuy.Size = new Size(105, 22);
            numericPriceBuy.TabIndex = 30;
            numericPriceBuy.ThousandsSeparator = true;
            numericPriceBuy.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(192, 255, 192);
            tableLayoutPanel1.SetColumnSpan(btnAddProduct, 2);
            btnAddProduct.FlatStyle = FlatStyle.Popup;
            btnAddProduct.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAddProduct.Location = new Point(3, 344);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(168, 25);
            btnAddProduct.TabIndex = 17;
            btnAddProduct.Text = "AGREGAR";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.BackColor = Color.FromArgb(255, 224, 192);
            tableLayoutPanel1.SetColumnSpan(btnUpdateProduct, 2);
            btnUpdateProduct.FlatStyle = FlatStyle.Popup;
            btnUpdateProduct.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnUpdateProduct.Location = new Point(225, 344);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(168, 25);
            btnUpdateProduct.TabIndex = 18;
            btnUpdateProduct.Text = "ACTUALIZAR";
            btnUpdateProduct.UseVisualStyleBackColor = false;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnCloseProduct
            // 
            btnCloseProduct.BackColor = Color.FromArgb(255, 192, 192);
            tableLayoutPanel1.SetColumnSpan(btnCloseProduct, 2);
            btnCloseProduct.FlatStyle = FlatStyle.Popup;
            btnCloseProduct.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnCloseProduct.Location = new Point(1002, 344);
            btnCloseProduct.Name = "btnCloseProduct";
            btnCloseProduct.Size = new Size(168, 25);
            btnCloseProduct.TabIndex = 25;
            btnCloseProduct.Text = "CERRAR";
            btnCloseProduct.UseVisualStyleBackColor = false;
            btnCloseProduct.Click += btnCloseProduct_Click;
            // 
            // btnCancelProduct
            // 
            btnCancelProduct.BackColor = Color.FromArgb(255, 192, 192);
            tableLayoutPanel1.SetColumnSpan(btnCancelProduct, 2);
            btnCancelProduct.FlatStyle = FlatStyle.Popup;
            btnCancelProduct.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnCancelProduct.Location = new Point(447, 344);
            btnCancelProduct.Name = "btnCancelProduct";
            btnCancelProduct.Size = new Size(168, 25);
            btnCancelProduct.TabIndex = 19;
            btnCancelProduct.Text = "CANCELAR";
            btnCancelProduct.UseVisualStyleBackColor = false;
            btnCancelProduct.Click += btnCancelProduct_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1249, 440);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            Load += ProductForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericAmountMintProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericAmountProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPriceBuy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label lblNameProduct;
        private Label lblDescriptionProduct;
        private Label lblAmountProduct;
        private Label lblDateCreateProduct;
        private Label lblDateUpdateProduct;
        private Label lblMinAmountProduct;
        private Label lblDataPriceBuyProduct;
        private Label lblDataCodeProduct;
        private TextBox txtNameProduct;
        private TextBox txtDescriptionProduct;
        private TextBox txtCodeProduct;
        private NumericUpDown numericAmountProduct;
        private NumericUpDown numericAmountMintProduct;
        private DataGridView gridViewProduct;
        private Label lblCreateProduct;
        private Label lblUpdateProduct;
        private Button btnAddProduct;
        private Button btnUpdateProduct;
        private Button btnCancelProduct;
        private Button btnCloseProduct;
        private DataGridViewTextBoxColumn idProduct;
        private DataGridViewTextBoxColumn name_product;
        private DataGridViewTextBoxColumn minAmount;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn date_create;
        private DataGridViewTextBoxColumn date_update;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn priceBuy;
        private DataGridViewTextBoxColumn fk_idcategory;
        private DataGridViewTextBoxColumn fk_idsupplier;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewButtonColumn btnDelete;
        private Label lblCategory;
        private Label lblProveedor;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private NumericUpDown numericPriceBuy;
    }
}