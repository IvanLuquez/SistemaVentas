using LayerLogical.Inventory;
using LayerModel.Inventory;
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

namespace SistemaVentas.Inventory
{
    public partial class CategoryForm : Form
    {
        private LogicalCategory logicalCategory = new LogicalCategory();
        private ShowMessages sendMessage = new ShowMessages();
        private ValidateData validateData = new ValidateData();

        private int idCategoryRegister = 0;

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validateInforFormCategory())
            {
                sendMessage.ShowMessage(logicalCategory.saveCategory(getDataFormCategory()));
                cleanFormCategory();
                getCategoryInformation();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validateInforFormCategory() && idCategoryRegister > 0)
            {
                sendMessage.ShowMessage(logicalCategory.updateCategory(getDataFormCategory()));
                cleanFormCategory();
                getCategoryInformation();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleanFormCategory();
        }

        private void getCategoryInformation()
        {
            MessageResponse messageResponse = logicalCategory.getAllCategory();
            if (messageResponse.Success && messageResponse.DataConsult != null)
            {
                gridViewCategory.DataSource = null;
                gridViewCategory.Rows.Clear();

                foreach (DataRow item in messageResponse.DataConsult.Rows)
                {
                    gridViewCategory.Rows.Add(
                        item["idcategory"].ToString(),
                        item["name_category"].ToString(),
                        item["description"].ToString(),
                        item["date_create"].ToString(),
                        item["date_update"].ToString()
                    );
                }
            }
            else
            {
                sendMessage.ShowMessage(messageResponse);
            }
        }

        private Category getDataFormCategory()
        {
            Category category = new Category();
            category.idCategory = idCategoryRegister;
            category.nameCategory = txtNameCategory.Text;
            category.descriptionCategory = txtDescriptionCategory.Text;
            category.dateCreateCategory = DateTime.Now;
            category.dateUpdateCategory = DateTime.Now;

            return category;
        }

        private bool validateInforFormCategory()
        {
            if (string.IsNullOrWhiteSpace(txtNameCategory.Text) ||
                string.IsNullOrWhiteSpace(txtDescriptionCategory.Text))
            {
                errorProviderCategory.SetError(txtNameCategory, "Campo Obligatorio.");
                errorProviderCategory.SetError(txtDescriptionCategory, "Campo Obligatorio.");
                return false;
            }

            return true;
        }

        private void cleanFormCategory()
        {
            txtNameCategory.Text = string.Empty;
            txtDescriptionCategory.Text = string.Empty;
            lblDataFinishCategory.Text = "-- / -- / --";
            lblDataInitCategory.Text = "-- / -- / --";
            txtNameCategory.Focus();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            getCategoryInformation();
        }

        private void gridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string message;
            string nameCategorySelect = "Sin definir";
            if (e.ColumnIndex == gridViewCategory.Columns["actionCategory"].Index && e.RowIndex >= 0)
            {
                idCategoryRegister = Convert.ToInt32(gridViewCategory.Rows[e.RowIndex].Cells["idcategory"].Value);
                nameCategorySelect = validateData.ValidateString((string)gridViewCategory.Rows[e.RowIndex].Cells["nameCategory"].Value);
                message = $"¿Desea eliminar el registro seleccionado : {nameCategorySelect} ?";
                if (sendMessage.ShowCheckMessage(message))
                {
                    sendMessage.ShowMessage(logicalCategory.deleteCategory(idCategoryRegister));
                    getCategoryInformation();
                }
            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    idCategoryRegister = Convert.ToInt32(gridViewCategory.Rows[e.RowIndex].Cells["idcategory"].Value);
                    txtNameCategory.Text = validateData.ValidateString((string)gridViewCategory.Rows[e.RowIndex].Cells["nameCategory"].Value);
                    txtDescriptionCategory.Text = validateData.ValidateString((string)gridViewCategory.Rows[e.RowIndex].Cells["descriptionCategory"].Value);
                    lblDataInitCategory.Text = validateData.ValidateString((string)gridViewCategory.Rows[e.RowIndex].Cells["dateCreateCategory"].Value);
                    lblDataFinishCategory.Text = validateData.ValidateString((string)gridViewCategory.Rows[e.RowIndex].Cells["dateUpdateCategory"].Value);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
