using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Assets
{
    public partial class AddComputer
    {
        private ComputerModel model = new ComputerModel();

        public void AddNewComputer()
        {
            _context.AddComputer(model);
            navMan.NavigateTo("/Computers");
        }

        public void CancelClicked()
        {
            navMan.NavigateTo("/Computers");
        }
    }
}