using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValkyraShop.DataBase
{
    public class ProductRepository : RepositoryBase
    {
        public ProductRepository(ShopDbContext dbContext) : base(dbContext)
        {
        }
    }
}
