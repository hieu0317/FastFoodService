using Microsoft.AspNetCore.Identity;

namespace PRN231_ProjectMain.Models
{
    public class User : IdentityUser
    {
        public string Fullname { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
    }
}
