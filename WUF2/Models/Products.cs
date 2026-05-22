namespace WUF2.Models
{
    public class Products
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public Categories Categories { get; set; }
        public int CategoriesId { get; set; }
    }
}
