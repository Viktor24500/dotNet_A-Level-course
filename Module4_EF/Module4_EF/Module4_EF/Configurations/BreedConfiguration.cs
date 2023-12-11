using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4_ModuleHW.DTO;

namespace Module4_ModuleHW.Configurations
{
    public class BreedConfiguration : IEntityTypeConfiguration<Breed>
    {
        public void Configure(EntityTypeBuilder<Breed> builder) 
        {
            builder.HasKey(h => h.BreedId);
            builder.Property(p => p.BreedName);
            builder.Property(p => p.CategoryId);

            //1 Category - Many Breeds
            builder.HasOne(h => h.Category)
                .WithMany(b => b.Breeds)
                .HasForeignKey(b => b.CategoryId);
        }
    }
}
