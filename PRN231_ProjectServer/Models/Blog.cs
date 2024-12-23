using System.Security.Principal;

namespace PRN231_ProjectMain.Models
{
    public class Blog
    {
        public string UserId { get; set; }
        public int BlogId { get; set; }
        public string? BlogTitle { get; set; }
        public string? BlogDetail { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public string? ImageUrl { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
