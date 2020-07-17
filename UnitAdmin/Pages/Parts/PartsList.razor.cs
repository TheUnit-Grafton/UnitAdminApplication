using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Parts
{
    public partial class PartsList : ComponentBase
    {
        [Inject]
        private IPartsService _Parts { get; set; }

        [Inject]
        private NavigationManager navMan { get; set; }

        private List<PartModel> parts { get; set; }

        protected override async Task OnInitializedAsync()
        {
            parts = (List<PartModel>)await _Parts.GetPartsInStockAsync();
        }

        public void AddPart()
        {
            navMan.NavigateTo("/parts/add");
        }

        public void EditAsset(RecordDoubleClickEventArgs<PartModel> args)
        {
            navMan.NavigateTo($"/parts/{args.RowData.Id}");
        }
    }
}