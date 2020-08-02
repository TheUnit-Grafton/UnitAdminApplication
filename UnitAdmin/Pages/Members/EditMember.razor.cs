using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Members
{
    public partial class EditMember : ComponentBase
    {
        private MemberModel member;

        protected override async Task OnParametersSetAsync()
        {
            member = await _context.GetMemberAsync(id);
        }

        private async Task UpdateRecord()
        {
            await _context.AddMemberAsync(member);
            navMan.NavigateTo("/members");
        }

        private void CancelUpdate()
        {
            navMan.NavigateTo("/members");
        }

        public async Task DeleteMember(MemberModel model)
        {
            await _context.DeleteMemberAsync(model);
            navMan.NavigateTo("/members");
        }
    }
}
