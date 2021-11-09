using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValkyraShop.DatabaseDto.Shop;

namespace ValkyraShop.Services
{
    public interface IAddressServcie
    {
        int AddAddress(CustomerAddress customerAddress);
        List<CustomerAddress> GetAddresses(int CustomerId);
        int UpdateAddress(CustomerAddress customerAddress);
        int DeleteAddress(CustomerAddress customerAddress);
    }
}
