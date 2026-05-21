using System;

namespace Moduls.Ordering.Orders
{
    public class OrderPlacedEto
    {
        public string CustomerName { get; set; } = null!;
        public Guid ProductId { get; set; }
    }
}
