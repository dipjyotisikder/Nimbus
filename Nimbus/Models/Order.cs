using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nimbus.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int AgentId { get; set; }
        public Agent Agent { get; set; }


        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public string StartLat { get; set; }
        public string StartLong { get; set; }
        public string EndLat { get; set; }
        public string EndLong { get; set; }

        public int OrderProviderId { get; set; }
        public OrderProvider OrderProvider { get; set; }

    }
}