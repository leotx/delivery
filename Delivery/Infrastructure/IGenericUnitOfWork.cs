namespace Delivery.Infrastructure
{
    public interface IGenericUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}