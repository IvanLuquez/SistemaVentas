using LayerData.Inventory;
using LayerData.Inventory.Impl;
using LayerEntity.Inventory;
using System.Data;
using System.Text;

namespace LayerLogical.Inventory
{
    public class LogicalProduct
    {
        IProduct accessProduct = new AccessProduct();

        public string createProduct(Product product) {
            return "";
        }
        public string updateProduct(Product product) {
            return "";
        }
        public string deleteProduct(int idProduct)
        {
            return "";
        }

        public DataTable getAllProduct()
        {
            return null;
        }
    }
}
