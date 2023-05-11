using Microsoft.AspNetCore.Identity;

namespace VillaAPIproj.Models
{
   
   public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
