namespace AssurityTest.Models.Category
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int? OriginalPrice { get; set; }
        public bool? Recommended { get; set; }
        public int MinimumPhotoCount { get; set; }
    }
}
