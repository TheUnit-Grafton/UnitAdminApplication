using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitAdmin.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
