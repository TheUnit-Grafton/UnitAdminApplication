using DataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IMemberService
    {
        MemberModel AddMember(MemberModel member);
        Task<MemberModel> AddMemberAsync(MemberModel member);
        void DeleteMember(MemberModel member);
        Task DeleteMemberAsync(MemberModel member);
        IEnumerable<MemberModel> GetActiveMembers();
        Task<IEnumerable<MemberModel>> GetActiveMembersAsync();
        IEnumerable<MemberModel> GetAllMembers();
        Task<IEnumerable<MemberModel>> GetAllMembersAsync();
        MemberModel GetMember(int id);
        Task<MemberModel> GetMemberAsync(int id);
        void UpdateMember(MemberModel member);
        Task UpdateMemberAsync(MemberModel member);
    }
}