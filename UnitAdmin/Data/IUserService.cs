using System.Collections.Generic;
using UnitAdmin.Models;

namespace UnitAdmin.Data
{
    public interface IUserService
    {
        List<AppUser> GetAllUsers();
    }
}