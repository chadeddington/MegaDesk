using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk.Models
{
    public class Shipping
    {
        public int ShippingId { get; set; }
        public string ShippingName { get; set; }
        public decimal PriceUnder1000 { get; set; }
        public decimal PriceBetween1000And2000 { get; set; }
        public decimal PriceOver2000 { get; set; }
    }
}
