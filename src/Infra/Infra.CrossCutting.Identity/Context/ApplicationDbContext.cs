using Infra.CrossCutting.Identity.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace Infra.CrossCutting.Identity.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public ApplicationDbContext()
            :base("DefaultConnection", throwIfV1Schema: false)
        {
                
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
