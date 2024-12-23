using System.Security.Principal;

namespace PRN231_ProjectMain.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
