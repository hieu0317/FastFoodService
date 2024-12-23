using System.Security.Principal;

namespace PRN231_ProjectMain.Models
{
    public class Order
    {
        public string UserId { get; set; }
        public int OrderId { get; set; }
        public int Total { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; } = null!;
        public string? Note { get; set; }
        public int OrderStatusId { get; set; }
        public string? CustomerName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? PaymentMethod { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual OrderStatus OrderStatus { get; set; } = null!;
    }
}
