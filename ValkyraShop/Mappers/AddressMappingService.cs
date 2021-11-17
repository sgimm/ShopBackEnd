using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValkyraShop.DatabaseDto.Shop;
using ValkyraShop.Dtos;

namespace ValkyraShop.Mappers
{
    public class AddressMappingService : IAddressMappingService
    {
        public void Map()
        {
            throw new NotImplementedException();
        }

        public CustomerAddressDto ToDto(CustomerAddress customerAddress)
        {
            return new CustomerAddressDto
            {
                AddressInformation = customerAddress.AddressInformation,
                City = customerAddress.City,
                CountryId = customerAddress.Country.Id,
                CustomerId = customerAddress.CustomerId,
                FirstName = customerAddress.FirstName,
                LastName = customerAddress.LastName,
                Street = customerAddress.Street,
                ZipCode = customerAddress.ZipCode
            };
        }

        public CustomerAddress ToEntity(CustomerAddressDto customerAddressDto)
        {

            return new CustomerAddress
            {
                AddressInformation = customerAddressDto.AddressInformation,
                City = customerAddressDto.City,
                CountryId = customerAddressDto.CountryId,
                Created = DateTime.Now,
                CustomerId = customerAddressDto.CustomerId,
                FirstName = customerAddressDto.FirstName,
                LastName = customerAddressDto.LastName,
                Street = customerAddressDto.Street,
                ZipCode = customerAddressDto.ZipCode
            };
        }
    }
}
