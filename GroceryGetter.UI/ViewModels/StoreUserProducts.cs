using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroceryGetter.BL.Models;

namespace GroceryGetter.UI.ViewModels
{
    public class StoreUserProducts
    {
        public List<UserProduct> UserProducts { get; set; }
        public Store Store { get; set; }
    }
}