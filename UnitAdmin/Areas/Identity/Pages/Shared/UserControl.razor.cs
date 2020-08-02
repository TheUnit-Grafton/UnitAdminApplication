using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnitAdmin.Models;

namespace UnitAdmin.Areas.Identity.Pages.Shared
{
    public partial class UserControl : ComponentBase
    {
        [Parameter]
        public AppUser Model { get; set; } //= new AppUser();

        [Parameter]
        public string ButtonText { get; set; } = "Save";

        [Parameter]
        public EventCallback ValidSubmit { get; set; }

        [Parameter]
        public EventCallback OnCancelClick { get; set; }

        [CascadingParameter] public Task<AuthenticationState> AuthenticationStateTask { get; set; }

        //[Inject] RevalidatingIdentityAuthenticationStateProvider<AppUser> _riasp { get; set; }
        //[Inject] SecurityService _security { get; set; }

        [Inject] RoleManager<AppRole> _roleManager { get; set; }
        [Inject] UserManager<AppUser> _userManager { get; set; }

        protected List<AppRole> roleList { get; set; }


        protected override async Task OnParametersSetAsync()
        {

            //TODO: Populate list of roles available
            //roleList = _roleManager.Roles.ToList();

            //if (userModel.RoleNames.Count() > 0)
            //{
            //    foreach (var role in userModel.RoleNames)
            //    {
            //        if (await IsInRole(role))
            //        {
            //            await roleList.Remove(userModel.Roles.);
            //        }
            //    }
            //}

        }

    }
}
