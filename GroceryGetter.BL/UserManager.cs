using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using GroceryGetter.BL.Models;
using GroceryGetter.PL;


namespace GroceryGetter.BL
{
    public class UserManager
    {
        public static void Insert(string firstname, string lastname, string email, string userpass)
        {
            try
            {
                User user = new User(Guid.NewGuid(), firstname, lastname, email, userpass);
            }


            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static int Insert(User user)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblUser newrow = new tblUser();
                    newrow.Id = Guid.NewGuid();
                    newrow.FirstName = user.FirstName;
                    newrow.LastName = user.LastName;
                    newrow.Email = user.Email;
                    newrow.UserPass = user.UserPass;

                    user.Id = newrow.Id;
                    dc.tblUsers.Add(newrow);

                    return dc.SaveChanges();
                }
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static int Update(User user)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblUser updatedrow = dc.tblUsers.Where(c => c.Id == user.Id).FirstOrDefault();
                    if(updatedrow != null)
                    {
                        updatedrow.FirstName = user.FirstName;
                        updatedrow.LastName = user.LastName;
                        updatedrow.Email = user.Email;
                        updatedrow.UserPass = GetHash(user.UserPass);
                        return dc.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Row was not found!");
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static int UpdateGroceryList(User user)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblUser tbluser = dc.tblUsers.FirstOrDefault(u => u.Id == u.Id);

                    if(tbluser != null)
                    {
                        tbluser.FirstName = user.FirstName;
                        tbluser.LastName = user.LastName;
                        tbluser.Email = user.Email;
                        tbluser.UserPass = user.UserPass;

                        var existing = dc.tblUserProducts.Where(up => up.UserId == user.Id);
                        dc.tblUserProducts.RemoveRange(existing);

                        List<tblUserProduct> tblUserProducts = new List<tblUserProduct>();

                        foreach (UserProduct up in user.GroceryList)
                        {
                            tblUserProduct tbluserproduct = new tblUserProduct();
                            tbluserproduct.Id = Guid.NewGuid();
                            tbluserproduct.UserId = user.Id;
                            tbluserproduct.ProductId = up.Id;
                            tbluserproduct.InCart = up.InCart;
                            tbluserproduct.Amount = up.Amount;
                            tbluserproduct.Notes = up.Notes;
                            tblUserProducts.Add(tbluserproduct);
                        }

                        dc.tblUserProducts.AddRange(tblUserProducts);

                        int result = dc.SaveChanges();
                        return result;
                    }
                    else
                    {
                        throw new Exception("Row was not found!!");
                    }
                }
            }
            catch (Exception ex) 
            {

                throw ex;
            }
        }

        public static int Delete(Guid id)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblUser deleterow = dc.tblUsers.FirstOrDefault(c => c.Id == id);
                    if(deleterow != null)
                    {
                        dc.tblUsers.Remove(deleterow);
                        return dc.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Row was not found!!!");
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void Seed()
        {
            User user = new User(Guid.NewGuid(), "Test", "Seed", "test@test.com", "Test123");
            Insert(user);
        }

        public static User LoadByEmail(string email)
        {
            try
            {
                List<User> users = new List<User>();
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    var results = (from u in dc.tblUsers
                                   join up in dc.tblUserProducts on u.Id equals up.UserId
                                   join p in dc.tblProducts on up.ProductId equals p.Id
                                   where u.Email == email
                                   select u).ToList();
                    results.ForEach(u => users.Add(new User
                    {
                        Id = u.Id,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        Email = u.Email,
                        UserPass = u.UserPass,
                        GroceryList = UserProductManager.LoadByUserId(u.Id)
                    }));
                }
                return users.FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static User LoadById(Guid id)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblUser tbluser = dc.tblUsers.FirstOrDefault(u => u.Id == id);
                    User user = new User();

                    if (tbluser != null)
                    {
                        user.Id = tbluser.Id;
                        user.FirstName = tbluser.FirstName;
                        user.LastName = tbluser.LastName;
                        user.Email = tbluser.Email;
                        user.UserPass = tbluser.UserPass;

                        tblUserProduct tbluserproduct = dc.tblUserProducts.FirstOrDefault(up => up.UserId == id);

                        if(tbluserproduct != null)
                        {
                            user.GroceryList = UserProductManager.LoadByUserId(tbluser.Id);
                        }
                        return user;
                    }
                    else
                    {
                        throw new Exception("Row was not found!!!!");
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<User> Load()
        {
            using (GroceryGetterEntities dc = new GroceryGetterEntities())
            {
                List<User> users = new List<User>();
                dc.tblUsers.ToList().ForEach(u => users.Add(new User
                {
                    Id = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    UserPass = u.UserPass,
                    Email = u.Email,
                    GroceryList = UserProductManager.LoadByUserId(u.Id)
                }));
                return users;
            }
            
        }


        private static string GetHash(string userpass)
        {
            using (var haser = new System.Security.Cryptography.SHA1Managed())
            {
                var hashbytes = System.Text.Encoding.UTF8.GetBytes(userpass);
                return Convert.ToBase64String(haser.ComputeHash(hashbytes));
            }
        }



        public static bool Login(User user)
        {
            if (!string.IsNullOrEmpty(user.Email))
            {
                if (!string.IsNullOrEmpty(user.UserPass))
                {
                    using (GroceryGetterEntities dc = new GroceryGetterEntities())
                    {
                        tblUser tbluser = dc.tblUsers.FirstOrDefault(u => u.Email == user.Email);
                        if(tbluser != null)
                        {
                            if(GetHash(tbluser.UserPass) == GetHash(user.UserPass)) //"gwhlGAT6y3ua+P/FOjOiLWocisI="
                            {
                                user.FirstName = tbluser.FirstName;
                                user.LastName = tbluser.LastName;
                                user.Email = tbluser.Email;
                                user.Id = tbluser.Id;
                                user.GroceryList = UserProductManager.LoadByUserId(tbluser.Id);
                                return true;
                            }
                            else
                            {
                                throw new Exception("Cannot log in with these credentials!");
                            }
                        }
                        else
                        {
                            throw new Exception("User could not be found!");
                        }
                    }
                }
                else
                {
                    throw new Exception("Password was not set!");
                }
            }
            else
            {
                throw new Exception("User Id was not set!");
            }
            
        }
    }
}
