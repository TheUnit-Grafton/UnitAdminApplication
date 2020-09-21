using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Activities
{
    public partial class EditActivity : ComponentBase
    {
        private ActivityModel activity { get; set; } = new ActivityModel();

        protected async override Task OnParametersSetAsync()
        {
            activity.Id = id;

            activity = await whatsOn.GetActivityAsync(activity.Id);
        }

        private async Task SaveActivityAsync()
        {
            await whatsOn.UpdateActivityAsync(activity);
            navMan.NavigateTo("/");
        }

        public void CancelClicked()
        {
            navMan.NavigateTo("/");
        }

        public async Task DeleteActivityAsync()
        {
            // TODO: Wrap Delete confirmation in SyncFusion Dialog box

            await whatsOn.DeleteActivityAsync(activity);

            // TODO: Add Exception Handling

            navMan.NavigateTo("/");
        }
    }
}