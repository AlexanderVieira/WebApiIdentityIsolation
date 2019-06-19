using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Infra.CrossCutting.Identity.Models
{
    public class Role : IdentityRole<int>
    {
        public List<UserRole> UserRoles { get; set; }
    }
}
