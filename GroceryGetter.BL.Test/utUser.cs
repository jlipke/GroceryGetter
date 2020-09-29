using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GroceryGetter.BL;
using GroceryGetter.BL.Models;
using System.Collections.Generic;
using System.Linq;

namespace MIB.GroceryGetter.BL.Test
{
    [TestClass]
    public class utUser
    {
        //[TestMethod]
        public void RunAll()
        {
            LoadTest();
            InsertTest();
            UpdateTest();
            DeleteTest();
        }

        [TestMethod]
        public void LoginInTest()
        {
            User user = UserManager.Load().FirstOrDefault();
            //Console.WriteLine(user.Email);
            //Assert.AreEqual("300019014@fvtc.edu", user.Email);
            Assert.IsTrue(UserManager.Login(user));
        }

        public void LoadTest()
        {
            List<User> users = UserManager.Load();

            int actual = users.Count;
            Assert.AreNotEqual(0, actual);
        }

        public void InsertTest()
        {
            List<User> users = new List<User>();
            User user = new User { Id = Guid.NewGuid(), Email = "testemail@gmail.com", FirstName = "test name", LastName = "test name", UserPass = "testpassword" };
            Assert.IsTrue(Convert.ToBoolean(UserManager.Insert(user)));
        }

        public void UpdateTest()
        {
            List<User> users = UserManager.Load();
            User user = users.Where(u => u.Email == "testemail@gmail.com").FirstOrDefault();
            user.Email = "updatedemail@gmail.com";
            int actual = UserManager.Update(user);
            Assert.IsTrue(actual > 0);
        }

        public void DeleteTest()
        {
            List<User> users = UserManager.Load();
            User user = users.Where(u => u.Email == "updatedemail@gmail.com").FirstOrDefault();
            int actual = UserManager.Delete(user.Id);
            Assert.IsTrue(actual > 0);
        }
    }
}
