namespace AssurityTest.Models.Category
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal? OriginalPrice { get; set; }
        public bool? Recommended { get; set; }
        public int MinimumPhotoCount { get; set; }
    }
}
