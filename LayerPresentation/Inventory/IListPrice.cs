using LayerEntity.Inventory;
using LayerModel.Responses;

namespace LayerData.Inventory
{
    public interface IListPrice
    {
        public MessageResponse getAllPriceList();
        public MessageResponse createPriceList(ListPrice listPrice);
        public MessageResponse updatePriceList(ListPrice listPrice);
        public MessageResponse deletePriceList(int listPrice);
    }
}
