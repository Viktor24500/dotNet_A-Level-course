using Catalog.Host.Data.Entities;

namespace Catalog.Host.Data.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(h => h.brandID);
            builder.Property(p => p.brandName);
        }
    }
}
