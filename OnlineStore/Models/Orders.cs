using System;
using System.Collections.Generic;

namespace OnlineStore.Models
{
    public partial class Orders
    {
        public decimal Id { get; set; }
        public decimal UserId { get; set; }
        public string Status { get; set; }
        public DateTime PlacedDate { get; set; }
        public DateTime DeliveredDate { get; set; }

        public virtual OrderProducts IdNavigation { get; set; }
        public virtual Users User { get; set; }
    }
}
