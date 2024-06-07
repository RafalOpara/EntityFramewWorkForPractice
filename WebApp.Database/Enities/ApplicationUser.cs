using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Database
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}


        [NotMapped]
        public virtual List<Setting> Settings {get;set;}
    }
}
