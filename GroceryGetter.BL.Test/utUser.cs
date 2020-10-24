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
        public void LoginTest()
        {
            List<User> users = new List<User>();
            User user = new User { Id = Guid.NewGuid(), Email = "testemail@gmail.com", FirstName = "test name", LastName = "test name", UserPass = "testpassword" };
            UserManager.Insert(user);
            //User user = UserManager.Load().FirstOrDefault();
             //Console.WriteLine(user.Email);
            //Assert.AreEqual("300019014@fvtc.edu", user.Email);
            Assert.IsTrue(UserManager.Login(user));
        }

        [TestMethod]
        public void HashTest()
        {
            string password = "wombat";
            string input = UserManager.CreateHash(password);

            bool theCheck = UserManager.VerifyHash(password, input);
            Assert.IsTrue(theCheck);
        }

        [TestMethod]
        public void LoadTest()
        {
            List<User> users = UserManager.Load();

            int actual = users.Count;
            Assert.AreNotEqual(0, actual);
        }

        [TestMethod]
        public void LoadTimJackson()
        {
            var id = "timtiml@gmail.com";
            User tim = UserManager.LoadByEmail(id);

            List<UserProduct> timsStuff = ProductHelper.JsonToOjects(tim.GroceryList);

            int actual = timsStuff.Count;
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void InsertTest()
        {
            //List<User> users = new List<User>();


            List<UserProduct> stuff = ProductHelper.GetSomeDummyData();



            User user = new User();
            user.Email = "timtiml@gmail.com";
            user.FirstName = "tim";
            user.LastName = "jackson";
            user.UserPass = "testpassword";
            user.GroceryList = ProductHelper.ObjectToJson(stuff);
            

            Assert.IsTrue(Convert.ToBoolean(UserManager.Insert(user)));
        }

        [TestMethod]
        public void UpdateTest()
        {
            List<User> users = UserManager.Load();
            User user = users.Where(u => u.Email == "testemail@gmail.com").FirstOrDefault();
            user.Email = "updatedemail@gmail.com";
            bool actual = UserManager.Update(user);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void DeleteTest()
        {
            List<User> users = UserManager.Load();
            User user = users.Where(u => u.Email == "updatedemail@gmail.com").FirstOrDefault();
            int actual = UserManager.Delete(user.Id);
            Assert.IsTrue(actual > 0);
        }
    }
}
