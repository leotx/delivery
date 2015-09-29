namespace Delivery.Infrastructure.UnitOfWork
{
    public class UnitOfWork : GenericUnitOfWork, IUnitOfWork
    {
        public UnitOfWork() : base("defaultConnection")
        {
        }
    }
}