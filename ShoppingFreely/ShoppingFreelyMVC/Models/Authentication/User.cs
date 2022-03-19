using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ShoppingFreelyMVC.Models.Authentication
{
    public class User : IdentityUser
    {
        public User()
        {
            ShoppingLists = new HashSet<ShoppingList>();
        }
        public ICollection<ShoppingList> ShoppingLists { get; set; }
    }
}
