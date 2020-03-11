using System;
using Group4.KANAP.Data.Entities;
using Group4.KANAP.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Group4.KANAP.Areas.Identity.IdentityHostingStartup))]
namespace Group4.KANAP.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
        //    builder.ConfigureServices((context, services) => {
        //        services.AddDbContext<Group4KANAPContext>(options =>
        //            options.UseSqlServer(
        //                context.Configuration.GetConnectionString("Group4KANAPContextConnection")));

        //        services.AddDefaultIdentity<AppUser>()
        //            .AddEntityFrameworkStores<Group4KANAPContext>();
        //    });
        }
    }
}