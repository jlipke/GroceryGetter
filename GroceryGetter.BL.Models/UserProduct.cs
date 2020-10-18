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

        public string Notes { get; set; }
        private int _amount; 
        public UserProduct()
        {
            // When a user adds an item, it defulats to one
            // if they want more, they press the up button
            // that call AmountUp() method
            this._amount = 1;
        }

        public int Amount
        {
            get
            {
                // To prevent negitives.
                if (_amount < 1)
                    return 1;
                else
                    return _amount;
            }

            set
            {
                // The user doesn't need to enter a number, 
                // just increse/decrease the amount
                // See methods below
            }
        }
        

        public void AmountUp()
        {
            this._amount++;
        }

        public void AmountDown()
        {
            this._amount--;
        }



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
