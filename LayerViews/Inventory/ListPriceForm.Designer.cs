namespace LayerViews.Inventory
{
    partial class ListPriceForm
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbldateUpdatePriceList = new Label();
            lblDateCreatePriceList = new Label();
            btnAgregarPrice = new Button();
            BtnActualizar = new Button();
            gridViewListPrice = new DataGridView();
            idlistprice = new DataGridViewTextBoxColumn();
            name_list = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            active = new DataGridViewCheckBoxColumn();
            date_create = new DataGridViewTextBoxColumn();
            date_update = new DataGridViewTextBoxColumn();
            actionPrice = new DataGridViewButtonColumn();
            txtDescriptionListPrice = new TextBox();
            groupBoxActiveList = new GroupBox();
            radioButtonInActivo = new RadioButton();
            radioButtonActivo = new RadioButton();
            btnClose = new Button();
            txtNameListPrice = new TextBox();
            btnCancel = new Button();
            errorProviderListPrice = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewListPrice).BeginInit();
            groupBoxActiveList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderListPrice).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.0154877F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.808984F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.0671139F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.0154877F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.0154877F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.0154877F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.0154877F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.0154877F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.0154877F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.0154877F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 7);
            tableLayoutPanel1.Controls.Add(label6, 3, 7);
            tableLayoutPanel1.Controls.Add(lbldateUpdatePriceList, 3, 8);
            tableLayoutPanel1.Controls.Add(lblDateCreatePriceList, 0, 8);
            tableLayoutPanel1.Controls.Add(btnAgregarPrice, 0, 9);
            tableLayoutPanel1.Controls.Add(BtnActualizar, 2, 9);
            tableLayoutPanel1.Controls.Add(gridViewListPrice, 3, 2);
            tableLayoutPanel1.Controls.Add(txtDescriptionListPrice, 0, 4);
            tableLayoutPanel1.Controls.Add(groupBoxActiveList, 0, 5);
            tableLayoutPanel1.Controls.Add(btnClose, 8, 7);
            tableLayoutPanel1.Controls.Add(txtNameListPrice, 0, 2);
            tableLayoutPanel1.Controls.Add(btnCancel, 4, 9);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.281407F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.3165827F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.8090448F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.78894472F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(776, 454);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 10);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(770, 45);
            label1.TabIndex = 0;
            label1.Text = "GESTIONAR LISTAS DE PRECIOS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label2, 2);
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 72);
            label2.Name = "label2";
            label2.Size = new Size(147, 18);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label3, 2);
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 145);
            label3.Name = "label3";
            label3.Size = new Size(147, 18);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label5, 2);
            label5.Dock = DockStyle.Bottom;
            label5.Font = new Font("Arial", 11.25F);
            label5.Location = new Point(3, 340);
            label5.Name = "label5";
            label5.Size = new Size(147, 17);
            label5.TabIndex = 4;
            label5.Text = "Fecha de creacion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label6, 3);
            label6.Dock = DockStyle.Bottom;
            label6.Font = new Font("Arial", 11.25F);
            label6.Location = new Point(234, 340);
            label6.Name = "label6";
            label6.Size = new Size(225, 17);
            label6.TabIndex = 5;
            label6.Text = "Fecha Ultima Actualizacion";
            // 
            // lbldateUpdatePriceList
            // 
            lbldateUpdatePriceList.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lbldateUpdatePriceList, 3);
            lbldateUpdatePriceList.Font = new Font("Arial", 9.75F);
            lbldateUpdatePriceList.Location = new Point(234, 357);
            lbldateUpdatePriceList.Name = "lbldateUpdatePriceList";
            lbldateUpdatePriceList.Size = new Size(39, 16);
            lbldateUpdatePriceList.TabIndex = 6;
            lbldateUpdatePriceList.Text = "--/--/--";
            // 
            // lblDateCreatePriceList
            // 
            lblDateCreatePriceList.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblDateCreatePriceList, 3);
            lblDateCreatePriceList.Font = new Font("Arial", 9.75F);
            lblDateCreatePriceList.Location = new Point(3, 357);
            lblDateCreatePriceList.Name = "lblDateCreatePriceList";
            lblDateCreatePriceList.Size = new Size(39, 16);
            lblDateCreatePriceList.TabIndex = 7;
            lblDateCreatePriceList.Text = "--/--/--";
            // 
            // btnAgregarPrice
            // 
            btnAgregarPrice.BackColor = Color.FromArgb(192, 255, 192);
            tableLayoutPanel1.SetColumnSpan(btnAgregarPrice, 2);
            btnAgregarPrice.Dock = DockStyle.Fill;
            btnAgregarPrice.FlatAppearance.BorderColor = Color.White;
            btnAgregarPrice.FlatAppearance.BorderSize = 0;
            btnAgregarPrice.FlatStyle = FlatStyle.Flat;
            btnAgregarPrice.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnAgregarPrice.Location = new Point(3, 405);
            btnAgregarPrice.Name = "btnAgregarPrice";
            btnAgregarPrice.Size = new Size(147, 46);
            btnAgregarPrice.TabIndex = 8;
            btnAgregarPrice.Text = "AGREGAR";
            btnAgregarPrice.UseVisualStyleBackColor = false;
            btnAgregarPrice.Click += btnAgregarPrice_Click;
            // 
            // BtnActualizar
            // 
            BtnActualizar.BackColor = Color.FromArgb(255, 224, 192);
            tableLayoutPanel1.SetColumnSpan(BtnActualizar, 2);
            BtnActualizar.Dock = DockStyle.Fill;
            BtnActualizar.FlatAppearance.BorderColor = Color.White;
            BtnActualizar.FlatAppearance.BorderSize = 0;
            BtnActualizar.FlatStyle = FlatStyle.Flat;
            BtnActualizar.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            BtnActualizar.Location = new Point(156, 405);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(149, 46);
            BtnActualizar.TabIndex = 9;
            BtnActualizar.Text = "ACTUALIZAR";
            BtnActualizar.UseVisualStyleBackColor = false;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // gridViewListPrice
            // 
            gridViewListPrice.AllowUserToAddRows = false;
            gridViewListPrice.AllowUserToDeleteRows = false;
            gridViewListPrice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewListPrice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewListPrice.Columns.AddRange(new DataGridViewColumn[] { idlistprice, name_list, description, active, date_create, date_update, actionPrice });
            tableLayoutPanel1.SetColumnSpan(gridViewListPrice, 7);
            gridViewListPrice.Location = new Point(234, 93);
            gridViewListPrice.MultiSelect = false;
            gridViewListPrice.Name = "gridViewListPrice";
            gridViewListPrice.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(gridViewListPrice, 5);
            gridViewListPrice.Size = new Size(539, 226);
            gridViewListPrice.TabIndex = 12;
            gridViewListPrice.CellClick += gridViewListPrice_CellClick;
            // 
            // idlistprice
            // 
            idlistprice.HeaderText = "id";
            idlistprice.Name = "idlistprice";
            idlistprice.ReadOnly = true;
            idlistprice.Visible = false;
            // 
            // name_list
            // 
            name_list.HeaderText = "Nombre";
            name_list.Name = "name_list";
            name_list.ReadOnly = true;
            // 
            // description
            // 
            description.HeaderText = "Descripcion";
            description.Name = "description";
            description.ReadOnly = true;
            description.Visible = false;
            // 
            // active
            // 
            active.HeaderText = "Activo";
            active.Name = "active";
            active.ReadOnly = true;
            active.Resizable = DataGridViewTriState.True;
            active.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // date_create
            // 
            date_create.HeaderText = "Fecha Creacion";
            date_create.Name = "date_create";
            date_create.ReadOnly = true;
            // 
            // date_update
            // 
            date_update.HeaderText = "Fecha Actualizacion";
            date_update.Name = "date_update";
            date_update.ReadOnly = true;
            // 
            // actionPrice
            // 
            actionPrice.HeaderText = "Accion";
            actionPrice.Name = "actionPrice";
            actionPrice.ReadOnly = true;
            actionPrice.Text = "Borrar";
            actionPrice.ToolTipText = "Borrar registro de la base de datos.";
            actionPrice.UseColumnTextForButtonValue = true;
            // 
            // txtDescriptionListPrice
            // 
            txtDescriptionListPrice.CharacterCasing = CharacterCasing.Upper;
            tableLayoutPanel1.SetColumnSpan(txtDescriptionListPrice, 3);
            txtDescriptionListPrice.Font = new Font("Arial", 12F);
            txtDescriptionListPrice.Location = new Point(3, 166);
            txtDescriptionListPrice.Multiline = true;
            txtDescriptionListPrice.Name = "txtDescriptionListPrice";
            txtDescriptionListPrice.Size = new Size(205, 54);
            txtDescriptionListPrice.TabIndex = 14;
            // 
            // groupBoxActiveList
            // 
            tableLayoutPanel1.SetColumnSpan(groupBoxActiveList, 3);
            groupBoxActiveList.Controls.Add(radioButtonInActivo);
            groupBoxActiveList.Controls.Add(radioButtonActivo);
            groupBoxActiveList.Dock = DockStyle.Fill;
            groupBoxActiveList.FlatStyle = FlatStyle.Flat;
            groupBoxActiveList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxActiveList.Location = new Point(3, 226);
            groupBoxActiveList.Name = "groupBoxActiveList";
            tableLayoutPanel1.SetRowSpan(groupBoxActiveList, 2);
            groupBoxActiveList.Size = new Size(225, 93);
            groupBoxActiveList.TabIndex = 15;
            groupBoxActiveList.TabStop = false;
            groupBoxActiveList.Text = "Estado lista de precio";
            // 
            // radioButtonInActivo
            // 
            radioButtonInActivo.AutoSize = true;
            radioButtonInActivo.Location = new Point(6, 47);
            radioButtonInActivo.Name = "radioButtonInActivo";
            radioButtonInActivo.Size = new Size(82, 25);
            radioButtonInActivo.TabIndex = 1;
            radioButtonInActivo.Text = "Inactivo";
            radioButtonInActivo.UseVisualStyleBackColor = true;
            // 
            // radioButtonActivo
            // 
            radioButtonActivo.AutoSize = true;
            radioButtonActivo.Checked = true;
            radioButtonActivo.Location = new Point(6, 22);
            radioButtonActivo.Name = "radioButtonActivo";
            radioButtonActivo.Size = new Size(71, 25);
            radioButtonActivo.TabIndex = 0;
            radioButtonActivo.TabStop = true;
            radioButtonActivo.Text = "Activo";
            radioButtonActivo.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            tableLayoutPanel1.SetColumnSpan(btnClose, 2);
            btnClose.Dock = DockStyle.Fill;
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnClose.Location = new Point(619, 325);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(154, 29);
            btnClose.TabIndex = 11;
            btnClose.Text = "CERRAR";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtNameListPrice
            // 
            txtNameListPrice.CharacterCasing = CharacterCasing.Upper;
            tableLayoutPanel1.SetColumnSpan(txtNameListPrice, 2);
            txtNameListPrice.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameListPrice.Location = new Point(3, 93);
            txtNameListPrice.Name = "txtNameListPrice";
            txtNameListPrice.Size = new Size(147, 26);
            txtNameListPrice.TabIndex = 17;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 192, 192);
            tableLayoutPanel1.SetColumnSpan(btnCancel, 2);
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.FlatAppearance.BorderColor = Color.White;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnCancel.Location = new Point(311, 405);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(148, 46);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProviderListPrice
            // 
            errorProviderListPrice.ContainerControl = this;
            // 
            // ListPriceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(800, 478);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListPriceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListPriceForm";
            Load += ListPriceForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewListPrice).EndInit();
            groupBoxActiveList.ResumeLayout(false);
            groupBoxActiveList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderListPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label lbldateUpdatePriceList;
        private Label lblDateCreatePriceList;
        private Button btnAgregarPrice;
        private Button BtnActualizar;
        private Button btnCancel;
        private Button btnClose;
        private DataGridView gridViewListPrice;
        private TextBox textBox1;
        private TextBox txtDescriptionListPrice;
        private GroupBox groupBoxActiveList;
        private RadioButton radioButtonInActivo;
        private RadioButton radioButtonActivo;
        private TextBox txtNameListPrice;
        private ErrorProvider errorProviderListPrice;
        private DataGridViewTextBoxColumn idlistprice;
        private DataGridViewTextBoxColumn name_list;
        private DataGridViewTextBoxColumn description;
        private DataGridViewCheckBoxColumn active;
        private DataGridViewTextBoxColumn date_create;
        private DataGridViewTextBoxColumn date_update;
        private DataGridViewButtonColumn actionPrice;
    }
}