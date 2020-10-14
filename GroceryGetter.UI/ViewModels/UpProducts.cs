using GroceryGetter.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryGetter.UI.ViewModels
{
    public class UpProducts
    {
        public UserProduct UserProduct { get; set; }
        public List<Product> Products { get; set; }
    }
}