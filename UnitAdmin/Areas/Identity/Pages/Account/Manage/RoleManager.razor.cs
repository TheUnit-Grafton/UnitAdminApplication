using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitAdmin.Data;
using UnitAdmin.Models;

namespace UnitAdmin.Areas.Identity.Pages.Account.Manage
{
    public partial class RoleManager : ComponentBase
    {
        protected List<AppRole> roleList;
        private AppRole _role = new AppRole();

        [Inject]
        private SecurityService _security { get; set; }

        protected override async Task OnInitializedAsync()
        {

            //roleList = await Task.Run(() => (_roleManager.Roles.ToList()));
            var roles = await _security.GetRoles();

            roleList = roles.ToList();
        }

        private async Task SaveRoleAsync()
        {
            //var findRole = await _security.FindByIdAsync(_role.Id);

            //if (findRole == null)
            //{
            //    // There is no Id, so this is a new Role

            roleList.Add(_role); // Add the new role to the list
            await _security.CreateRole(_role); // Use the security service to add the new Role to the database
            _role = new AppRole();
            //}
            //else
            //{
            //    // Update the existing role
            //    await _roleManager.UpdateAsync(_role);
            //    _role = new AppRole();

            //}
            // await InvokeAsync(StateHasChanged);

            await OnInitializedAsync(); //Refresh the data on the screen
        }

        private void OnCancelClick()
        {
            _role = new AppRole();
        }


    }
}
