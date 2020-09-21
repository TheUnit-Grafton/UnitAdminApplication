using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using UnitAdmin.Models;

namespace UnitAdmin.Data
{
    public class MockTwoFactorAuthTokenProvider : IUserTwoFactorTokenProvider<AppUser>

    {
        public Task<bool> CanGenerateTwoFactorTokenAsync(UserManager<AppUser> manager , AppUser user)
        {
            return (Task<bool>)Task.CompletedTask;
        }

        public Task<string> GenerateAsync(string purpose , UserManager<AppUser> manager , AppUser user)
        {
            return (Task<string>)Task.CompletedTask;
        }

        public Task<bool> ValidateAsync(string purpose , string token , UserManager<AppUser> manager , AppUser user)
        {
            return (Task<bool>)Task.CompletedTask;
        }
    }
}
