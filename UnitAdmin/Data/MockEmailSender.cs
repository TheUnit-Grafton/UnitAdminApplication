using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;
namespace UnitAdmin.Data
{
    public class MockEmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email , string subject , string htmlMessage)
        {
            return Task.CompletedTask;
        }
    }
}
