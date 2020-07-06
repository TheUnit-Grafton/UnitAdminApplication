using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Announcements
{
    public partial class AddAnnouncement : ComponentBase
    {
        private AnnouncementModel model = new AnnouncementModel();

        [Parameter]
        public int Id { get; set; } = 0;

        protected override void OnInitialized()
        {
            if (Id != 0)
            {
                model = announcements.GetAnnouncementById(Id);
            }
        }

        public void SaveAnnouncement()
        {
            announcements.SaveAnnouncement(model);
            navMan.NavigateTo("/announcements");
        }
    }
}