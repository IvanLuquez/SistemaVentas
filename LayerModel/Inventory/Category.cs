namespace LayerModel.Inventory
{
    public class Category
    {
        public int idCategory { get; set; }
        public required string nameCategory { get; set; }
        public required string descriptionCategory { get; set; }
        public DateTime dateCreateCategory { get; set; }
        public DateTime dateUpdateCategory { get; set; }
    }
}
