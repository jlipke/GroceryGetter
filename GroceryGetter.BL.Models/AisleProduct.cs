using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryGetter.BL.Models
{
    public class AisleProduct
    {
        public Guid Id { get; set; }
        public Guid AisleId { get; set; }
        public Guid ProductId { get; set; }

        [Display(Name = "Aisle")]
        public string AisleNumber { get; set; }
    }
}
