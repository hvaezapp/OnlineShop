using OnlineShop.Application.Contracts.Persistence;
using OnlineShop.Domain.Entity;
using OnlineShop.Persistence.Context;

namespace OnlineShop.Persistence.Repositories
{
    public class ProductAddOnRepository : GenericRepository<ProductAddOn>, IProductAddOnRepository
    {
        private readonly OnlineShopDbContext _dbContext;

        public ProductAddOnRepository(OnlineShopDbContext dbContext)
            : base(dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
