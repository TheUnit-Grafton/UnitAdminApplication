using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Members
{
    public partial class AddMember : ComponentBase
    {
        private MemberModel newMember = new MemberModel();

        public async Task SaveMemberAsync()
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
