using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using UnitAdmin.Components;
using UnitAdmin.Models;

namespace UnitAdmin.Areas.Identity.Pages.Account
{
    public partial class SignUp : ComponentBase
    {
        [Inject] NavigationManager navman { get; set; }
        //[Inject] IJSRuntime jsruntime { get; set; }
        [Inject] ILogger<SignUp> _logger { get; set; }
        [Inject] RevalidatingIdentityAuthenticationStateProvider<AppUser> _riasp { get; set; }

        [CascadingParameter] public Task<AuthenticationState> AuthenticationStateTask { get; set; }
        [Parameter] public string ReturnUrl { get; set; } = "/";

        public AuthenticationState AuthState { get; set; }
        public ClaimsPrincipal CPUser { get; set; }
        public bool showSignUp { get; set; }
        public bool showConfirmation { get; set; }
        public string EmailConfirmationUrl { get; set; }


        /// <summary>
        /// Sign Up object for new user
        /// </summary>
        private DtoSignUp input { get; set; } = new DtoSignUp();

        /// <summary>
        /// Object to process a dictionary of errors per field and display them on form
        /// </summary>
        public ServerSideValidator serverSideValidator;

        public AppUser IdentityUser { get; set; }

        protected override async Task OnInitializedAsync()
        {
            AuthState = await AuthenticationStateTask;
            CPUser = AuthState.User;
            showSignUp = true;
        }

        /// <summary>
        /// Invoked by <EditForm> when submit button is clicked.
        /// </summary>
        /// <returns></returns>
        private async Task ValidSubmit()
        {
            var result = await SignUpUser();
            if (!result) return;
            showSignUp = false;

            EmailConfirmationUrl = await _riasp.GetUrl(IdentityUser , IdentityUser.Id, navman.BaseUri, "SignUpEmailConfirmed");
            showConfirmation = true;
            StateHasChanged();
            navman.NavigateTo("/");
        }

        private void InvalidSubmit()
        {
            _logger.LogInformation("Invalid Submit");
            return;
        }

        private async Task<bool> SignUpUser()
        {
            try
            {
                // Does the username currently exist?

                var user = await _riasp.FindByNameAsync(input.UserName);
                if (user != null)
                { //Already exists
                    serverSideValidator.AddError(input, nameof(input.UserName), "Sorry, try another username");
                    return false;
                }

                IdentityUser = new AppUser();

                // TODO: COmpete building user before submitting to create
                IdentityUser.Email = input.Email;
                IdentityUser.UserName = input.UserName;
                IdentityUser.FirstName = input.FirstName;
                IdentityUser.LastName = input.LastName;
                IdentityUser.Password = input.Password;

                // Actually writing the user details to database
                var result = await _riasp.CreateAsync(IdentityUser, input.Password);
                if (!result.Succeeded)
                {
                    serverSideValidator.AddError(input, result);
                    return false;
                }

                //Retrieve new user to get full info
                IdentityUser = await _riasp.FindByNameAsync(IdentityUser.UserName);

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("Internal Error {message}", ex.Message);
                throw ex;
            }
        }
    }

}
