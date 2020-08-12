using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using System.Collections.Generic;
using UnitAdmin.Data;
using UnitAdmin.Models;

namespace UnitAdmin.Areas.Identity.Pages.Account.Manage
{
    public partial class UserList : ComponentBase
    {
        [Inject] SecurityService _security { get; set; }
        [Inject] NavigationManager navMan { get; set; }

        protected IEnumerable<AppUser> users;
        protected override void OnInitialized()
        {
            users = (IEnumerable<AppUser>)_security.GetUsers();
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
