namespace ValkyraShop.DataBase
{
    public class RepositoryBase
    {
        protected ShopDbContext _dbContext = null;

        public RepositoryBase(ShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
