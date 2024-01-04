using OnlineShop.Application.Contracts.Persistence;
using OnlineShop.Domain.Entity;
using OnlineShop.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Persistence.Repositories
{
    public class ProductSizeRepository : GenericRepository<ProductSize>, IProductSizeRepository
    {
        private readonly OnlineShopDbContext _dbContext;

        public ProductSizeRepository(OnlineShopDbContext dbContext)
            : base(dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
