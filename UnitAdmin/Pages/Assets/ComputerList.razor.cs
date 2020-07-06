using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using System.Collections.Generic;
using System.Linq;

namespace UnitAdmin.Pages.Assets
{
    public partial class ComputerList : ComponentBase
    {
        private List<ComputerModel> computers { get; set; }

        protected override void OnInitialized()
        {
            computers = _computers.GetCurrentComputers().ToList();
        }

        public void AddComputer()
        {
            navMan.NavigateTo("/computers/add");
        }

        public void EditAsset(RecordDoubleClickEventArgs<ComputerModel> doubleClickArgs)
        {
            navMan.NavigateTo($"/computers/{doubleClickArgs.RowData.Id}");
        }
    }
}