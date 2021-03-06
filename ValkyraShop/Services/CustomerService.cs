using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValkyraShop.DataBase;
using ValkyraShop.DatabaseDto.Shop;

namespace ValkyraShop.Services
{
    public class CustomerService : ICustomerService
    {
        private CustomerRepository _customerRepository;

        public CustomerService(ShopDbContext dbContext)
        {
            _customerRepository = new CustomerRepository(dbContext);
        }
        public Customer GetCustomers(int id)
        {
            return _customerRepository.GetCustomer(id);
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerRepository.UpdateCustomer(customer);
        }
    }
}
