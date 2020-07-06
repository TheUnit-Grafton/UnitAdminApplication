using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using System.Collections.Generic;
using System.Linq;

namespace UnitAdmin.Pages.Members
{
    public partial class ListMembers : ComponentBase
    {
        private bool DisplayNonCurrent = false;
        private List<MemberModel> members;

        protected override void OnInitialized()
        {
            Update();
        }

        private void ToggleCurrentMembers()
        {
            DisplayNonCurrent = !DisplayNonCurrent;
        }

        private void Update()
        {
            if (DisplayNonCurrent)
            {
                members = _context.GetAllMembers().ToList();
            }
            else
            {
                members = _context.GetActiveMembers().ToList();
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
