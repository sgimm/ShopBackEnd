using System.Collections.Generic;
using ValkyraShop.Dtos;

namespace ValkyraShop.Services
{
    public interface IAddressServcie
    {
        int AddAddress(CustomerAddressDto customerAddress);
        List<CustomerAddressDto> GetAddresses(int CustomerId);
        int UpdateAddress(CustomerAddressDto customerAddress);
        int DeleteAddress(int addressId);
    }
}
