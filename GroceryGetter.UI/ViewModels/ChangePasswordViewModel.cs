using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using GroceryGetter.BL.Models;

namespace GroceryGetter.UI.ViewModels
{
    public class ChangePasswordViewModel
    {
        [DisplayName("Current Password")]
        public string password { get; set; }

        [DisplayName("New Password")]
        public string newpass1 { get; set; }

        [DisplayName("Confirm Password")]
        public string newpass2 { get; set; }

        public User user { get; set; }
        
    }

    
            
}