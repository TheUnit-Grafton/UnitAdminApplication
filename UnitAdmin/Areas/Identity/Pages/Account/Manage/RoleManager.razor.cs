using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitAdmin.Models;

namespace UnitAdmin.Areas.Identity.Pages.Account.Manage
{
    public partial class RoleManager : ComponentBase
    {
        [Inject]
        public UserManager<AppUser> _userManager { get; set; }

        protected List<AppRole> roleList;
        private AppRole _role = new AppRole();

        [Inject]
        private RoleManager<AppRole> _roleManager { get; set; }

        protected override async Task OnInitializedAsync()
        {

            //roleList = await Task.Run(() => (_roleManager.Roles.ToList()));
            roleList = _roleManager.Roles.ToList();
        }

        private async Task SaveRoleAsync()
        {
            var findRole = await _roleManager.FindByIdAsync(_role.Id);

            if (findRole == null)
            {
                // There is no Id, so this is a new Role
                roleList.Add(_role);
                await _roleManager.CreateAsync(_role);
                _role = new AppRole();
                // StateHasChanged();

            }
            else
            {
                // Update the existing role

                await _roleManager.UpdateAsync(_role);
                _role = new AppRole();

                // StateHasChanged();

            }
        }

        private void OnCancelClick()
        {
            _role = new AppRole();
        }


    }
}
