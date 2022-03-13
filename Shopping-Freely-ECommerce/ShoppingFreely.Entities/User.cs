using ShoppingFreely.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFreely.Entities
{
    public class User : BaseEntity
    {
        [Required(ErrorMessage = "Zorunlu alan")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Zorunlu alan")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Zorunlu alan")]
        public string MailAddress { get; set; }
        [Required(ErrorMessage = "Zorunlu alan")]
        [RegularExpression("^(?=.*[0-9])(?=.*[a-zA-Z])([a-zA-Z0-9]+)$", ErrorMessage = "Şifre büyük harf, küçük harf ve rakam içermelidir")]
        public string Password { get; set; }
        //[Compare(nameof(Password), ErrorMessage = "Şifreler uyuşmuyor")]
        //public string ConfirmPassword { get; set; }
        public ICollection<List> Lists{ get; set; }
    }
}