using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UnitAdmin.Models;

namespace UnitAdmin.Data
{
    public class SecurityService
    {
        private readonly SignInManager<AppUser> signInManager;
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<AppRole> roleManager;
        //private readonly IWebHostEnvironment env;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly NavigationManager uriHelper;
        private readonly AuthenticationStateProvider authenticationStateProvider;

        public SecurityService(AuthDbContext context ,
            //IWebHostEnvironment env,
            UserManager<AppUser> userManager ,
            RoleManager<AppRole> roleManager ,
            SignInManager<AppUser> signInManager ,
            IHttpContextAccessor httpContextAccessor ,
            NavigationManager uriHelper ,
            AuthenticationStateProvider authenticationStateProvider)
        {
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            //this.env = env;
            this.httpContextAccessor = httpContextAccessor;
            this.uriHelper = uriHelper;
            this.authenticationStateProvider = authenticationStateProvider;
        }

        public AuthDbContext context { get; set; }

        private AppUser user;

        public AppUser User
        {
            get
            {
                var name = Principal.Identity.Name;

                if (name == null)
                {
                    return new AppUser { LastName = "Anonymous" };
                }

                if (user == null && name != null)
                {
                    user = userManager.FindByEmailAsync(name).Result;
                }

                return user;
            }
        }

        public ClaimsPrincipal Principal
        {
            get
            {
                return authenticationStateProvider.GetAuthenticationStateAsync().Result.User;
            }
        }

        public bool IsInRole(params string[] roles)
        {
            if (roles.Contains("Everybody"))
            {
                return true;
            }

            if (!IsAuthenticated())
            {
                return false;
            }

            if (roles.Contains("Authenticated"))
            {
                return true;
            }

            return roles.Any(role => Principal.IsInRole(role));
        }

        public bool IsAuthenticated()
        {
            return Principal.Identity.IsAuthenticated;
        }

        public async Task Logout()
        {
            await Task.Run(() => uriHelper.NavigateTo("Account/Logout" , true));
        }

        public async Task<bool> Login(string userName , string password)
        {
            await Task.Run(() => uriHelper.NavigateTo("Login" , true));

            return true;
        }

        public async Task<IEnumerable<AppRole>> GetRoles()
        {
            return await Task.FromResult(roleManager.Roles);
        }

        public async Task<AppRole> CreateRole(AppRole role)
        {
            var result = await roleManager.CreateAsync(role);

            EnsureSucceeded(result);

            return role;
        }

        public async Task<IdentityRole> DeleteRole(string id)
        {
            var item = context.Roles
                .Where(i => i.Id == id)
                .FirstOrDefault();

            context.Roles.Remove(item);
            await context.SaveChangesAsync();

            return item;
        }

        public async Task<IdentityRole> GetRoleById(string id)
        {
            return await Task.FromResult(context.Roles.Find(id));
        }

        public async Task<IEnumerable<IdentityUser>> GetUsers()
        {
            return await Task.FromResult(context.Users);
        }

        public async Task<AppUser> CreateUser(AppUser user)
        {
            user.UserName = user.Email;

            var result = await userManager.CreateAsync(user , user.Password);

            EnsureSucceeded(result);

            var roles = user.RoleNames;

            if (roles != null && roles.Any())
            {
                result = await userManager.AddToRolesAsync(user , roles);
                EnsureSucceeded(result);
            }

            user.RoleNames = roles;

            return user;
        }

        public async Task<AppUser> DeleteUser(string id)
        {
            IdentityUser item = context.Users
              .Where(i => i.Id == id)
              .FirstOrDefault();

            context.Users.Remove(item);
            await context.SaveChangesAsync();

            return (AppUser)item; // This cast is safe because AppUser inherits from IdentiyUser
        }

        public async Task<AppUser> GetUserById(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user != null)
            {
                user.RoleNames = await userManager.GetRolesAsync(user);
            }

            return await Task.FromResult(user);
        }

        public async Task<AppUser> UpdateUser(string id , AppUser user)
        {
            var roles = user.RoleNames.ToArray();

            var result = await userManager.RemoveFromRolesAsync(user , await userManager.GetRolesAsync(user));

            EnsureSucceeded(result);

            if (roles.Any())
            {
                result = await userManager.AddToRolesAsync(user , roles);

                EnsureSucceeded(result);
            }

            result = await userManager.UpdateAsync(user);

            EnsureSucceeded(result);

            if (!String.IsNullOrEmpty(user.Password) && user.Password == user.ConfirmPassword)
            {
                result = await userManager.RemovePasswordAsync(user);

                EnsureSucceeded(result);

                result = await userManager.AddPasswordAsync(user , user.Password);

                EnsureSucceeded(result);
            }

            return user;
        }

        private void EnsureSucceeded(IdentityResult result)
        {
            if (!result.Succeeded)
            {
                var message = string.Join(", " , result.Errors.Select(error => error.Description));

                throw new ApplicationException(message);
            }
        }
    }
}
