using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Members
{
    public partial class ListMembers : ComponentBase
    {
        private bool DisplayNonCurrent = false;
        private List<MemberModel> members;

        protected override async Task OnInitializedAsync()
        {
            await Update();
        }

        private void ToggleCurrentMembers()
        {
            DisplayNonCurrent = !DisplayNonCurrent;
        }

        private async Task Update()
        {
            if (DisplayNonCurrent)
            {
                members = (List<MemberModel>)await _context.GetAllMembersAsync();
            }
            else
            {
                members = (List<MemberModel>)await _context.GetActiveMembersAsync();
            }
        }

        public void EditMember(RecordDoubleClickEventArgs<MemberModel> doubleClickArgs)
        {
            navMan.NavigateTo($"/members/{doubleClickArgs.RowData.Id}");
        }

        public void AddMember()
        {
            navMan.NavigateTo("/members/add");
        }

        public void OnCancelClick()
        {
            navMan.NavigateTo("/members");
        }
    }
}
