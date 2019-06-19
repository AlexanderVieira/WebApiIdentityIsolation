using Microsoft.AspNetCore.Identity;

namespace Infra.CrossCutting.Identity.Models
{
    public class UserRole : IdentityUserRole<int>
    {
        public ApplicationUser User { get; set; }
        public Role Role { get; set; }
    }
}