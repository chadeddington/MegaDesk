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
        [Required]
        [Range(24, 96)]
        [Display(Name = "Width in Inches")]
        public decimal Width { get; set; }
        [Required]
        [Range(12, 48)]
        [Display(Name = "Depth in Inches")]
        public decimal Depth { get; set; }
        [Required]
        [Display(Name ="Number of Drawers")]
        [Range(0, 7)]
        public int NumberOfDrawers { get; set; }
        [Required]
        [Display(Name = "Desktop Material")]
        public int DesktopMaterialId { get; set; }

        /* navigation properties*/
        [Display(Name = "Desktop Material")]
        public DesktopMaterial DesktopMaterial { get; set; }
    }
}
