using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using GroceryGetter.BL.Models;

namespace GroceryGetter.BL
{
    public static class PasswordResetManager
    {
        public static string RandomString(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            return res.ToString();
        }

        public static void SendMessage(string recipient)
        {
            

            string newPass = RandomString(16);
           // string newPass = UserManager.CreateHash(rand);

            User user = UserManager.LoadByEmail(recipient);
            user.UserPass = newPass;
            UserManager.Update(user);

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("grocerygetteremail@gmail.com", "TestPass123"),
                EnableSsl = true,
            };
                            //  email sender, recipient, subject, body
            smtpClient.Send("grocerygetteremail@gmail.com", recipient, "Reset Password", "Here is your new generated password. " + newPass);
        }


    }
}
