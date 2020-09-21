using System.Collections.Generic;
using System.Linq;
using UnitAdmin.Models;

namespace UnitAdmin.Data
{
    public class UserService : IUserService
    {
        private readonly AuthDbContext _context;

        public UserService(AuthDbContext context)
        {
            _context = context;
            ;
        }

        public List<AppUser> GetAllUsers()
        {
            return _context.appUsers.ToList();
        }
    }
}
