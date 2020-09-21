using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

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
