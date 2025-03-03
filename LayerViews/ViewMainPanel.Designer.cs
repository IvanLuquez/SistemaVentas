namespace LayerViews
{
    partial class ViewMainPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuOptions = new MenuStrip();
            iNVENTARIOToolStripMenuItem = new ToolStripMenuItem();
            gestionarCategoriaToolStripMenuItem = new ToolStripMenuItem();
            panelChild = new Panel();
            menuOptions.SuspendLayout();
            SuspendLayout();
            // 
            // menuOptions
            // 
            menuOptions.Dock = DockStyle.Left;
            menuOptions.Items.AddRange(new ToolStripItem[] { iNVENTARIOToolStripMenuItem });
            menuOptions.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuOptions.Location = new Point(0, 0);
            menuOptions.Name = "menuOptions";
            menuOptions.Size = new Size(91, 450);
            menuOptions.TabIndex = 0;
            menuOptions.Text = "menuOption";
            // 
            // iNVENTARIOToolStripMenuItem
            // 
            iNVENTARIOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionarCategoriaToolStripMenuItem });
            iNVENTARIOToolStripMenuItem.Name = "iNVENTARIOToolStripMenuItem";
            iNVENTARIOToolStripMenuItem.Size = new Size(78, 19);
            iNVENTARIOToolStripMenuItem.Text = "INVENTARIO";
            // 
            // gestionarCategoriaToolStripMenuItem
            // 
            gestionarCategoriaToolStripMenuItem.Name = "gestionarCategoriaToolStripMenuItem";
            gestionarCategoriaToolStripMenuItem.Size = new Size(178, 22);
            gestionarCategoriaToolStripMenuItem.Text = "Gestionar Categoria";
            gestionarCategoriaToolStripMenuItem.Click += gestionarCategoriaToolStripMenuItem_Click;
            // 
            // panelChild
            // 
            panelChild.BackColor = Color.MediumAquamarine;
            panelChild.Dock = DockStyle.Fill;
            panelChild.Location = new Point(91, 0);
            panelChild.Name = "panelChild";
            panelChild.Size = new Size(709, 450);
            panelChild.TabIndex = 1;
            // 
            // ViewMainPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelChild);
            Controls.Add(menuOptions);
            IsMdiContainer = true;
            MainMenuStrip = menuOptions;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewMainPanel";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GESTION DE INVENTARIOS";
            WindowState = FormWindowState.Maximized;
            Load += ViewMainPanel_Load;
            menuOptions.ResumeLayout(false);
            menuOptions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuOptions;
        private ToolStripMenuItem iNVENTARIOToolStripMenuItem;
        private ToolStripMenuItem gestionarCategoriaToolStripMenuItem;
        private Panel panelChild;
    }
}
