using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValkyraShop.DatabaseDto.Shop;

namespace ValkyraShop.DataBase
{
    public class CustomerRepository : RepositoryBase
    {
        public CustomerRepository(ShopDbContext dbContext) : base(dbContext)
        {
        }

        public Customer GetCustomer(int id)
        {
            return _dbContext.Customers.FirstOrDefault(customer => customer.Id == id);
        }

        public void UpdateCustomer(Customer customer)
        {
            Customer updateCustomer = _dbContext.Customers.FirstOrDefault(x => x.Id == customer.Id);
            updateCustomer.FirstName = customer.FirstName;
            updateCustomer.LastName = customer.LastName;
            updateCustomer.Updated = DateTime.Now;
            _dbContext.SaveChanges();
        }
    }
}
