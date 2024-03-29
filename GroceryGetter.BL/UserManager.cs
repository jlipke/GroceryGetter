﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GroceryGetter.BL.Models;
using GroceryGetter.PL;


namespace GroceryGetter.BL
{
    public class UserManager
    {
        public static int Insert(User user)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    if (user.FirstName != null)
                    {
                        if (user.LastName != null)
                        {
                            if (user.Email != null)
                            {
                                if (user.UserPass != null)   // This can be where we test if the password is long enough
                                {
                                    tblUser newrow = new tblUser();
                                    newrow.Id = Guid.NewGuid();
                                    newrow.FirstName = user.FirstName;
                                    newrow.LastName = user.LastName;
                                    newrow.Email = user.Email;
                                    newrow.UserPass = CreateHash(user.UserPass);
                                    user.Id = newrow.Id;
                                    dc.tblUsers.Add(newrow);

                                    return dc.SaveChanges();
                                }
                                else
                                {
                                    throw new Exception("Password is required");
                                }
                            }
                            else
                            {
                                throw new Exception("Email is required");
                            }

                        }
                        else
                        {
                            throw new Exception("Last Name is required");
                        }
                    }
                    else
                    {
                        throw new Exception("First name is required");
                    }

                }
            }
            
            catch (System.Data.Entity.Validation.DbEntityValidationException e)     // Use this to output validation errors in the output window
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    System.Diagnostics.Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public static bool Update(User user)
        {
            using (GroceryGetterEntities dc = new GroceryGetterEntities())
            {
                tblUser updatedrow = dc.tblUsers.Where(c => c.Id == user.Id).FirstOrDefault();
                if (updatedrow != null)
                {
                    updatedrow.FirstName = user.FirstName;
                    updatedrow.LastName = user.LastName;
                    updatedrow.Email = user.Email;
                    updatedrow.UserPass = CreateHash(user.UserPass);

                    dc.SaveChanges();
                    return true;
                }
                else
                {
                    throw new Exception("Row was not found!");
                }
            }

        }



        public static int UpdateGroceryList(User user) 
        {
            using (GroceryGetterEntities dc = new GroceryGetterEntities())
            {
                tblUser tbluser = dc.tblUsers.FirstOrDefault(u => u.Id == u.Id);

                if (tbluser != null)
                {
                    tbluser.FirstName = user.FirstName;
                    tbluser.LastName = user.LastName;
                    tbluser.Email = user.Email;
                    tbluser.UserPass = user.UserPass;

                    // Delete all the tblUserProduct rows and add back in.
                    var existing = dc.tblUserProducts.Where(up => up.UserId == user.Id);
                    dc.tblUserProducts.RemoveRange(existing);

                    List<tblUserProduct> tblUserProducts = new List<tblUserProduct>();

                    // Also make sense of the tblUserProducts
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

        public static int Delete(Guid id)
        {

            using (GroceryGetterEntities dc = new GroceryGetterEntities())
            {
                tblUser deleterow = dc.tblUsers.FirstOrDefault(c => c.Id == id);
                if (deleterow != null)
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

        public static void Seed()
        {
            User user = new User(Guid.NewGuid(), "Test", "Seed", "test@test.com", "Test123");
            Insert(user);
        }

        //public static User LoadByEmail(string email)
        //{
        //    try
        //    {
        //        List<User> users = new List<User>();
        //        using (GroceryGetterEntities dc = new GroceryGetterEntities())
        //        {
        //            var results = (from u in dc.tblUsers
        //                           join up in dc.tblUserProducts on u.Id equals up.UserId
        //                           join p in dc.tblProducts on up.ProductId equals p.Id
        //                           where u.Email == email
        //                           select u).ToList();
        //            results.ForEach(u => users.Add(new User
        //            {
        //                Id = u.Id,
        //                FirstName = u.FirstName,
        //                LastName = u.LastName,
        //                Email = u.Email,
        //                UserPass = u.UserPass,
        //                GroceryList = UserProductManager.LoadByUserId(u.Id)
        //            }));
        //        }
        //        return users.FirstOrDefault();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

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

                        if (tbluserproduct != null)
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

        public static User LoadByEmail(string email)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblUser tbluser = dc.tblUsers.FirstOrDefault(u => u.Email == email);
                    User user = new User();

                    if (tbluser != null)
                    {
                        user.Id = tbluser.Id;
                        user.FirstName = tbluser.FirstName;
                        user.LastName = tbluser.LastName;
                        user.Email = tbluser.Email;
                        user.UserPass = tbluser.UserPass;


                        tblUserProduct tbluserproduct = dc.tblUserProducts.FirstOrDefault(up => up.UserId == user.Id);

                        if (tbluserproduct != null)
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

        public static string CreateHash(string userpass)
        {
            // Create salt with PRNG
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            // Create Rfc2898DeriveBytes and get hashed value
            var pbkdf2 = new Rfc2898DeriveBytes(userpass, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Combine salt and password 
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            // Turn the combined salt+hash into a string and return
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            return savedPasswordHash;

        }

        public static bool VerifyHash(string savedPasswordHash, string userEnteredPassword)
        {

            // Extract bytes
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);

            // Get salt
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Compute the hash on the entered password
            var pbkdf2 = new Rfc2898DeriveBytes(userEnteredPassword, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);




            // Compare results
            bool result = true;
            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i])
                    result = false;

            if (result == false)
                return false;
            else
                return true;
            //test

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
                        if (tbluser != null)
                        {
                            //if(GetHash(tbluser.UserPass) == GetHash(user.UserPass)) //"gwhlGAT6y3ua+P/FOjOiLWocisI="
                            if (VerifyHash(tbluser.UserPass, user.UserPass))
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
                                // return false;
                                throw new Exception("Login Failed!");   // Cannot log in with these credentials
                            }
                        }
                        else
                        {
                            //return false;
                            throw new Exception("Login Failed!");    // User not found
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
                throw new Exception("Email was not set!");  // This outputs to the view so I changed it to "Email"
            }

        }
    }

}
