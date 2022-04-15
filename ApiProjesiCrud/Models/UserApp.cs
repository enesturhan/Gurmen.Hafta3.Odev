using Microsoft.AspNetCore.Identity;

namespace ApiProjesiCrud.Models
{
    public class UserApp:IdentityUser
    {
        public string City { get; set; }
    }
}
