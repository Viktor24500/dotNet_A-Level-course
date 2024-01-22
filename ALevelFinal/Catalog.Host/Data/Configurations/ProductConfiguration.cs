using Catalog.Host.Data.Entities;

namespace Catalog.Host.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(h => h.productID);
            builder.Property(p => p.productName);
            builder.Property(p => p.productDescription);
            builder.Property(p => p.price);
            builder.Property(p => p.amount);
            builder.Property(p => p.pictureName);

            //1 Brand - many products
            builder.HasOne(h => h.Brand)
                .WithMany(b => b.Products)
                .HasForeignKey(b => b.brandID);

            //1 Brand - many categories
            builder.HasOne(h => h.Category)
                .WithMany(b => b.Products)
                .HasForeignKey(b => b.categoryID);
        }

        //public int productID { get; set; }
        //public string productName { get; set; }
        //public string productDescription { get; set; }

        //public float price { get; set; }

        //public int amount { get; set; }

        //public string pictureName { get; set; }

        //public int? brandID { get; set; }
        //public Brand? Brand { get; set; }

        //public int? categoryID { get; set; }
        //public Category? Category { get; set; }
    }
}
