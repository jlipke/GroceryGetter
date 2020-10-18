using System;
using System.Collections.Generic;
using System.Linq;
using GroceryGetter.BL.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GroceryGetter.BL.Test
{
    [TestClass]
    public class utProductHelper
    {

        private List<UserProduct> theList; 


        [TestMethod]
        public void CanMakeList()
        {
            theList = ProductHelper.GetSomeDummyData();
            Assert.AreEqual(4, theList.Count);
        }


        [TestMethod]
        public void CanInsert()
        {
            theList = ProductHelper.GetSomeDummyData();


            UserProduct p = new UserProduct();
            p.Id = Guid.NewGuid();
            p.Title = "xbox";

            theList = ProductHelper.AddItemToList(p, theList);
            Assert.IsTrue(theList.Contains(p));

        }

        [TestMethod]
        public void CanRemove()
        {
            theList = ProductHelper.GetSomeDummyData();

            UserProduct x = new UserProduct();
            x.Id = Guid.NewGuid();
            x.Title = "xbox";
            theList.Add(x);

            theList = ProductHelper.RemoveItemToList(x, theList);
            Assert.IsFalse(theList.Contains(x));
        }
    }
}
