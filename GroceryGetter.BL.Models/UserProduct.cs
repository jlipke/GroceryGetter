using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryGetter.BL.Models
{
    public class UserProduct : Product
    {
        [Display(Name = "In Cart")]
        public bool InCart { get; set; }
        public int Amount { get; set; }
        public string Notes { get; set; }


        /*
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        public bool InCart { get; set; }
        public int Amount { get; set; }
        public string Notes { get; set; }

        [Display(Name = "Name")]
        public string ProductTitle { get; set; }

        [Display(Name = "Aisle")]
        public string ProductAisle { get; set; }

        // If we want the ability to have multiple shopping lists per user, code below must be added. As well as database changes and more.
        // public string GroceryListName { get; set; }
        */
    }
}
