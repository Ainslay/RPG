using Microsoft.EntityFrameworkCore;
using RPG.API.Model;
using RPG.API.Model.Configurations;

namespace RPG.API.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Item> Items { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new PlayerConfiguration());
        }
    }
}
