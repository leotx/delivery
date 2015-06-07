namespace Delivery.Infrastructure
{
    public class DeliveryRepository<T> : GenericRepository<T> where T : class, IDeliveryRepository
    {
        private readonly GenericUnitOfWork _unitOfWork;

        public DeliveryRepository(GenericUnitOfWork unitOfWork) : base(unitOfWork.Session)
        {
            _unitOfWork = unitOfWork;
        }
    }
}