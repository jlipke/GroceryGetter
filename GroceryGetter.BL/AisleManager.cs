using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryGetter.BL.Models;
using GroceryGetter.PL;

namespace GroceryGetter.BL
{
    public class AisleManager
    {
        public static List<Aisle> LoadByLayoutId(Guid layoutId)
        {
            try
            {
                List<Aisle> aisles = new List<Aisle>();
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                   
                    var results = dc.tblAisles.Where(a => a.LayoutId == layoutId);

                    foreach (var aisle in results)
                    {
                        Aisle a = new Aisle();
                        a.Id = aisle.Id;
                        a.LayoutId = aisle.LayoutId;
                        a.Number = aisle.Number;
                        a.Lineup = aisle.Lineup;
                        a.Products = ProductManager.LoadByAisleId(aisle.Id);
                        aisles.Add(a);
                    }
                }
                return aisles;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
