namespace LayerViews.Inventory
{
    partial class SupplierForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitleSupplier = new Label();
            lblNameSupplier = new Label();
            lblNameSocial = new Label();
            lblAddress = new Label();
            lblNumberOneSupplier = new Label();
            lblNumberTwoSupplier = new Label();
            label6 = new Label();
            txtNameSupplier = new TextBox();
            txtNameSocialSupplier = new TextBox();
            txtAddresSupplier = new TextBox();
            txtNumberOneSupplier = new TextBox();
            txtNumberTwoSupplier = new TextBox();
            txtDescriptionSupplier = new TextBox();
            gridViewSupplier = new DataGridView();
            btnAddSupplier = new Button();
            btnUpdateSupplier = new Button();
            btnCancel = new Button();
            btnExitSupplier = new Button();
            errorProviderSupplier = new ErrorProvider(components);
            idSupplier = new DataGridViewTextBoxColumn();
            nameSupplier = new DataGridViewTextBoxColumn();
            nameSocialSupplier = new DataGridViewTextBoxColumn();
            addressSupplier = new DataGridViewTextBoxColumn();
            phoneSupplier = new DataGridViewTextBoxColumn();
            phoneTwoSupplier = new DataGridViewTextBoxColumn();
            descriptionSupplier = new DataGridViewTextBoxColumn();
            actionSupplier = new DataGridViewButtonColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewSupplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSupplier).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(lblTitleSupplier, 0, 0);
            tableLayoutPanel1.Controls.Add(lblNameSupplier, 0, 1);
            tableLayoutPanel1.Controls.Add(lblNameSocial, 0, 3);
            tableLayoutPanel1.Controls.Add(lblAddress, 0, 5);
            tableLayoutPanel1.Controls.Add(lblNumberOneSupplier, 0, 7);
            tableLayoutPanel1.Controls.Add(lblNumberTwoSupplier, 2, 7);
            tableLayoutPanel1.Controls.Add(label6, 0, 9);
            tableLayoutPanel1.Controls.Add(txtNameSupplier, 0, 2);
            tableLayoutPanel1.Controls.Add(txtNameSocialSupplier, 0, 4);
            tableLayoutPanel1.Controls.Add(txtAddresSupplier, 0, 6);
            tableLayoutPanel1.Controls.Add(txtNumberOneSupplier, 0, 8);
            tableLayoutPanel1.Controls.Add(txtNumberTwoSupplier, 2, 8);
            tableLayoutPanel1.Controls.Add(txtDescriptionSupplier, 1, 9);
            tableLayoutPanel1.Controls.Add(gridViewSupplier, 3, 2);
            tableLayoutPanel1.Controls.Add(btnAddSupplier, 4, 7);
            tableLayoutPanel1.Controls.Add(btnUpdateSupplier, 6, 7);
            tableLayoutPanel1.Controls.Add(btnCancel, 8, 7);
            tableLayoutPanel1.Controls.Add(btnExitSupplier, 8, 8);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(863, 364);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitleSupplier
            // 
            lblTitleSupplier.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblTitleSupplier, 10);
            lblTitleSupplier.Dock = DockStyle.Bottom;
            lblTitleSupplier.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleSupplier.Location = new Point(3, 3);
            lblTitleSupplier.Name = "lblTitleSupplier";
            lblTitleSupplier.Size = new Size(857, 33);
            lblTitleSupplier.TabIndex = 0;
            lblTitleSupplier.Text = "GETIONAR PROVEEDORES";
            lblTitleSupplier.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNameSupplier
            // 
            lblNameSupplier.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblNameSupplier, 2);
            lblNameSupplier.Dock = DockStyle.Bottom;
            lblNameSupplier.Location = new Point(3, 57);
            lblNameSupplier.Name = "lblNameSupplier";
            lblNameSupplier.Size = new Size(166, 15);
            lblNameSupplier.TabIndex = 1;
            lblNameSupplier.Text = "Nombre Proveedor";
            // 
            // lblNameSocial
            // 
            lblNameSocial.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblNameSocial, 2);
            lblNameSocial.Dock = DockStyle.Bottom;
            lblNameSocial.Location = new Point(3, 129);
            lblNameSocial.Name = "lblNameSocial";
            lblNameSocial.Size = new Size(166, 15);
            lblNameSocial.TabIndex = 2;
            lblNameSocial.Text = "Nombre Razon Social";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblAddress, 2);
            lblAddress.Dock = DockStyle.Bottom;
            lblAddress.Location = new Point(3, 201);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(166, 15);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Direccion";
            // 
            // lblNumberOneSupplier
            // 
            lblNumberOneSupplier.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblNumberOneSupplier, 2);
            lblNumberOneSupplier.Dock = DockStyle.Bottom;
            lblNumberOneSupplier.Location = new Point(3, 273);
            lblNumberOneSupplier.Name = "lblNumberOneSupplier";
            lblNumberOneSupplier.Size = new Size(166, 15);
            lblNumberOneSupplier.TabIndex = 4;
            lblNumberOneSupplier.Text = "Numero Celular 1";
            // 
            // lblNumberTwoSupplier
            // 
            lblNumberTwoSupplier.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblNumberTwoSupplier, 2);
            lblNumberTwoSupplier.Dock = DockStyle.Bottom;
            lblNumberTwoSupplier.Location = new Point(175, 273);
            lblNumberTwoSupplier.Name = "lblNumberTwoSupplier";
            lblNumberTwoSupplier.Size = new Size(166, 15);
            lblNumberTwoSupplier.TabIndex = 5;
            lblNumberTwoSupplier.Text = "Numero Celular 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 324);
            label6.Name = "label6";
            label6.Size = new Size(80, 40);
            label6.TabIndex = 6;
            label6.Text = "Descripcion ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNameSupplier
            // 
            txtNameSupplier.BorderStyle = BorderStyle.FixedSingle;
            txtNameSupplier.CharacterCasing = CharacterCasing.Upper;
            tableLayoutPanel1.SetColumnSpan(txtNameSupplier, 2);
            txtNameSupplier.Font = new Font("Arial", 12F);
            txtNameSupplier.Location = new Point(3, 75);
            txtNameSupplier.MaxLength = 100;
            txtNameSupplier.Name = "txtNameSupplier";
            txtNameSupplier.Size = new Size(166, 26);
            txtNameSupplier.TabIndex = 7;
            // 
            // txtNameSocialSupplier
            // 
            txtNameSocialSupplier.BorderStyle = BorderStyle.FixedSingle;
            txtNameSocialSupplier.CharacterCasing = CharacterCasing.Upper;
            tableLayoutPanel1.SetColumnSpan(txtNameSocialSupplier, 2);
            txtNameSocialSupplier.Font = new Font("Arial", 12F);
            txtNameSocialSupplier.Location = new Point(3, 147);
            txtNameSocialSupplier.MaxLength = 200;
            txtNameSocialSupplier.Name = "txtNameSocialSupplier";
            txtNameSocialSupplier.Size = new Size(166, 26);
            txtNameSocialSupplier.TabIndex = 8;
            // 
            // txtAddresSupplier
            // 
            txtAddresSupplier.BorderStyle = BorderStyle.FixedSingle;
            txtAddresSupplier.CharacterCasing = CharacterCasing.Upper;
            tableLayoutPanel1.SetColumnSpan(txtAddresSupplier, 2);
            txtAddresSupplier.Font = new Font("Arial", 12F);
            txtAddresSupplier.Location = new Point(3, 219);
            txtAddresSupplier.MaxLength = 100;
            txtAddresSupplier.Name = "txtAddresSupplier";
            txtAddresSupplier.Size = new Size(166, 26);
            txtAddresSupplier.TabIndex = 9;
            // 
            // txtNumberOneSupplier
            // 
            txtNumberOneSupplier.BorderStyle = BorderStyle.FixedSingle;
            txtNumberOneSupplier.CharacterCasing = CharacterCasing.Upper;
            tableLayoutPanel1.SetColumnSpan(txtNumberOneSupplier, 2);
            txtNumberOneSupplier.Font = new Font("Arial", 12F);
            txtNumberOneSupplier.Location = new Point(3, 291);
            txtNumberOneSupplier.MaxLength = 10;
            txtNumberOneSupplier.Name = "txtNumberOneSupplier";
            txtNumberOneSupplier.Size = new Size(134, 26);
            txtNumberOneSupplier.TabIndex = 10;
            // 
            // txtNumberTwoSupplier
            // 
            txtNumberTwoSupplier.BorderStyle = BorderStyle.FixedSingle;
            txtNumberTwoSupplier.CharacterCasing = CharacterCasing.Upper;
            tableLayoutPanel1.SetColumnSpan(txtNumberTwoSupplier, 2);
            txtNumberTwoSupplier.Font = new Font("Arial", 12F);
            txtNumberTwoSupplier.Location = new Point(175, 291);
            txtNumberTwoSupplier.MaxLength = 10;
            txtNumberTwoSupplier.Name = "txtNumberTwoSupplier";
            txtNumberTwoSupplier.Size = new Size(134, 26);
            txtNumberTwoSupplier.TabIndex = 11;
            // 
            // txtDescriptionSupplier
            // 
            txtDescriptionSupplier.BorderStyle = BorderStyle.FixedSingle;
            txtDescriptionSupplier.CharacterCasing = CharacterCasing.Upper;
            tableLayoutPanel1.SetColumnSpan(txtDescriptionSupplier, 3);
            txtDescriptionSupplier.Font = new Font("Arial", 12F);
            txtDescriptionSupplier.Location = new Point(89, 327);
            txtDescriptionSupplier.MaxLength = 200;
            txtDescriptionSupplier.Multiline = true;
            txtDescriptionSupplier.Name = "txtDescriptionSupplier";
            txtDescriptionSupplier.Size = new Size(225, 31);
            txtDescriptionSupplier.TabIndex = 12;
            // 
            // gridViewSupplier
            // 
            gridViewSupplier.AllowUserToAddRows = false;
            gridViewSupplier.AllowUserToDeleteRows = false;
            gridViewSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridViewSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridViewSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewSupplier.Columns.AddRange(new DataGridViewColumn[] { idSupplier, nameSupplier, nameSocialSupplier, addressSupplier, phoneSupplier, phoneTwoSupplier, descriptionSupplier, actionSupplier });
            tableLayoutPanel1.SetColumnSpan(gridViewSupplier, 7);
            gridViewSupplier.Location = new Point(261, 75);
            gridViewSupplier.Name = "gridViewSupplier";
            gridViewSupplier.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(gridViewSupplier, 5);
            gridViewSupplier.Size = new Size(599, 174);
            gridViewSupplier.TabIndex = 13;
            gridViewSupplier.CellClick += gridViewSupplier_CellClick;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.BackColor = Color.Lime;
            tableLayoutPanel1.SetColumnSpan(btnAddSupplier, 2);
            btnAddSupplier.FlatStyle = FlatStyle.Flat;
            btnAddSupplier.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            btnAddSupplier.Location = new Point(347, 255);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(148, 30);
            btnAddSupplier.TabIndex = 14;
            btnAddSupplier.Text = "AGREGAR";
            btnAddSupplier.UseVisualStyleBackColor = false;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // btnUpdateSupplier
            // 
            btnUpdateSupplier.BackColor = Color.FromArgb(255, 192, 128);
            tableLayoutPanel1.SetColumnSpan(btnUpdateSupplier, 2);
            btnUpdateSupplier.FlatStyle = FlatStyle.Flat;
            btnUpdateSupplier.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            btnUpdateSupplier.Location = new Point(519, 255);
            btnUpdateSupplier.Name = "btnUpdateSupplier";
            btnUpdateSupplier.Size = new Size(148, 30);
            btnUpdateSupplier.TabIndex = 15;
            btnUpdateSupplier.Text = "ACTUALIZAR";
            btnUpdateSupplier.UseVisualStyleBackColor = false;
            btnUpdateSupplier.Click += btnUpdateSupplier_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 192, 192);
            tableLayoutPanel1.SetColumnSpan(btnCancel, 2);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            btnCancel.Location = new Point(691, 255);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(148, 30);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExitSupplier
            // 
            btnExitSupplier.BackColor = Color.Red;
            tableLayoutPanel1.SetColumnSpan(btnExitSupplier, 2);
            btnExitSupplier.FlatStyle = FlatStyle.Flat;
            btnExitSupplier.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            btnExitSupplier.Location = new Point(691, 291);
            btnExitSupplier.Name = "btnExitSupplier";
            btnExitSupplier.Size = new Size(148, 30);
            btnExitSupplier.TabIndex = 17;
            btnExitSupplier.Text = "CERRAR";
            btnExitSupplier.UseVisualStyleBackColor = false;
            btnExitSupplier.Click += btnExitSupplier_Click;
            // 
            // errorProviderSupplier
            // 
            errorProviderSupplier.ContainerControl = this;
            // 
            // idSupplier
            // 
            idSupplier.HeaderText = "id";
            idSupplier.Name = "idSupplier";
            idSupplier.ReadOnly = true;
            idSupplier.Visible = false;
            idSupplier.Width = 50;
            // 
            // nameSupplier
            // 
            nameSupplier.HeaderText = "Nombre";
            nameSupplier.Name = "nameSupplier";
            nameSupplier.ReadOnly = true;
            nameSupplier.Width = 98;
            // 
            // nameSocialSupplier
            // 
            nameSocialSupplier.HeaderText = "Compañia";
            nameSocialSupplier.Name = "nameSocialSupplier";
            nameSocialSupplier.ReadOnly = true;
            nameSocialSupplier.Width = 113;
            // 
            // addressSupplier
            // 
            addressSupplier.HeaderText = "Direccion";
            addressSupplier.Name = "addressSupplier";
            addressSupplier.ReadOnly = true;
            addressSupplier.Width = 108;
            // 
            // phoneSupplier
            // 
            phoneSupplier.HeaderText = "Celular Uno";
            phoneSupplier.Name = "phoneSupplier";
            phoneSupplier.ReadOnly = true;
            phoneSupplier.Width = 125;
            // 
            // phoneTwoSupplier
            // 
            phoneTwoSupplier.HeaderText = "Celular Dos";
            phoneTwoSupplier.Name = "phoneTwoSupplier";
            phoneTwoSupplier.ReadOnly = true;
            phoneTwoSupplier.Width = 122;
            // 
            // descriptionSupplier
            // 
            descriptionSupplier.HeaderText = "Descripcion";
            descriptionSupplier.Name = "descriptionSupplier";
            descriptionSupplier.ReadOnly = true;
            descriptionSupplier.Width = 125;
            // 
            // actionSupplier
            // 
            actionSupplier.FlatStyle = FlatStyle.Flat;
            actionSupplier.HeaderText = "Accion";
            actionSupplier.Name = "actionSupplier";
            actionSupplier.ReadOnly = true;
            actionSupplier.Resizable = DataGridViewTriState.True;
            actionSupplier.SortMode = DataGridViewColumnSortMode.Automatic;
            actionSupplier.Text = "Borrar";
            actionSupplier.UseColumnTextForButtonValue = true;
            actionSupplier.Width = 87;
            // 
            // SupplierForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(887, 388);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SupplierForm";
            Text = "Gestion de proveedor";
            Load += SupplierForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewSupplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSupplier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitleSupplier;
        private Label lblNameSupplier;
        private Label lblNameSocial;
        private Label lblAddress;
        private Label lblNumberOneSupplier;
        private Label lblNumberTwoSupplier;
        private Label label6;
        private TextBox txtNameSupplier;
        private TextBox txtNameSocialSupplier;
        private TextBox txtAddresSupplier;
        private TextBox txtNumberOneSupplier;
        private TextBox txtNumberTwoSupplier;
        private TextBox txtDescriptionSupplier;
        private Button btnAddSupplier;
        private Button btnUpdateSupplier;
        private DataGridView gridViewSupplier;
        private Button btnCancel;
        private Button btnExitSupplier;
        private ErrorProvider errorProviderSupplier;
        private DataGridViewTextBoxColumn idSupplier;
        private DataGridViewTextBoxColumn nameSupplier;
        private DataGridViewTextBoxColumn nameSocialSupplier;
        private DataGridViewTextBoxColumn addressSupplier;
        private DataGridViewTextBoxColumn phoneSupplier;
        private DataGridViewTextBoxColumn phoneTwoSupplier;
        private DataGridViewTextBoxColumn descriptionSupplier;
        private DataGridViewButtonColumn actionSupplier;
    }
}