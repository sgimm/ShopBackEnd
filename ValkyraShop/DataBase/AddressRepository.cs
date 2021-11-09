using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValkyraShop.DatabaseDto.Shop;

namespace ValkyraShop.DataBase
{
    public class AddressRepository : RepositoryBase
    {
        public AddressRepository(ShopDbContext dbContext) : base(dbContext)
        {
        }

        public List<CustomerAddress> GetAddresses(int customerId)
        {
            return null;
        }

        public int AddAddress(CustomerAddress customerAddress)
        {
            _dbContext.CustomerAddresses.Add(customerAddress);
            return _dbContext.SaveChanges();
        }

        public int UpdateAddress(CustomerAddress customerAddress)
        {
            return 0;
        }

        public int DeleteCustomer(CustomerAddress customerAddress)
        {
            _dbContext.CustomerAddresses.Remove(customerAddress);
            return _dbContext.SaveChanges();
        }
    }
}
