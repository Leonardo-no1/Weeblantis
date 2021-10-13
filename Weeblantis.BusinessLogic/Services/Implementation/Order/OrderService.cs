using System;
using Weeblantis.BusinessLogic.Services.Order;
using Weeblantis.Core.Dtos.Order;
using Weeblantis.Core.Models.Order;
using Weeblantis.Data.Repositories;

namespace Weeblantis.BusinessLogic.Services.Implementation.Order
{
    public class OrderService : IOrderService
    {
        private IRepository<OrderItemModel> _orderItemRepository;
        private IRepository<OrderDetailModel> _orderDetailRepository;
        public OrderService(IRepository<OrderItemModel> orderItemRepository, IRepository<OrderDetailModel> orderDetailRepository)
        {
            _orderItemRepository = orderItemRepository;
            _orderDetailRepository = orderDetailRepository;
        }
        public OrderItemModel AddOrderItem(OrderItemModel orderItemModel)
        {
            return _orderItemRepository.Insert(orderItemModel);
        }

        public OrderDetailModel AddOrderDetail(OrderDetailModel orderDetailModel)
        {
            return _orderDetailRepository.Insert(orderDetailModel);
        }

        
    }
}
