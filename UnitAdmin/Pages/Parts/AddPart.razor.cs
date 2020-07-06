using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Parts
{
    public partial class AddPart : ComponentBase
    {
        
        public PartModel model { get; set; } = new PartModel();

        private void SavePart()
        {
            parts.SavePart(model);
            navMan.NavigateTo("/Parts");
        }

        public void CancelClicked()
        {
            navMan.NavigateTo("/Parts");
        }

        public void RemovePart()
        {
            parts.DeletePart(model);
            navMan.NavigateTo("/Parts");
        }
    }
}