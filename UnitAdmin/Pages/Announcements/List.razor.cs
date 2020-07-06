using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Announcements
{
    public partial class List : ComponentBase
    {
        private List<AnnouncementModel> _announcements;
        private bool displayNonCurrent = false;

        protected override void OnInitialized()
        {
            UpdateAnnouncements();
        }

        public void UpdateAnnouncements()
        {
            if (displayNonCurrent)
            {
                // Display all items - Non-Current checkbox is ticked
                _announcements = notices.GetAnnouncements(true);
            }
            else
            {
                // Only return currennt items
                _announcements =  notices.GetAnnouncements(false);
            }
        }

        public void ToggleNonCurrentDisplay()
        {
            displayNonCurrent = !displayNonCurrent;
            UpdateAnnouncements();
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