using LayerEntity.Inventory;
using LayerLogical.Inventory;
using LayerModel.Responses;
using LayerViews.Responses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LayerViews.Inventory
{
    public partial class SupplierForm : Form
    {
        private int idSupplierConsult = 0;
        private LogicalSupplier logicalSupplier = new LogicalSupplier();
        private ShowMessages sendMessage = new ShowMessages();
        private ValidateData validateData = new ValidateData();

        public SupplierForm()
        {
            InitializeComponent();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            if (ValidateSupplierForm())
            {
                sendMessage.ShowMessage(logicalSupplier.createSupplier(GetSupplierForm()));
                cleanFormSupplier();
                getSupplierInformation();
            }
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            if (ValidateSupplierForm() && idSupplierConsult > 0)
            {
                sendMessage.ShowMessage(logicalSupplier.updateSupplier(GetSupplierForm()));
                cleanFormSupplier();
                getSupplierInformation();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleanFormSupplier();
        }

        private void btnExitSupplier_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridViewSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string message;
            string nameCategorySelect = "Sin definir";
            if (e.ColumnIndex == gridViewSupplier.Columns["actionSupplier"].Index && e.RowIndex >= 0)
            {
                idSupplierConsult = Convert.ToInt32(gridViewSupplier.Rows[e.RowIndex].Cells["idsupplier"].Value);
                nameCategorySelect = validateData.ValidateString((string)gridViewSupplier.Rows[e.RowIndex].Cells["nameSupplier"].Value);
                message = $"¿Desea eliminar el registro seleccionado : {nameCategorySelect} ?";
                if (sendMessage.ShowCheckMessage(message))
                {
                    sendMessage.ShowMessage(logicalSupplier.deleteSupplier(idSupplierConsult));
                    getSupplierInformation();
                    cleanFormSupplier();
                }
            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    idSupplierConsult = Convert.ToInt32(gridViewSupplier.Rows[e.RowIndex].Cells["idsupplier"].Value);
                    txtNameSupplier.Text = validateData.ValidateString((string)gridViewSupplier.Rows[e.RowIndex].Cells["nameSupplier"].Value);
                    txtNameSocialSupplier.Text = validateData.ValidateString((string)gridViewSupplier.Rows[e.RowIndex].Cells["nameSocialSupplier"].Value);
                    txtAddresSupplier.Text = validateData.ValidateString((string)gridViewSupplier.Rows[e.RowIndex].Cells["addressSupplier"].Value);
                    txtNumberOneSupplier.Text = validateData.ValidateString((string)gridViewSupplier.Rows[e.RowIndex].Cells["phoneSupplier"].Value);
                    txtNumberTwoSupplier.Text = validateData.ValidateString((string)gridViewSupplier.Rows[e.RowIndex].Cells["phoneTwoSupplier"].Value);
                    txtDescriptionSupplier.Text = validateData.ValidateString((string)gridViewSupplier.Rows[e.RowIndex].Cells["descriptionSupplier"].Value);
                    btnAddSupplier.Enabled = false;
                }
            }
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            getSupplierInformation();
        }

        private Supplier GetSupplierForm()
        {
            Supplier supplier = new Supplier();
            supplier.idSupplier = idSupplierConsult;
            supplier.nameSupplier = txtNameSupplier.Text;
            supplier.socialNameSupplier = txtNameSocialSupplier.Text;
            supplier.addressSupplier = txtAddresSupplier.Text;
            supplier.numberOneSupplier = txtNumberOneSupplier.Text;
            supplier.numberTwoSupplier = txtNumberTwoSupplier.Text;
            supplier.descriptionSupplier = txtDescriptionSupplier.Text;
            return supplier;
        }

        private bool ValidateSupplierForm()
        {
            if (string.IsNullOrWhiteSpace(txtNameSocialSupplier.Text) || 
                string.IsNullOrWhiteSpace(txtNameSocialSupplier.Text) ||
                string.IsNullOrWhiteSpace(txtNumberOneSupplier.Text)) {
                errorProviderSupplier.SetError(txtNameSocialSupplier, "Campo Obligatorio.");
                errorProviderSupplier.SetError(txtNameSupplier, "Campo Obligatorio.");
                errorProviderSupplier.SetError(txtNumberOneSupplier, "Campo Obligatorio.");
                return false;
            }

            return true;
        }

        private void cleanFormSupplier()
        {
            txtNameSupplier.Text = string.Empty;
            txtNameSupplier.Focus();
            txtNameSocialSupplier.Text = string.Empty;
            txtAddresSupplier.Text = string.Empty;
            txtNumberOneSupplier.Text = string.Empty;
            txtNumberTwoSupplier.Text = string.Empty;
            txtDescriptionSupplier.Text = string.Empty;
            idSupplierConsult = 0;
            btnAddSupplier.Enabled = true;
        }

        private void getSupplierInformation()
        {
            MessageResponse messageResponse = logicalSupplier.getAllSupplier();
            if (messageResponse.Success && messageResponse.DataConsult != null)
            {
                gridViewSupplier.DataSource = null;
                gridViewSupplier.Rows.Clear();

                foreach (DataRow item in messageResponse.DataConsult.Rows)
                {
                    gridViewSupplier.Rows.Add(
                        item["idsupplier"].ToString(),
                        item["name_supplier"].ToString(),
                        item["name_social"].ToString(),
                        item["direccion"].ToString(),
                        item["phonenumber1"].ToString(),
                        item["phonenumber2"].ToString(),
                        item["description"].ToString());
                }
            }
            else
            {
                sendMessage.ShowMessage(messageResponse);
            }
        }
    }
}
