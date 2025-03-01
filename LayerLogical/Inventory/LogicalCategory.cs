using LayerData.Inventory.Impl;
using LayerModel.Inventory;
using LayerLogical.Utils;
using System.Data;
using System.Text;

namespace LayerLogical.Inventory
{
    public class LogicalCategory
    {
        AccessCategory accessCategory = new AccessCategory();
        UtilityValidateField validateFieldUtility = new UtilityValidateField();
        StringBuilder resultValidation;
        public DataTable getAllCategory()
        {
            try
            {
                return accessCategory.getAllCategory();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string saveCategory(Category category)
        {
            string result = validateField(category);

            if (string.IsNullOrEmpty(result))
            {
                return accessCategory.createCategory(category);
            } else
            {
                return result;
            }
        }
        
        public string updateCategory(Category category)
        {
            string result = validateField(category);

            if (string.IsNullOrEmpty(result))
            {
                return accessCategory.updateCategory(category);
            } else
            {
                return result;
            }
        }

        public string deleteCategory(int idCategory)
        {
            return accessCategory.deleteCategory(idCategory);
        }

        private string validateField(Category category)
        {
            resultValidation = new StringBuilder();
            validateFieldUtility.fieldObligatory(category.nameCategory ,"Nombre", 100, resultValidation);
            validateFieldUtility.fieldLength(category.descriptionCategory, "Descripcion", 100, resultValidation);

            return resultValidation.ToString();
        }
    }

}
