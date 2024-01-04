using OnlineShop.Application.Contracts.Persistence;
using OnlineShop.Domain.Entity;
using OnlineShop.Persistence.Context;

namespace OnlineShop.Persistence.Repositories
{
    public class SizeRepository : GenericRepository<Size>, ISizeRepository
    {
        private readonly OnlineShopDbContext _dbContext;

        public SizeRepository(OnlineShopDbContext dbContext)
            : base(dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
