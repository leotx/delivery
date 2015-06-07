namespace Delivery.Infrastructure
{
    public class UnitOfWork : GenericUnitOfWork, IUnitOfWork
    {
        public UnitOfWork() : base("defaultConnection")
        {
        }

        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            return new GenericRepository<TEntity>(Session);
        }
    }
}