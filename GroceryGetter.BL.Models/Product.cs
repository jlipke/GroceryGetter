using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryGetter.BL.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public enum StoreLoction
        {
            WALMART,
            ALDI,
            KROGGER,
            FESTIVAL,
            ALPHABETICAL
            

        }

        public enum AisleLoction
        {
           
            BREAD,
            CLEANING,
            DAIRY,
            PRODUCE,
            CEREAL,
            HOUSEHOLD
        }

        public StoreLoction Store { get; set; }
        public AisleLoction Aisle { get; set; }

        //[Display(Name = "Aisle")]
        //public string AisleNumber { get; set; }
    }
}
