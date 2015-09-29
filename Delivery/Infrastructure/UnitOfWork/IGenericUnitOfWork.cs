using Delivery.Infrastructure.Repository;

namespace Delivery.Infrastructure.UnitOfWork
{
    public interface IGenericUnitOfWork
    {
        void Commit();
        void Rollback();
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;
    }
}