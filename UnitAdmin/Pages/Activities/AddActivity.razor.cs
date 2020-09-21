using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Activities
{
    public partial class AddActivity : ComponentBase
    {
        private ActivityModel activity = new ActivityModel();

        protected async Task CreateActivityAsync()

        {
            await whatsOn.AddActivityAsync(activity);
            navMan.NavigateTo("/");
        }

        public void CancelClicked()
        {
            navMan.NavigateTo("/");
        }
    }
}