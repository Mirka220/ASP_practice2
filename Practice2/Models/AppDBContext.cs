using Microsoft.EntityFrameworkCore;

namespace Practice2.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
              Database.EnsureCreated();
        }

        public DbSet<Home> Homes { get; set; }
        public DbSet<SpongeBobFriends> SpongeBobFriends { get; set; }

    }
}
