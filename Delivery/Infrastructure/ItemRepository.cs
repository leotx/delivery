using Delivery.Infrastructure.Entities;

namespace Delivery.Infrastructure
{
    public class ItemRepository : GenericRepository<Item>, IItemRepository
    {
        private readonly GenericUnitOfWork _unitOfWork;

        public ItemRepository(GenericUnitOfWork unitOfWork) : base(unitOfWork.Session)
        {
            _unitOfWork = unitOfWork;
        }
    }
}