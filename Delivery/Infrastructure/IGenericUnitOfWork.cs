namespace Delivery.Infrastructure
{
    public interface IGenericUnitOfWork
    {
        void Commit();
        void Rollback();
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;
    }
}