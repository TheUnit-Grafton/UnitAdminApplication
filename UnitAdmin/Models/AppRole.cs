using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitAdmin.Models
{
    public class AppRole : IdentityRole
    {
        public AppRole() { }

        public AppRole(string roleName)
            : base(roleName) { }

        public virtual ICollection<IdentityRoleClaim<string>> Claims { get; set; }

    }
}
