using System.Data;
using LayerModel.Inventory;
using LayerModel.Responses;

namespace LayerData.Inventory
{
    public interface ICategory
    {
        public MessageResponse getAllCategory();
        public MessageResponse createCategory(Category category);
        public MessageResponse updateCategory(Category category);
        public MessageResponse deleteCategory(int idCategory);
    }
}
