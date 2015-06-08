using Delivery.Infrastructure;
using Delivery.Infrastructure.Entities;
using Nancy;

namespace Delivery.Interface
{
    public class ItemController : NancyModule
    {
        private readonly IUnitOfWork _unitOfWork;

        public ItemController(IUnitOfWork unitOfWork) : base("/item")
        {
            _unitOfWork = unitOfWork;

            Get["/"] = x => _unitOfWork.Repository<Item>().All();
        }
    }
}