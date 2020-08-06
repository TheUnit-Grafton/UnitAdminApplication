using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Threading.Tasks;
using UnitAdmin.Data;
using UnitAdmin.Models;

namespace UnitAdmin.Areas.Identity.Pages.Account.Manage
{
    public partial class EditUser : ComponentBase
    {
        [CascadingParameter] public Task<AuthenticationState> AuthenticationStateTask { get; set; }

        [Parameter] public string name { get; set; } = "";

        [Inject] NavigationManager _nav { get; set; }
        [Inject] SecurityService _security { get; set; }
        [Inject] RevalidatingIdentityAuthenticationStateProvider<AppUser> _riasp { get; set; }


        protected AppUser userModel { get; set; } = new AppUser();

        protected override async Task OnParametersSetAsync()
        {
            userModel = await _riasp.FindByNameAsync(name);
        }

        public async Task UpdateUser()
        {
            userModel = await _security.UpdateUser(userModel.Id, userModel);
            _nav.NavigateTo("admin/manage/users");
        }

        public void CancelClicked()
        {
            _nav.NavigateTo("/admin/manage/users");
        }
    }
}
