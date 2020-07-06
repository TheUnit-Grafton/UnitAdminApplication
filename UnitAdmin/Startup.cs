using DataLibrary.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Syncfusion.Blazor;
using UnitAdmin.Areas.Identity;
using UnitAdmin.Data;
using UnitAdmin.Models;

namespace UnitAdmin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AuthDbContext>(options =>
            {
                options.UseMySql(
                    (Configuration.GetConnectionString("AuthConnection")) ,
                    options => options.EnableRetryOnFailure());
                options.EnableDetailedErrors();
            });

            // Add DbContext for system data (excluding users)
            services.AddDbContext<UnitDataDbContext>(options =>
            {
                options.UseMySql(
                    (Configuration.GetConnectionString("UnitDataDBConnection")) ,
                    options => options.EnableRetryOnFailure());
                options.EnableDetailedErrors();
            });


            services.AddIdentity<AppUser , AppRole>(options =>
             {
                 options.SignIn.RequireConfirmedAccount = false;
                 options.User.RequireUniqueEmail = true;
                 options.SignIn.RequireConfirmedEmail = false;
             })
                .AddUserManager<UserManager<AppUser>>()
                .AddRoles<AppRole>()
                .AddEntityFrameworkStores<AuthDbContext>();

            services.AddMvc();
            services.AddRazorPages();
            services.AddServerSideBlazor();

            // Add SyncFusion Community Blazor controls
            services.AddSyncfusionBlazor();

            services.AddScoped<AuthenticationStateProvider , RevalidatingIdentityAuthenticationStateProvider<AppUser>>();

            services.AddScoped<IActivityService , ActivityService>();
            services.AddScoped<IAnnouncementService , AnnouncementService>();
            services.AddScoped<IComputerService , ComputerService>();
            services.AddScoped<IPartsService , PartsService>();
            services.AddScoped<IMemberService , MemberService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app , IWebHostEnvironment env)
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider
                .RegisterLicense("MjcxMjA3QDMxMzgyZTMxMmUzMGswbzZwN05NV0tENnZ1cDZkWUxBYjFCN09udVJyNjVhVnNVR3hWejNvWkU9;MjcxMjA4QDMxMzgyZTMxMmUzMEsyL1hWVkxwc0xqbytmdmhaWjJQZEErQWE0M1FuaVRYYUNaNVMvSjZ5M1E9;MjcxMjA5QDMxMzgyZTMxMmUzMExyR0MrUkhWS290dTZsNnRIMDFWQlk4VUROY1BoQS8zSERzTnFyOEVHN2M9;MjcxMjEwQDMxMzgyZTMxMmUzMGhTc1BENlQwTFo1OHN1ckhKNEI5MW5YVWJJRkI3R2p6ekF1b3lFL2l4bXc9;MjcxMjExQDMxMzgyZTMxMmUzMFQzSTBCV3hFdTJXQmRpdDM2eDJmbjB1S1J6Vk5Qcjh6bGsxcDVqekFJeGs9;MjcxMjEyQDMxMzgyZTMxMmUzMEhDNUxLSW8zc2tZTnpNemNYRmJUZFlVYlFTYzcwNWozblJQTWtsQXBKMUk9;MjcxMjEzQDMxMzgyZTMxMmUzMGxJajc4TzN2L2x3eWJNYWhlK1Z2S3diSGRhOGMza0pVOVZKZHd4MmxqUlU9;MjcxMjE0QDMxMzgyZTMxMmUzMG5SbFZrVFgxM3ptdUFQWCtxWGNvVU96dUNDS2VJbG9rZjgwNmk1Z3BrSDQ9;MjcxMjE1QDMxMzgyZTMxMmUzMGowWWR6cmNSTmNPbHZ2ZWNqb1VDRUZLTTk4NFVTMDh5MTVBZXJqa2xhSEU9;NT8mJyc2IWhia31ifWN9ZmVoYmF8YGJ8ampqanNiYmlmamlmanMDHmggNCc2NjA2Ezs8Jz4yOj99MDw+;MjcxMjE2QDMxMzgyZTMxMmUzMEJHdUoxK2haSUlDSXp0R0VXMXV2WnY3OFJHWHFnVktabFBKS05vNGdmK0U9");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //endpoints.MapControllerRoute("default" , "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
