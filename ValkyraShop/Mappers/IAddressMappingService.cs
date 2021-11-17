using ValkyraShop.DatabaseDto.Shop;
using ValkyraShop.Dtos;

namespace ValkyraShop.Mappers
{
    public interface IAddressMappingService
    {
        void Map();
        CustomerAddress ToEntity(CustomerAddressDto customerAddressDto);
        CustomerAddressDto ToDto(CustomerAddress customerAddress);
    }
}
