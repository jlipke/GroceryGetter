using GroceryGetter.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryGetter.UI.ViewModels
{
    public class UserUserProduct
    {
        public List<Product> Products { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
        public UserProduct UserProduct { get; set; }

    }
}