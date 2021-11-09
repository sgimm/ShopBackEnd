using Microsoft.AspNetCore.Mvc;
using ValkyraShop.DataBase;

namespace ValkyraShop.Helpers
{
    public class CustomController : Controller
    {
        protected ShopDbContext _valkyraShopDbContext;

        public CustomController(ShopDbContext valkyraShopDbContext)
        {
            _valkyraShopDbContext = valkyraShopDbContext;
        }
    }
}
