using MegaDesk.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Display(Name = "Quote Date")]
        public DateTime QuoteDate { get; set; }
        [Display(Name = "Quote Price")]
        public decimal QuotePrice { get; set; }
        public int DeskId { get; set; }
        [Display(Name = "Shipping Type")]
        public int ShippingTypeId { get; set; }
         
        /* Navigation Props */
        public Desk Desk { get; set; }
        [Display(Name = "Shipping Type")]
        public Shipping ShippingType { get; set; }

        public decimal GetDeskQuote(MegaDeskContext context)
        {
            decimal baseCost = 200;
            // Surface Area Cost
            decimal surfaceArea = this.Desk.Width * this.Desk.Depth;
            decimal surfaceAreaCost = 0;
            if (surfaceArea > 1000)
            {
                surfaceAreaCost = surfaceArea - 1000;
            }

            // ShippingCost
            ShippingType = context.Shipping.Where(s => s.ShippingId == this.ShippingTypeId).FirstOrDefault();


            decimal shippingCost = 0.00M;

            if (surfaceArea < 1000)
            {
                shippingCost = ShippingType.PriceUnder1000;
            }
            else if (surfaceArea >= 10000 && surfaceArea <= 2000)
            {
                shippingCost = ShippingType.PriceBetween1000And2000;
            } else
            {
                shippingCost = ShippingType.PriceOver2000;
            }


            // Drawers Cost
            decimal drawersCost = this.Desk.NumberOfDrawers * 50;

            // Material Cost
            DesktopMaterial material = context.DesktopMaterial.Where(m => m.DesktopMaterialId == this.Desk.DesktopMaterialId).FirstOrDefault();

            decimal materialCost = material.DesktopMaterialPrice;

            decimal totalCost = baseCost + surfaceAreaCost + shippingCost + drawersCost + materialCost;
            return totalCost;
        }

    }
}
