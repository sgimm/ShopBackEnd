using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValkyraShop.DataBase;
using ValkyraShop.DatabaseDto.Shop;

namespace ValkyraShop.Services
{
    public class AddressService : IAddressServcie
    {
        private AddressRepository _addressRepository;

        public AddressService(ShopDbContext shopDbContext)
        {
            _addressRepository = new AddressRepository(shopDbContext);
        }
        public int AddAddress(CustomerAddress customerAddress)
        {
            return 0;
        }

        public int DeleteAddress(CustomerAddress customerAddress)
        {
            throw new NotImplementedException();
        }

        public List<CustomerAddress> GetAddresses(int customerId)
        {
            return _addressRepository.GetAddresses(customerId);
        }

        public int UpdateAddress(CustomerAddress customerAddress)
        {
            throw new NotImplementedException();
        }
    }
}
