namespace Delivery.Infrastructure
{
    public class UnitOfWork : GenericUnitOfWork
    {
        public UnitOfWork() : base("defaultConnection")
        {
        }
    }
}