namespace DucShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}