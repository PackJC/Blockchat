using Microsoft.AspNetCore.Identity;

namespace Blockchat.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime JoinDate { get; set; }
        public DateTime BirthDate { get; set; }

        public byte[] ProfilePicture { get; set; }


    }
}
