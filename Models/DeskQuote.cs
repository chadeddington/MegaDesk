using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk.Models
{
    public class DeskQuote
    {
        private const decimal BASE_DESK_PRICE = 200.00M;
        private const decimal SURFACE_AREA_COST = 1.00M;
        private const decimal DRAWER_COST = 50.00M;

        public int DeskQuoteId { get; set; }
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public decimal QuotePrice { get; set; }
        public int DeskId { get; set; }
        public int ShippingTypeId { get; set; }

        /* Navigation Props */
        public Desk Desk { get; set; }
        public Shipping ShippingType { get; set; }

    }
}
