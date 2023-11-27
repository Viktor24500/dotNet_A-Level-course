using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4_ModuleHW.DTO;

namespace Module4_ModuleHW.Configurations
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(h => h.locationId);
            builder.Property(p => p.locationName);
        }
    }
}
