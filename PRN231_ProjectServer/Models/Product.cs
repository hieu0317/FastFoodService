namespace PRN231_ProjectMain.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; } = null!;
        public string? Details { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }
        public string? ImageUrl { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
    }
}
