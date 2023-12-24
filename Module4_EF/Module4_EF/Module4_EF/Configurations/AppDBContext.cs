using Microsoft.EntityFrameworkCore;
using Module4_ModuleHW.DTO;

namespace Module4_ModuleHW.Configurations
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
    : base(options)
        {
        }

        public DbSet<Pet> Pet { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Owner> Owner { get; set; }

        public DbSet<Breed> Breed { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BreedConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfigurations());
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new OwnerConfigurations());
            modelBuilder.ApplyConfiguration(new PetConfiguration());
        }
    }
}
