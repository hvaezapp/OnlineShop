using OnlineShop.Application.Contracts.Persistence;
using OnlineShop.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Domain.Entity.Product>, IProductRepository
    {
        private readonly OnlineShopDbContext _dbContext;

        public ProductRepository(OnlineShopDbContext dbContext)
            : base(dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
