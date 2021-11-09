using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValkyraShop.DatabaseDto.Shop;

namespace ValkyraShop.Services
{
    public interface ILoginService
    {
        string Login(WebLogin webLogin, string key);
    }
}
