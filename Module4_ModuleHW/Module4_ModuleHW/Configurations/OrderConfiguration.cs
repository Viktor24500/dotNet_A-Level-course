using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4_ModuleHW.Entity;

namespace Module4_ModuleHW.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(p => p.UserId).IsRequired();

            builder.HasOne(h => h.User)
                .WithMany(w => w.Orders)
                .HasForeignKey(h => h.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
