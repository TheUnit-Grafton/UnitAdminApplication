using System.ComponentModel.DataAnnotations;

namespace UnitAdmin.Models
{
    public class DtoSignIn
    {
        [Required]
        [Display(Name = "Username")]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

        //TODO: this may need an attribute
        public string Token { get; set; }
    }
}
