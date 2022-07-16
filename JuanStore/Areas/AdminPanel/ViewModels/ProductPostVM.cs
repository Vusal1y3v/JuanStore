namespace JuanStore.Areas.AdminPanel.ViewModels
{
    public class ProductPostVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int DiscountPrice { get; set; }
        public string Description { get; set; }
        public bool IsTopSeller { get; set; }
        public int Count { get; set; }
        public int CategoryId { get; set; }
    }
}