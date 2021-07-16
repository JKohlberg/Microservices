using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderMicroservice.Database.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public string DeliveryInstructions { get; set; }
    }
}
