using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4_ModuleHW.Entity;

namespace Module4_ModuleHW.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    { 
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(p => p.FirstName);
            builder.Property(p => p.LastName);
        }
    }
}
