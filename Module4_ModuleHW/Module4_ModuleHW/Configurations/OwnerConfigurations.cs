using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4_ModuleHW.DTO;

namespace Module4_ModuleHW.Configurations
{
    public class OwnerConfigurations : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.HasKey(h => h.OwnerId);
            builder.Property(p => p.OwnerName);
            builder.Property(p => p.OwnerSurname);
        }
    }
}
