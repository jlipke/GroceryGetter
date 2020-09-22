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
                    tblAisleProduct ap = new tblAisleProduct();
                    ap.Id = Guid.NewGuid();
                    ap.AisleId = aisleProduct.AisleId;
                    ap.ProductId = aisleProduct.ProductId;

                    dc.tblAisleProducts.Add(ap);

                    return dc.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
