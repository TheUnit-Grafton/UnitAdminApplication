using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Activities
{
    public partial class EditActivity : ComponentBase
    {
        private ActivityModel activity { get; set; }

        protected async override Task OnParametersSetAsync()
        {
           activity = await whatsOn.GetActivityAsync(id);
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