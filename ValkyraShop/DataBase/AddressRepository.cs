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
            return _dbContext.CustomerAddresses.Where(address => address.CustomerId == customerId).ToList();
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

        public int DeleteCustomer(int id)
        {
            _dbContext.CustomerAddresses.Remove(_dbContext.CustomerAddresses.FirstOrDefault(a => a.Id == id));
            return _dbContext.SaveChanges();
        }
    }
}
