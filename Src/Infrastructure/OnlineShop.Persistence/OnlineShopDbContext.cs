using Microsoft.EntityFrameworkCore;
using OnlineShop.Domain.Common;
using OnlineShop.Domain.Entity;

namespace OnlineShop.Persistence
{
    public class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext(DbContextOptions<OnlineShopDbContext> options)
            : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(OnlineShopDbContext).Assembly);


        }

        public  DbSet<Color> Color { get; set; }
        public  DbSet<Size> Size { get; set; }
        public  DbSet<ProductSize> ProductSize { get; set; }
        public  DbSet<ProductColor> ProductColor { get; set; }
        public  DbSet<Product> Product { get; set; }
        public  DbSet<AddOn> AddOn { get; set; }
        public  DbSet<ProductAddOn> ProductAddOn { get; set; }






    }
}
