using System.ComponentModel.DataAnnotations;

namespace ShoppingFreely.UI.MVC.Models
{
    public class UserRegistrationViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(" ^ (?=.*[0 - 9])(?=.*[a - zA - Z])([a - zA - Z0 - 9] +)$", ErrorMessage = "Password must have A-Z, a-z, 0-9 and '-._@+'")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required")]
        [Compare("Password", ErrorMessage = "The Password and Confirm Password do not match.")]
        public string ConfirmPassword { get; set; }

    }
}
