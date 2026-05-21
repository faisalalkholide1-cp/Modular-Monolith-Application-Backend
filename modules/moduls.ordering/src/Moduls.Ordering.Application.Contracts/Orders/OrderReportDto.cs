using ModularCrm.Ordering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moduls.Ordering.Orders
{
    public class OrderReportDto
    {
        public Guid OrderId { get; set; }
        public string CustomerName { get; set; } = null!;
        public OrderState State { get; set; }

        public Guid ProductId { get; set; }
        public string ProductName { get; set; } = null!;
    }
}
