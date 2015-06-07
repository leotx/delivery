using Delivery.Infrastructure;
using Delivery.Infrastructure.Entities;
using Nancy;

namespace Delivery.Interface
{
    public class ItemController : NancyModule
    {
        private readonly UnitOfWork _unitOfWork;

        public ItemController(UnitOfWork unitOfWork) : base("/item")
        {
            _unitOfWork = unitOfWork;

            Get["/"] = x => _unitOfWork.Repository<Item>().All();
        }
    }
}