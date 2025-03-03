namespace SistemaVentas.Inventory
{
    partial class CategoryForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelCategory = new Panel();
            lblTitleCategory = new Label();
            lblNombre = new Label();
            lblDescriptionCategory = new Label();
            lblDateInitCategory = new Label();
            lblDateUpdateCategory = new Label();
            lblDataInitCategory = new Label();
            btnAgregar = new Button();
            txtNameCategory = new TextBox();
            txtDescriptionCategory = new TextBox();
            btnUpdate = new Button();
            btnCancel = new Button();
            lblDataFinishCategory = new Label();
            gridViewCategory = new DataGridView();
            idCategory = new DataGridViewTextBoxColumn();
            nameCategory = new DataGridViewTextBoxColumn();
            descriptionCategory = new DataGridViewTextBoxColumn();
            dateCreateCategory = new DataGridViewTextBoxColumn();
            dateUpdateCategory = new DataGridViewTextBoxColumn();
            actionCategory = new DataGridViewButtonColumn();
            errorProviderCategory = new ErrorProvider(components);
            btnClose = new Button();
            tableLayoutPanel1.SuspendLayout();
            panelCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCategory).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 11;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.Controls.Add(panelCategory, 0, 0);
            tableLayoutPanel1.Controls.Add(lblNombre, 0, 1);
            tableLayoutPanel1.Controls.Add(lblDescriptionCategory, 0, 3);
            tableLayoutPanel1.Controls.Add(lblDateInitCategory, 0, 5);
            tableLayoutPanel1.Controls.Add(lblDateUpdateCategory, 3, 5);
            tableLayoutPanel1.Controls.Add(lblDataInitCategory, 0, 6);
            tableLayoutPanel1.Controls.Add(btnAgregar, 0, 8);
            tableLayoutPanel1.Controls.Add(txtNameCategory, 0, 2);
            tableLayoutPanel1.Controls.Add(txtDescriptionCategory, 0, 4);
            tableLayoutPanel1.Controls.Add(btnUpdate, 2, 8);
            tableLayoutPanel1.Controls.Add(btnCancel, 4, 8);
            tableLayoutPanel1.Controls.Add(lblDataFinishCategory, 3, 6);
            tableLayoutPanel1.Controls.Add(gridViewCategory, 5, 1);
            tableLayoutPanel1.Controls.Add(btnClose, 6, 8);
            tableLayoutPanel1.Location = new Point(13, 12);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1083, 352);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelCategory
            // 
            panelCategory.BackColor = Color.DodgerBlue;
            tableLayoutPanel1.SetColumnSpan(panelCategory, 11);
            panelCategory.Controls.Add(lblTitleCategory);
            panelCategory.Location = new Point(4, 3);
            panelCategory.Margin = new Padding(4, 3, 4, 3);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(1075, 33);
            panelCategory.TabIndex = 0;
            // 
            // lblTitleCategory
            // 
            lblTitleCategory.Anchor = AnchorStyles.None;
            lblTitleCategory.AutoSize = true;
            lblTitleCategory.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleCategory.Location = new Point(378, 3);
            lblTitleCategory.Name = "lblTitleCategory";
            lblTitleCategory.Size = new Size(325, 29);
            lblTitleCategory.TabIndex = 0;
            lblTitleCategory.Text = "GESTION DE CATEGORIAS";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblNombre, 4);
            lblNombre.Dock = DockStyle.Bottom;
            lblNombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(4, 60);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(384, 18);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre de la Categoria";
            // 
            // lblDescriptionCategory
            // 
            lblDescriptionCategory.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblDescriptionCategory, 4);
            lblDescriptionCategory.Dock = DockStyle.Bottom;
            lblDescriptionCategory.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescriptionCategory.Location = new Point(4, 138);
            lblDescriptionCategory.Margin = new Padding(4, 0, 4, 0);
            lblDescriptionCategory.Name = "lblDescriptionCategory";
            lblDescriptionCategory.Size = new Size(384, 18);
            lblDescriptionCategory.TabIndex = 2;
            lblDescriptionCategory.Text = "Descripcion de la Categoria";
            // 
            // lblDateInitCategory
            // 
            lblDateInitCategory.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblDateInitCategory, 2);
            lblDateInitCategory.Dock = DockStyle.Bottom;
            lblDateInitCategory.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateInitCategory.Location = new Point(4, 216);
            lblDateInitCategory.Margin = new Padding(4, 0, 4, 0);
            lblDateInitCategory.Name = "lblDateInitCategory";
            lblDateInitCategory.Size = new Size(188, 18);
            lblDateInitCategory.TabIndex = 3;
            lblDateInitCategory.Text = "Creado";
            // 
            // lblDateUpdateCategory
            // 
            lblDateUpdateCategory.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblDateUpdateCategory, 2);
            lblDateUpdateCategory.Dock = DockStyle.Bottom;
            lblDateUpdateCategory.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateUpdateCategory.Location = new Point(298, 216);
            lblDateUpdateCategory.Margin = new Padding(4, 0, 4, 0);
            lblDateUpdateCategory.Name = "lblDateUpdateCategory";
            lblDateUpdateCategory.Size = new Size(188, 18);
            lblDateUpdateCategory.TabIndex = 4;
            lblDateUpdateCategory.Text = "Actualizado";
            lblDateUpdateCategory.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblDataInitCategory
            // 
            lblDataInitCategory.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblDataInitCategory, 3);
            lblDataInitCategory.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataInitCategory.Location = new Point(4, 234);
            lblDataInitCategory.Margin = new Padding(4, 0, 4, 0);
            lblDataInitCategory.Name = "lblDataInitCategory";
            lblDataInitCategory.Size = new Size(66, 17);
            lblDataInitCategory.TabIndex = 5;
            lblDataInitCategory.Text = "-- / -- / -- ";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(192, 255, 192);
            tableLayoutPanel1.SetColumnSpan(btnAgregar, 2);
            btnAgregar.Dock = DockStyle.Fill;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(4, 315);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(188, 34);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "AÑADIR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNameCategory
            // 
            txtNameCategory.BorderStyle = BorderStyle.FixedSingle;
            txtNameCategory.CharacterCasing = CharacterCasing.Upper;
            tableLayoutPanel1.SetColumnSpan(txtNameCategory, 5);
            txtNameCategory.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameCategory.Location = new Point(4, 81);
            txtNameCategory.Margin = new Padding(4, 3, 4, 3);
            txtNameCategory.MaxLength = 100;
            txtNameCategory.Name = "txtNameCategory";
            txtNameCategory.Size = new Size(188, 26);
            txtNameCategory.TabIndex = 11;
            // 
            // txtDescriptionCategory
            // 
            txtDescriptionCategory.BorderStyle = BorderStyle.FixedSingle;
            txtDescriptionCategory.CharacterCasing = CharacterCasing.Upper;
            tableLayoutPanel1.SetColumnSpan(txtDescriptionCategory, 5);
            txtDescriptionCategory.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescriptionCategory.Location = new Point(4, 159);
            txtDescriptionCategory.Margin = new Padding(4, 3, 4, 3);
            txtDescriptionCategory.MaxLength = 100;
            txtDescriptionCategory.Name = "txtDescriptionCategory";
            txtDescriptionCategory.Size = new Size(384, 26);
            txtDescriptionCategory.TabIndex = 12;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 224, 192);
            tableLayoutPanel1.SetColumnSpan(btnUpdate, 2);
            btnUpdate.Dock = DockStyle.Fill;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(200, 315);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(188, 34);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "ACTUALIZAR";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            tableLayoutPanel1.SetColumnSpan(btnCancel, 2);
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(396, 315);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(188, 34);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblDataFinishCategory
            // 
            lblDataFinishCategory.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblDataFinishCategory, 3);
            lblDataFinishCategory.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataFinishCategory.Location = new Point(298, 234);
            lblDataFinishCategory.Margin = new Padding(4, 0, 4, 0);
            lblDataFinishCategory.Name = "lblDataFinishCategory";
            lblDataFinishCategory.Size = new Size(66, 17);
            lblDataFinishCategory.TabIndex = 6;
            lblDataFinishCategory.Text = "-- / -- / -- ";
            // 
            // gridViewCategory
            // 
            gridViewCategory.AllowUserToAddRows = false;
            gridViewCategory.AllowUserToDeleteRows = false;
            gridViewCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridViewCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridViewCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewCategory.Columns.AddRange(new DataGridViewColumn[] { idCategory, nameCategory, descriptionCategory, dateCreateCategory, dateUpdateCategory, actionCategory });
            tableLayoutPanel1.SetColumnSpan(gridViewCategory, 6);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridViewCategory.DefaultCellStyle = dataGridViewCellStyle2;
            gridViewCategory.Location = new Point(494, 42);
            gridViewCategory.Margin = new Padding(4, 3, 4, 3);
            gridViewCategory.Name = "gridViewCategory";
            gridViewCategory.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(gridViewCategory, 4);
            gridViewCategory.Size = new Size(585, 150);
            gridViewCategory.TabIndex = 13;
            gridViewCategory.CellClick += gridViewCategory_CellClick;
            // 
            // idCategory
            // 
            idCategory.HeaderText = "idCategoru";
            idCategory.Name = "idCategory";
            idCategory.ReadOnly = true;
            idCategory.Visible = false;
            // 
            // nameCategory
            // 
            nameCategory.HeaderText = "Categoria";
            nameCategory.Name = "nameCategory";
            nameCategory.ReadOnly = true;
            // 
            // descriptionCategory
            // 
            descriptionCategory.HeaderText = "Descripcion";
            descriptionCategory.Name = "descriptionCategory";
            descriptionCategory.ReadOnly = true;
            // 
            // dateCreateCategory
            // 
            dateCreateCategory.HeaderText = "Creado";
            dateCreateCategory.Name = "dateCreateCategory";
            dateCreateCategory.ReadOnly = true;
            // 
            // dateUpdateCategory
            // 
            dateUpdateCategory.HeaderText = "Actualizado";
            dateUpdateCategory.Name = "dateUpdateCategory";
            dateUpdateCategory.ReadOnly = true;
            // 
            // actionCategory
            // 
            actionCategory.FlatStyle = FlatStyle.Flat;
            actionCategory.HeaderText = "Accion";
            actionCategory.Name = "actionCategory";
            actionCategory.ReadOnly = true;
            actionCategory.Text = "Borrar";
            actionCategory.UseColumnTextForButtonValue = true;
            // 
            // errorProviderCategory
            // 
            errorProviderCategory.ContainerControl = this;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 192, 128);
            tableLayoutPanel1.SetColumnSpan(btnClose, 2);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(591, 315);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(190, 34);
            btnClose.TabIndex = 14;
            btnClose.Text = "CERRAR";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1109, 376);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(738, 415);
            Name = "CategoryForm";
            Text = "Gestion de categorias";
            Load += CategoryForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelCategory.ResumeLayout(false);
            panelCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCategory).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescriptionCategory;
        private System.Windows.Forms.Label lblDateInitCategory;
        private System.Windows.Forms.Label lblDateUpdateCategory;
        private System.Windows.Forms.Label lblDataInitCategory;
        private System.Windows.Forms.Label lblDataFinishCategory;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNameCategory;
        private System.Windows.Forms.TextBox txtDescriptionCategory;
        private System.Windows.Forms.DataGridView gridViewCategory;
        private Label lblTitleCategory;
        private ErrorProvider errorProviderCategory;
        private DataGridViewTextBoxColumn idCategory;
        private DataGridViewTextBoxColumn nameCategory;
        private DataGridViewTextBoxColumn descriptionCategory;
        private DataGridViewTextBoxColumn dateCreateCategory;
        private DataGridViewTextBoxColumn dateUpdateCategory;
        private DataGridViewButtonColumn actionCategory;
        private Button btnClose;
    }
}