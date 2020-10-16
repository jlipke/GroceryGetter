using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryGetter.BL.Models;
using GroceryGetter.PL;

namespace GroceryGetter.BL
{
    public class ProductManager
    {
        public static List<Product> LoadAll()
        {
            using (GroceryGetterEntities dc = new GroceryGetterEntities())
            {
                List<Product> products = new List<Product>();
                dc.tblProducts.ToList().ForEach(p => products.Add(new Product
                {
                    Id = p.Id,
                    Title = p.Title
                }));

                return products;

            }
            
        }

        public static Product LoadById(Guid id)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblProduct tblProduct = dc.tblProducts.FirstOrDefault(c => c.Id == id);
                    if (tblProduct != null)
                    {
                        Product product = new Product
                        {
                            Id = tblProduct.Id,
                            Title = tblProduct.Title
                        };
                        return product;
                    }
                    else
                    {
                        throw new Exception("Row was not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Product> LoadByAisleId(Guid aisleId)
        {
            List<Product> products = new List<Product>();
            using (GroceryGetterEntities dc = new GroceryGetterEntities())
            {
                    
                var results = (from ap in dc.tblAisleProducts
                                join p in dc.tblProducts on ap.ProductId equals p.Id
                                join a in dc.tblAisles on ap.AisleId equals a.Id
                                where ap.AisleId == aisleId
                                select new
                                {
                                    Id = p.Id,
                                    Title = p.Title
                                }).ToList();



                results.ForEach(p => products.Add(new Product
                {
                    Id = p.Id,
                    Title = p.Title,
                }));
            }
            return products;
          
        }

        public static int Update(Product product)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblProduct updatedrow = dc.tblProducts.Where(p => p.Id == product.Id).FirstOrDefault();
                    if (updatedrow != null)
                    {
                        updatedrow.Title = product.Title;

                        return dc.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Row was not found");
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
