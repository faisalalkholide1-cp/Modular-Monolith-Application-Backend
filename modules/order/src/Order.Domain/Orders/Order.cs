using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Order.Orders
{
    public class Order : CreationAuditedAggregateRoot<Guid>
    {
        public Guid ProductId { get; set; }
        public string CustomerName { get; set; } = null!;
        public OrderState State { get; set; }
    }
}
