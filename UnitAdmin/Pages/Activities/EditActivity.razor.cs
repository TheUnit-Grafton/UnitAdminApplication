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

        protected override void OnParametersSet()
        {
            activity = whatsOn.GetActivity(id);
        }

        private void SaveActivity()
        {
            whatsOn.UpdateActivity(activity);
            navMan.NavigateTo("/");
        }

        public void CancelClicked()
        {
            navMan.NavigateTo("/");
        }

        public void DeleteActivity()
        {
            // TODO: Wrap Delete confirmation in SyncFusion Dialog box

            whatsOn.DeleteActivity(activity);

            // TODO: Add Exception Handling

            navMan.NavigateTo("/");
        }
    }
}