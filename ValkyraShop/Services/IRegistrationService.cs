using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValkyraShop.DatabaseDto.Shop;
using ValkyraShop.Dtos;

namespace ValkyraShop.Services
{
    public interface IRegistrationService
    {
        ValidationResult Register(CustomerWebAccount customerWebAccount);
        void Validate(string id);
    }
}
