using System;
using System.Collections.Generic;
using ValkyraShop.DataBase;
using ValkyraShop.DatabaseDto.Shop;
using ValkyraShop.Dtos;
using ValkyraShop.Mappers;

namespace ValkyraShop.Services
{
    public class AddressService : IAddressServcie
    {
        private AddressRepository _addressRepository;
        private IAddressMappingService _addressMappingService;

        public AddressService(ShopDbContext shopDbContext, IAddressMappingService addressMappingService)
        {
            _addressRepository = new AddressRepository(shopDbContext);
            _addressMappingService = addressMappingService;
        }

        public int AddAddress(CustomerAddressDto customerAddress)
        {
            return _addressRepository.AddAddress(_addressMappingService.ToEntity(customerAddress));
        }

        public int DeleteAddress(int addressId)
        {
            throw new NotImplementedException();
        }

        public List<CustomerAddressDto> GetAddresses(int customerId)
        {
            List<CustomerAddress> customerAddresses = _addressRepository.GetAddresses(customerId);
            List<CustomerAddressDto> customerAddressDtos = new List<CustomerAddressDto>();
            for(int i = 0; i < customerAddresses.Count; i++)
            {

            }
            return null;
        }

        public int UpdateAddress(CustomerAddressDto customerAddress)
        {
            throw new NotImplementedException();
        }
    }
}
