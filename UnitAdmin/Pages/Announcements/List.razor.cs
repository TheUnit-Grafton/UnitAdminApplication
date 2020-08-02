using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Announcements
{
    public partial class List : ComponentBase
    {
        private List<AnnouncementModel> _announcements;
        private bool displayNonCurrent = false;

        protected async override Task OnInitializedAsync()
        {
            await UpdateAnnouncements();
        }

        public async Task UpdateAnnouncements()
        {
            if (displayNonCurrent)
            {
                // Display all items - Non-Current checkbox is ticked
                _announcements = await notices.GetAnnouncementsAsync(true);
            }
            else
            {
                // Only return currennt items
                _announcements = await notices.GetAnnouncementsAsync(false);
            }
        }

        public async Task ToggleNonCurrentDisplay()
        {
            displayNonCurrent = !displayNonCurrent;
            await UpdateAnnouncements();
        }

        public void EditAnnouncement(RecordDoubleClickEventArgs<AnnouncementModel> args)
        {
            if (args != null)
            {
                navMan.NavigateTo($"/announcements/{args.RowData.Id}");
            }
        }

        public void AddAnnouncement()
        {
            navMan.NavigateTo("/announcements/add");
        }
    }
}