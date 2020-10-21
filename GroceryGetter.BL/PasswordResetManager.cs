using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace GroceryGetter.BL
{
    public static class PasswordResetManager
    {
        public static void SendMessage(string recipient)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("grocerygetteremail@gmail.com", "TestPass123"),
                EnableSsl = true,
            };
                            //  email sender, recipient, subject, body
            smtpClient.Send("grocerygetteremail@gmail.com", recipient, "Reset Password", "Please click this link to reset your password.");
        }


    }
}
