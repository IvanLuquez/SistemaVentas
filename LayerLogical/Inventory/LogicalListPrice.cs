using LayerData.Inventory;
using LayerData.Inventory.Impl;
using LayerEntity.Inventory;
using LayerModel.Responses;

namespace LayerLogical.Inventory
{
    public class LogicalListPrice
    {
        IListPrice priceListLogical= new AccessListPrice();
        
        public MessageResponse createListPrice(ListPrice listPrice) {
            return priceListLogical.createPriceList(listPrice);
        }
        public MessageResponse updateListPrice(ListPrice listPrice) {
            return priceListLogical.updatePriceList(listPrice);
        }
        public MessageResponse deleteListPrice(int idListPrice) {
            return priceListLogical.deletePriceList(idListPrice);
        }
        public MessageResponse getAllListPrice() {
            return priceListLogical.getAllPriceList();
        }
    }
}
