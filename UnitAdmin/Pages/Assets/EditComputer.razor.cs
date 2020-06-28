using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Assets
{
    public partial class EditComputer
    {

        [Parameter]
        public int id { get; set; }

        public ComputerModel model { get; set; }

        protected override void OnParametersSet()
        {
            model = _context.GetComputerById(id);
        }

        public void UpdateComputer()
        {
            _context.UpdateComputer(model);
            navMan.NavigateTo("/computers");
        }

        public void CancelClicked()
        {
            navMan.NavigateTo("/computers");
        }

        public void DeleteComputer()
        {
            _context.DeleteComputer(model);
            navMan.NavigateTo("/computers");
        }
    }
}