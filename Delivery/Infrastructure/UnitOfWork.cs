namespace Delivery.Infrastructure
{
    public class UnitOfWork : GenericUnitOfWork, IUnitOfWork
    {
        public UnitOfWork() : base("defaultConnection")
        {
            DeliveryRepository = new DeliveryRepository(this);
        }

        public IDeliveryRepository DeliveryRepository { get; set; }
    }
}