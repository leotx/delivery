using Delivery.Infrastructure;
using Delivery.Infrastructure.Entities;
using Delivery.Infrastructure.UnitOfWork;
using Nancy;

namespace Delivery.Interface.Controller
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