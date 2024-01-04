using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Domain.Entity;

namespace OnlineShop.Persistence.Configurations.Entities
{
    public class AddOnConfiguration : IEntityTypeConfiguration<AddOn>
    {
        public void Configure(EntityTypeBuilder<AddOn> builder)
        {

            builder.HasKey(a => a.Id);
            builder.HasQueryFilter(a=> !a.IsDeleted);

        }
    }
}
