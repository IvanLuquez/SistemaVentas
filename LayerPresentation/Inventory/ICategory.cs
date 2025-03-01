using System.Data;
using LayerModel.Inventory;

namespace LayerData.Inventory
{
    public interface ICategory
    {
        public DataTable getAllCategory();
        public string createCategory(Category category);
        public string updateCategory(Category category);
        public string deleteCategory(int idCategory);
    }
}
