using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace UnitAdmin.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }


        [NotMapped]
        public IEnumerable<string> RoleNames { get; set; }

        //[IgnoreDataMember]
        //public override string PasswordHash { get; set; }

        [IgnoreDataMember, NotMapped]
        public string Password { get; set; }

        [IgnoreDataMember, NotMapped]
        public string ConfirmPassword { get; set; }

        [IgnoreDataMember, NotMapped]
        public string Name
        {
            get
            {
                return UserName;
            }
            set
            {
                UserName = value;
            }
        }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }
        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

    }
}

