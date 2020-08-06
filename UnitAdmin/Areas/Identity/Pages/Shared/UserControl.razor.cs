using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitAdmin.Models;

namespace UnitAdmin.Areas.Identity.Pages.Shared
{
    public partial class UserControl : ComponentBase
    {
        //private IEnumerable<AppUser> _SelectedMemberRoles;
        public string[] Items = new string[] { "moveTo" , "moveFrom" , "moveAllTo" , "moveAllFrom" };

        [Parameter]
        public string userId { get; set; }
        public AppUser Model { get; set; }

        [Parameter]
        public string ButtonText { get; set; } = "Save";

        [Parameter]
        public EventCallback ValidSubmit { get; set; }

        [Parameter]
        public EventCallback OnCancelClick { get; set; }

        [CascadingParameter] public Task<AuthenticationState> AuthenticationStateTask { get; set; }

        [Inject] RoleManager<AppRole> _roleManager { get; set; }
        [Inject] UserManager<AppUser> _userManager { get; set; }

        public IEnumerable<string> CurrentRoles;
        public IEnumerable<string> AvailableRoles;

        
    }
}
