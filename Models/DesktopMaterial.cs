using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk.Models
{
    public class DesktopMaterial
    {
        [Display(Name = "Desktop Material")]
        public int DesktopMaterialId { get; set; }
        public string DesktopMaterialName { get; set; }
        public decimal DesktopMaterialPrice { get; set; }
    }
}
