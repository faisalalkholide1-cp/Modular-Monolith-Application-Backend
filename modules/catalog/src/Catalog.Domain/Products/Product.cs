using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Catalog.Products
{
    public class Product : AggregateRoot<Guid>
    {
        public string Name { get; set; }
        public int StockCount { get; set; }
    }
}
