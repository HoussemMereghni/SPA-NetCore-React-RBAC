using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SPAUtilityTemplates.Data;

[assembly: HostingStartup(typeof(SPA.Utility.Templates.Areas.Identity.IdentityHostingStartup))]
namespace SPA.Utility.Templates.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                // services.AddDbContext<ApplicationDbContext>(options =>
                // options.UseSqlServer(
                //    context.Configuration.GetConnectionString("ApplicationDbContextConnection")));

                // services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                // .AddEntityFrameworkStores<ApplicationDbContext>();
            });
        }
    }
}