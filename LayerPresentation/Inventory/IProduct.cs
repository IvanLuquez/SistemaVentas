using LayerEntity.Inventory;
using LayerModel.Responses;
using System.Data;

namespace LayerData.Inventory
{
    public interface IProduct
    {
        public MessageResponse getAllProduct();
        public MessageResponse saveProduct(Product product);
        public MessageResponse updateProduct(Product product);
        public MessageResponse deleteProduct(int idProduct);
    }
}
