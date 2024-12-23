using System.Security.Principal;

namespace PRN231_ProjectMain.Models
{
    public class Like
    {
        public int LikeId { get; set; }
        public int? ProductId { get; set; }
        public string? UserId { get; set; }

        public virtual User? User { get; set; }
        public virtual Product? Product { get; set; }
    }
}
