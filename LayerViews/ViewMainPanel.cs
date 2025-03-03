using SistemaVentas.Inventory;

namespace LayerViews
{
    public partial class ViewMainPanel : Form
    {
        private Form activeFormChild = null;

        public ViewMainPanel()
        {
            InitializeComponent();
        }

        private void ViewMainPanel_Load(object sender, EventArgs e)
        {

        }

        private void openChildForm(Form child)
        {
            if (activeFormChild != null)
            {
                activeFormChild.Close();
            }

            activeFormChild = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelChild.Controls.Add(child);
            panelChild.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void gestionarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());
        }
    }
}
