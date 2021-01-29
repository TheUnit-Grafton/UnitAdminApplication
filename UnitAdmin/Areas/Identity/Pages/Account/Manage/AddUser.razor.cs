using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitAdmin.Data;
using UnitAdmin.Models;

namespace UnitAdmin.Areas.Identity.Pages.Account.Manage
{
    public partial class AddUser : ComponentBase
    {
        [Inject] NavigationManager _nav { get; set; }
        [Inject] SecurityService _security { get; set; }
        [Inject] RevalidatingIdentityAuthenticationStateProvider<AppUser> _riasp { get; set; }

        [Parameter] public AppUser newUser { get; set; } = new AppUser();


        private async Task CreateUser(AppUser newUser)
        {
            newUser = await _security.CreateUser(newUser);
            _nav.NavigateTo("admin/manage/users");
        }

        public void CancelClicked()
        {
            _nav.NavigateTo("/admin/manage/users");
        }
    }
}
