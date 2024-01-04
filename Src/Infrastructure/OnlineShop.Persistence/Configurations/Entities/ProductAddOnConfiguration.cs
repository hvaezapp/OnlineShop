using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Domain.Entity;

namespace OnlineShop.Persistence.Configurations.Entities
{
    public class ProductAddOnConfiguration : IEntityTypeConfiguration<ProductAddOn>
    {
        public void Configure(EntityTypeBuilder<ProductAddOn> builder)
        {

            builder.HasKey(a => a.Id);
            builder.HasQueryFilter(a=> !a.IsDeleted);

        }
    }
}
