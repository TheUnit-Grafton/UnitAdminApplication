using DataLibrary.Models;
using System.Collections.Generic;

namespace DataLibrary.Data
{
    public interface IMemberService
    {
        MemberModel AddMember(MemberModel member);
        void DeleteMember(MemberModel member);
        IEnumerable<MemberModel> GetActiveMembers();
        IEnumerable<MemberModel> GetAllMembers();
        MemberModel GetMember(int id);
        void UpdateMember(MemberModel member);
    }
}