using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryGetter.BL.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserPass { get; set; }
        public List<UserProduct> GroceryList { get; set; }


        public User(Guid userid, string firstname, string lastname, string email, string userpass)
        {
            Id = userid;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            UserPass = userpass;
        }

        // Login
        public User(string email, string userpass)
        {
            Email = email;
            UserPass = userpass;
        }
    }
}
