using ModularCrm.Ordering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moduls.Ordering.Orders
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public string CustomerName { get; set; } = null!;
        public Guid ProductId { get; set; }
        public OrderState State { get; set; }
        public string ProductName { get; set; } = null!;
    }
}
