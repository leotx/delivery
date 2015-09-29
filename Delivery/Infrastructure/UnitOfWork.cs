namespace Delivery.Infrastructure
{
    public class UnitOfWork : GenericUnitOfWork, IUnitOfWork
    {
        public UnitOfWork() : base("defaultConnection")
        {
        }
    }
}