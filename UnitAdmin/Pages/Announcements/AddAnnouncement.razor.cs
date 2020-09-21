using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Announcements
{
    public partial class AddAnnouncement : ComponentBase
    {
        private AnnouncementModel model = new AnnouncementModel();

        [Parameter]
        public int Id { get; set; } = 0;

        protected override async Task OnInitializedAsync()
        {
            if (Id != 0)
            {
                model = await announcements.GetAnnouncementByIdAsync(Id);
            }
        }

        public async Task SaveAnnouncementAsync()
        {
            await announcements.SaveAnnouncementAsync(model);
            navMan.NavigateTo("/announcements");
        }
    }
}