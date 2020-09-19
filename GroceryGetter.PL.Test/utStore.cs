using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GroceryGetter.PL;
using System.Linq;

namespace GroceryGetter.PL.Test
{
    [TestClass]
    public class utStore
    {
        [TestMethod]
        public void Insert()
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    Assert.AreEqual(3, dc.tblStores.Count());
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }
    }
}
