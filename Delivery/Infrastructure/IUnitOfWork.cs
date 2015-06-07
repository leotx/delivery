namespace Delivery.Infrastructure
{
    public interface IUnitOfWork
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;
    }
}