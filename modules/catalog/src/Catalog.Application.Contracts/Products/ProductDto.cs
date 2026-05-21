using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Products
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int StockCount { get; set; }
    }
}
