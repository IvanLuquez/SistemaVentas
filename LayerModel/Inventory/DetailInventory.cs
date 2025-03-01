namespace LayerEntity.Inventory
{
    public class DetailInventory
    {
        public int idDetailtInventory { get; set; }
        public string nameProduct {  get; set; }
        public string nameStorage { get; set; }
        public string description { get; set; }
        public int amountExisting {  get; set; }
        public DateTime createdDate { get; set; }
        public int idProduct { get; set; }
        public int idStorage { get; set; }
    }
}
