using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Infra.CrossCutting.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        //public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        //{
        //    // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
        //    //var userIdentity = await manager.CreateAsync(this, "Identity.Application");
        //    // Add custom user claims here
        //    //return userIdentity;
        //}
    }
}