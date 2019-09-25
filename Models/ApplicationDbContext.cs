using Microsoft.EntityFrameworkCore;

namespace ClassProject.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options) { }
        public DbSet<AnimalRescue> AnimalRescues { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Preference> Preferences { get; set; }
    }
}
