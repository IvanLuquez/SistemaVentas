using LayerEntity.Inventory;
using LayerModel.Responses;
using System.Data;

namespace LayerData.Inventory
{
    public interface ISupplier
    {
        public MessageResponse getAllSupplier();
        public MessageResponse createSupplier(Supplier supplier);
        public MessageResponse updateSupplier(Supplier supplier);
        public MessageResponse deleteSupplier(int idSupplier);
    }
}
