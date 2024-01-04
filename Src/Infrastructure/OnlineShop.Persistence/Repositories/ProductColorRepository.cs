using OnlineShop.Application.Contracts.Persistence;
using OnlineShop.Domain.Entity;
using OnlineShop.Persistence.Context;

namespace OnlineShop.Persistence.Repositories
{
    public class ProductColorRepository : GenericRepository<ProductColor>, IProductColorRepository
    {
        private readonly OnlineShopDbContext _dbContext;

        public ProductColorRepository(OnlineShopDbContext dbContext)
            : base(dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
