using Microsoft.AspNetCore.Identity;

namespace Blockchat.Models
{
    public class RoleEdit
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<Areas.Identity.Data.ApplicationUser> Members { get; set; }
        public IEnumerable<Areas.Identity.Data.ApplicationUser> NonMembers { get; set; }
    }
}
