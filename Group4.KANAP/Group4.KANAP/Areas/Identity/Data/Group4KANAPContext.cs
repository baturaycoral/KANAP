using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group4.KANAP.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Group4.KANAP.Models
{
    public class Group4KANAPContext : IdentityDbContext<AppUser>
    {
        public Group4KANAPContext(DbContextOptions<Group4KANAPContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
