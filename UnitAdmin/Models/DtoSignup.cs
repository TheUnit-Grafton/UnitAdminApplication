using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnitAdmin.Models
{
    /// <summary>
    /// Model modved from the SignUp control to adhere to programming standards.
    /// </summary>

    public class DtoSignUp
    {
        //[Required]
        //[MinLength(6, ErrorMessage = "The {0} must be at least 6 characters")]
        //[StringLength(64, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        //[RegularExpression(@"[^\s]+", ErrorMessage = "Spaces are not permitted.")]
        //[Display(Name = "User Name")]
        //public string UserName { get; set; }

        [Required]
        [MinLength(6 , ErrorMessage = "The {0} must be at least 6 characters")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100 , ErrorMessage = "The {0} must be at least {2} and at max {1} characters long." , MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm password")]
        //[CompareProperty("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

}
