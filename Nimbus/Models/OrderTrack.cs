using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nimbus.Models
{
    public class OrderTrack
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public string Lat { get; set; }
        public string Long { get; set; }

    }
}