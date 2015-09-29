using Delivery.Infrastructure.Entities;
using Delivery.Infrastructure.UnitOfWork;

namespace Delivery.Infrastructure.Repository
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