using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using System.Collections.Generic;
using UnitAdmin.Data;
using UnitAdmin.Models;

namespace UnitAdmin.Areas.Identity.Pages.Account.Manage
{
    public partial class UserList : ComponentBase
    {
        [Inject] IUserService _users { get; set; }
        [Inject] NavigationManager navMan { get; set; }

        protected List<AppUser> users;
        protected override void OnInitialized()
        {
            users = _users.GetAllUsers();
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
