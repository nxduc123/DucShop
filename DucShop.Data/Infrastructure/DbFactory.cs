namespace DucShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private DucShopDbContext dbContext;

        public DucShopDbContext Init()
        {
            return dbContext ?? (dbContext = new DucShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}