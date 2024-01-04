using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using OnlineShop.Application.Contracts.Persistence;
using OnlineShop.Domain.Entity;
using OnlineShop.Persistence.Context;
using System.Data;
using System.Drawing;

namespace OnlineShop.Persistence.Repositories
{
    public class ColorRepository : GenericRepository<Domain.Entity.Color> , IColorRepository
    {
        private readonly OnlineShopDbContext _dbContext;

        public ColorRepository(OnlineShopDbContext dbContext)
            : base(dbContext)
        {
            _dbContext =  dbContext;
        }

    }
}
