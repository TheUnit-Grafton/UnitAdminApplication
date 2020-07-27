using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using System.Collections.Generic;
using UnitAdmin.Models;
using UnitAdmin.Data;

namespace UnitAdmin.Areas.Identity.Pages.Account.Manage
{
    public partial class UserList : ComponentBase
    {
        [Inject] RevalidatingIdentityAuthenticationStateProvider<AppUser> _riasp { get; set; }
        [Inject] IUserService _users { get; set; }
        [Inject] NavigationManager navMan { get; set; }

        protected List<AppUser> users;
        protected override void OnInitialized()
        {
            users = _users.GetAllUsers();
        }
        public void EditUser(RecordDoubleClickEventArgs<AppUser> doubleClickArgs)
        {
            navMan.NavigateTo($"/user/{doubleClickArgs.RowData.Id}");
        }

        public void AddUser()
        {

        }
    }
}
