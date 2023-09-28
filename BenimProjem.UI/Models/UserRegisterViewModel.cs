using System.ComponentModel.DataAnnotations;

namespace BenimProjem.UI.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your birthdate")]
        public DateOnly Birthdate { get; set; }

        public string Gender { get; set; } = "Do not want to specify";

        [Required(ErrorMessage = "Please Enter Your password")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter Your Password Again")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
