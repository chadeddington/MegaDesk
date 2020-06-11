using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk.Models
{
    public class Shipping
    {
        public int ShippingTypeId { get; set; }
        public string Type { get; set; }
        public decimal Cost { get; set; }
    }
}
