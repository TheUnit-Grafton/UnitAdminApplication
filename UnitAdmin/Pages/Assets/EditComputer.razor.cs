using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Assets
{
    public partial class EditComputer : ComponentBase
    {

        [Parameter] public int id { get; set; }

        [Inject] IComputerService _context { get; set; }


        [Inject] NavigationManager navMan { get; set; }

        public ComputerModel model { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            model = await _context.GetComputerByIdAsync(id);
        }

        public async Task UpdateComputer()
        {
            await _context.UpdateComputerAsync(model);
            navMan.NavigateTo("/computers");
        }

        public void CancelClicked()
        {
            navMan.NavigateTo("/computers");
        }

        public async Task DeleteComputerAsync()
        {
            await _context.DeleteComputerAsync(model);
            navMan.NavigateTo("/computers");
        }

       
    }
}