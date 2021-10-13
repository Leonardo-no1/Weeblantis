using System;
using System.Collections.Generic;
using System.Text;
using Weeblantis.Core.Models;

namespace Weeblantis.Core.Dtos.Order
{
    public class OrderDto : BaseEntity
    {
        public double Total { get; set; }
        public int UserId { get; set; }
        List<OrderItemDto> OrderItems { get; set; }
    }
}
