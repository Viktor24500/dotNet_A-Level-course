using Catalog.Host.Data.Entities;

namespace Catalog.Host.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(h => h.categoryID);
            builder.Property(p => p.categoryName);
        }
    }
}
