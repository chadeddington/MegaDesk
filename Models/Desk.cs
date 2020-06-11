using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk.Models
{
    public class Desk
    {
        public int DeskId { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        [Display(Name ="Number of Drawers")]
        public int NumberOfDrawers { get; set; }
        [Display(Name ="Desktop Material")]
        public int DesktopMaterialId { get; set; }

        /* navigation properties*/
        public DesktopMaterial DesktopMaterial { get; set; }
    }
}
