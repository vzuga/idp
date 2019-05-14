using System;
using System.Collections.Generic;

namespace OnlineStore.Models
{
    public partial class OrderProducts
    {
        public decimal OrderId { get; set; }
        public decimal ProductId { get; set; }
        public decimal Quantity { get; set; }

        public virtual Orders Orders { get; set; }
    }
}
