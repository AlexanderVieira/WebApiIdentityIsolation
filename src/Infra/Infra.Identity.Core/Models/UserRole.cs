using Microsoft.AspNetCore.Identity;

namespace Infra.Identity.Core.Models
{ 
    public class UserRole : IdentityUserRole<int>
    {
        public ApplicationUser User { get; set; }
        public Role Role { get; set; }
    }
}