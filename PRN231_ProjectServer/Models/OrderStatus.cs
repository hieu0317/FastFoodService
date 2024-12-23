namespace PRN231_ProjectMain.Models
{
    public class OrderStatus
    {
        public int OrderStatusId { get; set; }
        public string OrderStatusName { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
