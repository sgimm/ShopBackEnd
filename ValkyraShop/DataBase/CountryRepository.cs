using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValkyraShop.DatabaseDto.Shop;

namespace ValkyraShop.DataBase
{
    public class CountryRepository : RepositoryBase
    {
        public CountryRepository(ShopDbContext dbContext) : base(dbContext)
        {
        }

        public List<Country> GetCountries()
        {
            return (from x in _dbContext.Countries select x).ToList();
        }
    }
}
