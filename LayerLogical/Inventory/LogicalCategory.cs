using LayerData.Inventory.Impl;
using LayerModel.Inventory;
using LayerModel.Responses;
using System.Data;
using System.Text;

namespace LayerLogical.Inventory
{
    public class LogicalCategory
    {
        AccessCategory accessCategory = new AccessCategory();
        public MessageResponse getAllCategory()
        {
            return accessCategory.getAllCategory();
        }

        public MessageResponse saveCategory(Category category)
        {
            return accessCategory.createCategory(category);
        }
        
        public MessageResponse updateCategory(Category category)
        {
            return accessCategory.updateCategory(category);
        }

        public MessageResponse deleteCategory(int idCategory)
        {
            return accessCategory.deleteCategory(idCategory);
        }
    }
}
