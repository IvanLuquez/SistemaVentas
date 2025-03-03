
using LayerEntity.Inventory;
using LayerLogical.Inventory;
using LayerModel.Responses;
using LayerViews.Responses;
using System.Data;

namespace LayerViews.Inventory
{
    public partial class ListPriceForm : Form
    {

        private int idListPriceConsult = 0;
        private LogicalListPrice logicalListPrice = new LogicalListPrice();
        private ShowMessages sendMessage = new ShowMessages();
        private ValidateData validateData = new ValidateData();
        public ListPriceForm()
        {
            InitializeComponent();
        }

        private void btnAgregarPrice_Click(object sender, EventArgs e)
        {
            if (validateListPriceForm())
                sendMessage.ShowMessage(logicalListPrice.createListPrice(GetListPriceForm()));

            cleanFormListPrice();
            getAllListPrice();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (validateListPriceForm() && idListPriceConsult > 0)
                sendMessage.ShowMessage(logicalListPrice.updateListPrice(GetListPriceForm()));

            cleanFormListPrice();
            getAllListPrice();
        }

        private void ListPriceForm_Load(object sender, EventArgs e)
        {
            getAllListPrice();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleanFormListPrice();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cleanFormListPrice();
            Close();
        }

        private void gridViewListPrice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string message;
            string nameCategorySelect = "Sin definir";
            if (e.ColumnIndex == gridViewListPrice.Columns["actionPrice"].Index && e.RowIndex >= 0)
            {
                idListPriceConsult = Convert.ToInt32(gridViewListPrice.Rows[e.RowIndex].Cells["idlistprice"].Value);
                nameCategorySelect = validateData.ValidateString((string)gridViewListPrice.Rows[e.RowIndex].Cells["name_list"].Value);
                message = $"¿Desea eliminar el registro seleccionado : {nameCategorySelect} ?";
                if (sendMessage.ShowCheckMessage(message))
                {
                    sendMessage.ShowMessage(logicalListPrice.deleteListPrice(idListPriceConsult));
                    getAllListPrice();
                    cleanFormListPrice();
                }
            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    idListPriceConsult = Convert.ToInt32(gridViewListPrice.Rows[e.RowIndex].Cells["idlistprice"].Value);
                    txtNameListPrice.Text = validateData.ValidateString((string)gridViewListPrice.Rows[e.RowIndex].Cells["name_list"].Value);
                    txtDescriptionListPrice.Text = validateData.ValidateString((string)gridViewListPrice.Rows[e.RowIndex].Cells["description"].Value);
                    bool statePriceList = (bool)gridViewListPrice.Rows[e.RowIndex].Cells["active"].Value;
                    lblDateCreatePriceList.Text = validateData.ValidateString((string)gridViewListPrice.Rows[e.RowIndex].Cells["date_create"].Value);
                    lbldateUpdatePriceList.Text = validateData.ValidateString((string)gridViewListPrice.Rows[e.RowIndex].Cells["date_update"].Value);
                    btnAgregarPrice.Enabled = false;
                    BtnActualizar.Enabled = true;

                    if (statePriceList)
                    {
                        radioButtonActivo.Checked = true;
                    }
                    else
                    {
                        radioButtonInActivo.Checked = true;
                    }
                }
            }
        }

        private ListPrice GetListPriceForm()
        {
            ListPrice listPrice = new ListPrice();
            listPrice.idPriceList = idListPriceConsult;
            listPrice.namePriceList = txtNameListPrice.Text;
            listPrice.descriptionPriceList = txtDescriptionListPrice.Text;
            listPrice.activePriceList = radioButtonActivo.Checked;
            listPrice.createPriceList = DateTime.Now;
            listPrice.updatePriceList = DateTime.Now;
            return listPrice;
        }

        private bool validateListPriceForm()
        {
            if (string.IsNullOrWhiteSpace(txtNameListPrice.Text))
            {
                errorProviderListPrice.SetError(txtNameListPrice, "Campo Obligatorio.");
                return false;
            }

            return true;
        }

        private void cleanFormListPrice()
        {
            txtNameListPrice.Text = string.Empty;
            txtDescriptionListPrice.Text = string.Empty;
            radioButtonActivo.Checked = true;
            idListPriceConsult = 0;
            txtNameListPrice.Focus();
            btnAgregarPrice.Enabled = true; 
            BtnActualizar.Enabled = false; 
            lblDateCreatePriceList.Text = "--/--/--";
            lbldateUpdatePriceList.Text = "--/--/--";
        }

        private void getAllListPrice()
        {
            MessageResponse messageResponse = logicalListPrice.getAllListPrice();
            if (messageResponse.Success && messageResponse.DataConsult != null)
            {
                gridViewListPrice.DataSource = null;
                gridViewListPrice.Rows.Clear();

                foreach (DataRow item in messageResponse.DataConsult.Rows)
                {
                    gridViewListPrice.Rows.Add(
                        item["idlistprice"].ToString(),
                        item["name_list"].ToString(),
                        item["description"].ToString(),
                        item["active"],
                        item["date_create"].ToString(),
                        item["date_update"].ToString());
                }
            }
            else
            {
                sendMessage.ShowMessage(messageResponse);
            }
        }


    }
}
