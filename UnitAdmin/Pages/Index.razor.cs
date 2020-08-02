using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnitAdmin.Pages
{
    public partial class Index : ComponentBase
    {
        private List<ActivityModel> _activities;
        private List<AnnouncementModel> _announcements;

        public bool DisplayNonCurrent = false;

        protected async override Task OnInitializedAsync()
        {
            await Update();
        }

        public void AddActivity()
        {
            navMan.NavigateTo("/Activity/Add");
        }

        public async Task ToggleCurrentActivities()
        {
            DisplayNonCurrent = !DisplayNonCurrent;
            await Update();
        }

        private async Task Update()
        {
            _activities = await whatsOn.GetActivitiesAsync(DisplayNonCurrent);
            _announcements = await notices.GetAnnouncementsAsync(false); // Only return current announcements to Index page
        }


    }
}