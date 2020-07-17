using DataLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public class MemberService : IMemberService
    {
        private readonly UnitDataDbContext _context;

        public MemberService(UnitDataDbContext context)
        {
            _context = context;
        }
        public MemberModel AddMember(MemberModel member)
        {
            _context.Members.Add(member);
            _context.SaveChanges();
            return member;
        }

        public async Task<MemberModel> AddMemberAsync(MemberModel member)
        {
            _context.Members.Add(member);
            await _context.SaveChangesAsync();
            return member;
        }

        public void UpdateMember(MemberModel member)
        {
            _context.Members.Attach(member);
            _context.Entry(member).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public async Task UpdateMemberAsync(MemberModel member)
        {
            _context.Members.Attach(member);
            _context.Entry(member).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public IEnumerable<MemberModel> GetActiveMembers()
        {
            IEnumerable<MemberModel> output = _context.Members.Where(x => x.IsActive == true).OrderBy(n => n.LastName);
            return output.ToList();
        }

        public async Task<IEnumerable<MemberModel>> GetActiveMembersAsync()
        {
            return await _context.Members.Where(x => x.IsActive == true).OrderBy(n => n.LastName).ToListAsync();
        }

        public IEnumerable<MemberModel> GetAllMembers()
        {
            IEnumerable<MemberModel> output = _context.Members.OrderBy(n => n.LastName);
            return output.ToList();
        }

        public async Task<IEnumerable<MemberModel>> GetAllMembersAsync()
        {
            return await _context.Members.OrderBy(n => n.LastName).ToListAsync();
        }

        public MemberModel GetMember(int id)
        {
            return _context.Members.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task<MemberModel> GetMemberAsync(int id)
        {
            return await _context.Members.Where(x => x.Id == id).FirstOrDefaultAsync();
        }


        public void DeleteMember(MemberModel member)
        {
            _context.Members.Remove(member);
            _context.SaveChanges();

        }

        public async Task DeleteMemberAsync(MemberModel member)
        {
            _context.Members.Remove(member);
            await _context.SaveChangesAsync();

        }
    }
}