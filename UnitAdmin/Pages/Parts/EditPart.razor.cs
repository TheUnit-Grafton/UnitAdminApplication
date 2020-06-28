using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Parts
{
    public partial class EditPart
    {
        private PartModel partToEdit;

        protected override void OnParametersSet()
        {
            partToEdit = parts.GetPartById(id);
        }

        private void UpdateRecord()
        {
            parts.SavePart(partToEdit);
            navMan.NavigateTo("/parts");
        }

        private void CancelUpdate()
        {
            navMan.NavigateTo("/parts");
        }
    }
}
