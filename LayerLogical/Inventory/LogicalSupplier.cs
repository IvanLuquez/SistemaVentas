using LayerData.Inventory;
using LayerData.Inventory.Impl;
using LayerEntity.Inventory;
using LayerModel.Responses;
using System.Data;
using System.Text;

namespace LayerLogical.Inventory
{
    public class LogicalSupplier
    {
        ISupplier supplierLogical = new AccessSupplier();
        public MessageResponse createSupplier(Supplier supplier) {
            return supplierLogical.createSupplier(supplier);
        }
        public MessageResponse updateSupplier(Supplier supplier) {
            return supplierLogical.updateSupplier(supplier);
        }
        public MessageResponse deleteSupplier(int idSupplier) {
            return supplierLogical.deleteSupplier(idSupplier);
        }
        public MessageResponse getAllSupplier() {
            return supplierLogical.getAllSupplier();    
        }
    }
}
