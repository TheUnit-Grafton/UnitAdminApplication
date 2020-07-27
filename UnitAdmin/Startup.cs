using DataLibrary.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
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
                 options.SignIn.RequireConfirmedAccount = true;
                 options.User.RequireUniqueEmail = true;
                 
                 options.SignIn.RequireConfirmedEmail = false;
                 
             })
                .AddUserManager<UserManager<AppUser>>()
                .AddRoles<AppRole>()
                .AddEntityFrameworkStores<AuthDbContext>();

            // Required for the SyncFusion File Upload control to function
            services.AddMvc(option => option.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            
            services.AddRazorPages();
            services.AddServerSideBlazor();

            // Add SyncFusion Community Blazor controls
            services.AddSyncfusionBlazor();

            // Ensure correct Auth provider is being used with correct options
            //services.AddScoped<AuthenticationStateProvider , RevalidatingIdentityAuthenticationStateProvider<AppUser>>();

            #region Box 2
            services.AddScoped<RevalidatingIdentityAuthenticationStateProvider<AppUser>>();
            services.AddScoped<AuthenticationStateProvider>(s => s.GetRequiredService<RevalidatingIdentityAuthenticationStateProvider<AppUser>>());
            services.AddScoped<IHostEnvironmentAuthenticationStateProvider>(sp =>
            {
                // this is safe because 
                //     the `RevalidatingIdentityAuthenticationStateProvider` extends the `ServerAuthenticationStateProvider`
                var provider = (ServerAuthenticationStateProvider)sp.GetRequiredService<AuthenticationStateProvider>();
                return provider;
            });

            #endregion

            services.AddScoped<SecurityService>();

            // Add fake Email sender for Identity
            // TODO: Replace mock email sender with real implementation
            services.AddSingleton<IEmailSender , MockEmailSender>();
            services.AddScoped<IUserTwoFactorTokenProvider<AppUser> , MockTwoFactorAuthTokenProvider>();

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
                .RegisterLicense(Constants.SFLicense);

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
            //app.UseMvcWithDefaultRoute();

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
