using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Members
{
    public partial class EditMember
    {
        private MemberModel member;

        protected override void OnParametersSet()
        {
            member = _context.GetMember(id);
        }

        private void UpdateRecord()
        {
            _context.AddMember(member);
            navMan.NavigateTo("/members");
        }

        private void CancelUpdate()
        {
            navMan.NavigateTo("/members");
        }

        public void DeleteMember(MemberModel model)
        {
            _context.DeleteMember(model);
            navMan.NavigateTo("/members");
        }
    }
}
