using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Database
{
    public class WebAppDbContext:IdentityDbContext<ApplicationUser>
    {
        public DbSet<Setting> Settings { get; set; }

        public WebAppDbContext(DbContextOptions<WebAppDbContext> options) : base(options)
        {

        }

        
    }
}
