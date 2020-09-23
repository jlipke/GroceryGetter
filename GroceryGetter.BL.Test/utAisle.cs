using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GroceryGetter.BL;
using GroceryGetter.BL.Models;
using System.Collections.Generic;
using System.Linq;

namespace GroceryGetter.BL.Test
{
    [TestClass]
    public class utAisle
    {
        [TestMethod]
        public void RunAll()
        {
            LoadTest();
            InsertTest();
            UpdateTest();
            DeleteTest();
        }

        public void LoadTest()
        {
            List<Aisle> aisles = AisleManager.Load();

            int expected = 35;
            int actual = aisles.Count;

            Assert.AreEqual(expected, actual);
        }

        public void InsertTest()
        {
            List<Layout> layouts = new List<Layout>();
            Layout layout = layouts.Where(l => l.Title == "L_Aldi-De Pere").FirstOrDefault();
            Aisle aisle = new Aisle { LayoutId = layout.Id, Number = "Test Aisle", Lineup = 999999 };
            int actual = AisleManager.Insert(aisle);
            Assert.IsTrue(actual > 0);
        }

        public void UpdateTest()
        {
            List<Aisle> aisles = AisleManager.Load();
            Aisle aisle = aisles.Where(a => a.Number == "Test Aisle").FirstOrDefault();
            aisle.Number = "New Aisle";
            int actual = AisleManager.Update(aisle);
            Assert.IsTrue(actual > 0);
        }

        public void DeleteTest()
        {
            List<Aisle> aisles = AisleManager.Load();
            Aisle aisle = aisles.Where(a => a.Number == "New Aisle").FirstOrDefault();
            int actual = AisleManager.Delete(aisle);
            Assert.IsTrue(actual > 0);
        }
    }
}
