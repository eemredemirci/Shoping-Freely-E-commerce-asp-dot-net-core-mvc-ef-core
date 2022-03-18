﻿using System.ComponentModel.DataAnnotations;

namespace ShoppingFreelyMVC.Models.Authentication
{
    public class UserRegistrationDto
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [RegularExpression("^(?=.*[0-9])(?=.*[a-zA-Z])([a-zA-Z0-9]+)$", ErrorMessage = "Şifre büyük harf, küçük harf ve rakam içermelidir")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required")]
        [Compare("Password", ErrorMessage = "The Password and Confirm Password do not match.")]
        public string ConfirmPassword { get; set; }

    }
}
