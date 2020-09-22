using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryGetter.PL;
using GroceryGetter.BL.Models;

namespace GroceryGetter.BL
{
    public class AisleProductManager
    {
        public static int Insert(AisleProduct aisleProduct)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblAisleProduct newrow = new tblAisleProduct();
                    newrow.Id = Guid.NewGuid();
                    newrow.AisleId = aisleProduct.AisleId;
                    newrow.ProductId = aisleProduct.ProductId;

                    dc.tblAisleProducts.Add(newrow);

                    return dc.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static AisleProduct LoadAisleByProductId(Guid productId)
        {
            try
            {
                
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                   
                    var results = (from ap in dc.tblAisleProducts
                                   join a in dc.tblAisles on ap.AisleId equals a.Id
                                   join p in dc.tblProducts on ap.ProductId equals p.Id
                                   join l in dc.tblLayouts on a.LayoutId equals l.Id
                                   where ap.ProductId == productId
                                   select new
                                   {
                                       
                                       Id = ap.Id,
                                       AisleId = a.Id,
                                       ProductId = p.Id,
                                       AisleNumber = a.Number
                                       
                                   }).FirstOrDefault();

                    // Create a new AisleProduct object based on returned values
                    AisleProduct aisleProduct = new AisleProduct(); 
                    aisleProduct.Id = results.Id;
                    aisleProduct.AisleId = results.AisleId;
                    aisleProduct.ProductId = results.ProductId;
                    aisleProduct.AisleNumber = results.AisleNumber;
                    return aisleProduct;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int Update(AisleProduct aisleProduct)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblAisleProduct updatedrow = dc.tblAisleProducts.FirstOrDefault(ap => ap.Id == aisleProduct.Id);

                    if (updatedrow != null)
                    {
                        updatedrow.Id = aisleProduct.Id;        
                        updatedrow.AisleId = aisleProduct.AisleId;
                        updatedrow.ProductId = aisleProduct.ProductId;

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

        public static int Delete(Guid aisleId, Guid productId)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblAisleProduct deletedrow = dc.tblAisleProducts
                                             .FirstOrDefault(u => u.AisleId == aisleId
                                             && u.ProductId == productId);

                    if (deletedrow != null)
                    {
                        dc.tblAisleProducts.Remove(deletedrow);
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
    }
}
