using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4_ModuleHW.DTO;

namespace Module4_ModuleHW.Configurations
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.HasKey(h => h.petId);
            builder.Property(p => p.petName);
            builder.Property(p => p.categoryId);
            builder.Property(p => p.breedId);
            builder.Property(p => p.petAge);
            builder.Property(p => p.locationId);
            builder.Property(p => p.imageUrl);
            builder.Property(p => p.petDescription);

            //1 Category - Many Pets
            builder.HasOne(h => h.Category)
                .WithMany(b => b.Pets)
                .HasForeignKey(b => b.categoryId);

            //1 Breed - Many Pets
            builder.HasOne(h => h.Breed)
                .WithMany(b => b.Pets)
                .HasForeignKey(b => b.breedId);

            //1 Location - Many Pets
            builder.HasOne(h => h.Location)
                .WithMany(b => b.Pets)
                .HasForeignKey(b => b.locationId);

            //1 Owner - Many Pets
            builder.HasOne(h => h.Owner)
                .WithMany(b => b.Pets)
                .HasForeignKey(b => b.ownerId);
        }
    }
}
