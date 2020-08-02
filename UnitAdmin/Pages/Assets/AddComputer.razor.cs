using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Assets
{
    public partial class AddComputer : ComponentBase
    {
        private ComputerModel model = new ComputerModel();

        public async Task AddNewComputer()
        {
            await _context.AddComputerAsync(model);
            navMan.NavigateTo("/Computers");
        }

        public void CancelClicked()
        {
            navMan.NavigateTo("/Computers");
        }
    }
}