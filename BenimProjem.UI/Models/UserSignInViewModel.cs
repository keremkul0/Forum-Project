using System.ComponentModel.DataAnnotations;

namespace BenimProjem.UI.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Pleas enter your username")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Pleas enter your Password")]
        public string Password { get; set; } = string.Empty;
    }
}
