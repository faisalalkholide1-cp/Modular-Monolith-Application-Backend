using ModularCrm.Ordering;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Moduls.Ordering.Orders
{
    public class Order : CreationAuditedAggregateRoot<Guid>
    {
        public Guid ProductId { get; set; }
        public string CustomerName { get; set; } = null!;
        public OrderState State { get; set; }
    }
}
