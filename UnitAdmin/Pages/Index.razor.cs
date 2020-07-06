using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace UnitAdmin.Pages
{
    public partial class Index : ComponentBase
    {
        private List<ActivityModel> _activities;
        private List<AnnouncementModel> _announcements;

        public bool DisplayNonCurrent = false;

        protected override void OnInitialized()
        {
           Update();
        }

        public void AddActivity()
        {
            navMan.NavigateTo("/Activity/Add");
        }

        public void ToggleCurrentActivities()
        {
            DisplayNonCurrent = !DisplayNonCurrent;
            Update();
        }

        private void Update()
        {
            _activities =  whatsOn.GetActivities(DisplayNonCurrent);
            _announcements = notices.GetAnnouncements(false); // Only return current announcements to Index page
        }

   
    }
}