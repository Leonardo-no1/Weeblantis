using System;
using System.Collections.Generic;
using System.Text;
using Weeblantis.Core.Models.Order;

namespace Weeblantis.BusinessLogic.Services.Order
{
    public interface IOrderService
    {
        OrderItemModel AddOrderItem(OrderItemModel orderItemModel);
        OrderDetailModel AddOrderDetail(OrderDetailModel orderDetailModel);
    }
}
