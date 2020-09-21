using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Members
{
    public partial class AddMember : ComponentBase
    {
        private MemberModel newMember = new MemberModel();

        public async Task SaveMember()
        {
            await _context.AddMemberAsync(newMember);
            navMan.NavigateTo("/members");
        }

        public void CancelClicked()
        {
            navMan.NavigateTo("/members");
        }
    }
}
