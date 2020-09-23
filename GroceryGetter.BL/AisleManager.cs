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
        public static int Insert(Aisle aisle)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblAisle tblaisle = new tblAisle();
                    tblaisle.Id = Guid.NewGuid();
                    tblaisle.LayoutId = aisle.LayoutId;
                    tblaisle.Number = aisle.Number;
                    tblaisle.Lineup = aisle.Lineup;

                    aisle.Id = tblaisle.Id;

                    dc.tblAisles.Add(tblaisle);
                    return dc.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static int Update(Aisle aisle)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblAisle tblaisle = dc.tblAisles.FirstOrDefault(a => a.Id == aisle.Id);

                    if (tblaisle != null)
                    {
                        tblaisle.LayoutId = aisle.LayoutId;
                        tblaisle.Number = aisle.Number;
                        tblaisle.Lineup = aisle.Lineup;

                        return dc.SaveChanges();
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int Delete(Aisle aisle)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblAisle tblaisle = dc.tblAisles.FirstOrDefault(a => a.Id == aisle.Id);

                    if (tblaisle != null)
                    {
                        dc.tblAisles.Remove(tblaisle);
                        return dc.SaveChanges();
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<Aisle> Load()
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    List<Aisle> aisles = new List<Aisle>();

                    dc.tblAisles.ToList().ForEach(a => aisles.Add(new Aisle
                    {
                        Id = a.Id,
                        LayoutId = a.LayoutId,
                        Number = a.Number,
                        Lineup = a.Lineup
                    }));

                    return aisles;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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
