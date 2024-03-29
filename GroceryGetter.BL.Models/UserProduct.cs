﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryGetter.BL.Models
{
    public class UserProduct
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }

        [Display(Name = "In Cart")]
        public bool InCart { get; set; }
        public int Amount { get; set; }
        public string Notes { get; set; }

        [Display(Name = "Title")]
        public string ProductTitle { get; set; }

        [Display(Name = "Aisle")]
        public string ProductAisle { get; set; }

    }
}
