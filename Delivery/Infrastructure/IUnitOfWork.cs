namespace Delivery.Infrastructure
{
    public interface IUnitOfWork
    {
        IDeliveryRepository DeliveryRepository { get; set; }
    }
}