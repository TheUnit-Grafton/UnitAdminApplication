using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(UnitAdmin.Areas.Identity.IdentityHostingStartup))]
namespace UnitAdmin.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}