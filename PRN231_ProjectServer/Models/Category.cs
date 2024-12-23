namespace PRN231_ProjectMain.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Describe { get; set; }
        public string? CatImage { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
