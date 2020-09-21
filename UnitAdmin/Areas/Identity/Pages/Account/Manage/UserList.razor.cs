using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnitAdmin.Data;
using UnitAdmin.Models;

namespace UnitAdmin.Areas.Identity.Pages.Account.Manage
{
    public partial class UserList : ComponentBase
    {
        [Inject] SecurityService _security { get; set; }
        [Inject] NavigationManager navMan { get; set; }

        protected List<AppUser> users;
        protected override async Task OnInitializedAsync()
        {
            users = (List<AppUser>)await _security.GetUsers();
        }
        public void EditUser(RecordDoubleClickEventArgs<AppUser> doubleClickArgs)
        {
            navMan.NavigateTo($"/admin/manage/user/{doubleClickArgs.RowData.Id}");
        }

        public void AddUser()
        {

        }
    }
}
