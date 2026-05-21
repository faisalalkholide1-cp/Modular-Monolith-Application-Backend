using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Moduls.Ordering.Orders
{
    public class OrderCreationDto
    {
        [Required]
        [StringLength(150)]
        public string CustomerName { get; set; } = null!;

        [Required]
        public Guid ProductId { get; set; }
    }
}
