using System.Linq;
using ValkyraShop.DatabaseDto.Shop;

namespace ValkyraShop.DataBase
{
    public class BasketRepository : RepositoryBase
    {
        public BasketRepository(ShopDbContext dbContext) : base(dbContext)
        {
        }

        public void AddCustomerBasketItem(string customerId, BasketItem basketItem)
        {
            _dbContext.CustomerBaskets.FirstOrDefault(customerBasket => customerBasket.CustomerWebAccount.Id == int.Parse(customerId));  
            
        }
    }
}
