using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitAdmin.Components;
using UnitAdmin.Models;

namespace UnitAdmin.Areas.Identity.Pages.Account
{
    public partial class SignIn : ComponentBase
    {
        /// <summary>
        /// Sign In object for new user
        /// </summary>
        private DtoSignIn input { get; set; } = new DtoSignIn();

        /// <summary>
        /// Object to process a dictionary of errors per field and display them on form
        /// </summary>
        public ServerSideValidator serverSideValidator;

        protected override async Task OnInitializedAsync()
        {
            AuthState = await AuthenticationStateTask;
            CPUser = AuthState.User;
        }

        /// <summary>
        /// Invoked by <EditForm> when submit button is clicked.
        /// </summary>
        /// <returns></returns>
        private async Task ValidSubmit()
        {
            // Does the username currently exist?
            var user = await _riasp.FindByNameAsync(input.Username);
            if (user == null)
            {
                serverSideValidator.AddError(input , nameof(input.Username) , "Sorry, couldn't find that Username");
                return;
            }

            var isPasswordOk = await _riasp.CheckPasswordAsync(user , input.Password);
            if (!isPasswordOk)
            {
                serverSideValidator.AddError(input , nameof(input.Password) , "Sorry, incorrect password");
                return;
            }

            var result = await _riasp.PasswordSignInAsync(user.UserName , input.Password , input.RememberMe , false);
            if (!result.Succeeded)
            {
                serverSideValidator.AddError(input , nameof(input.Username) , "Sorry, Could not Sign you in");
                return;
            }
            navman.NavigateTo(ReturnUrl);
            return;
        }

        private void InvalidSubmit()
        {
            return;
        }
    }
}
