using LayerLogical.Inventory;
using LayerModel.Responses;
using LayerViews.Responses;

namespace LayerViews.Inventory
{
    public partial class ProductForm : Form
    {
        private int idProductConsult = 0;
        private LogicalProduct logicalProduct = new LogicalProduct();
        private ShowMessages sendMessage = new ShowMessages();
        private ValidateData validateData = new ValidateData();

        public ProductForm()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseProduct_Click(object sender, EventArgs e)
        {

        }

        private void gridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
