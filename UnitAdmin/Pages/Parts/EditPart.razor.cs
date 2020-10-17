using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Parts
{
    public partial class EditPart : ComponentBase
    {
        private PartModel partToEdit = new PartModel();

        protected override async Task OnParametersSetAsync()
        {
            partToEdit = await parts.GetPartByIdAsync(id);
        }

        private async Task UpdateRecord()
        {
            await parts.SavePartAsync(partToEdit);
            navMan.NavigateTo("/parts");
        }

        private void CancelUpdate()
        {
            navMan.NavigateTo("/parts");
        }

        private void DeleteRecord()
        {
            parts.DeletePart(partToEdit);
            navMan.NavigateTo("/parts");
        }
    }
}
