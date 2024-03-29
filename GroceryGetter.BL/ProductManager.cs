﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using GroceryGetter.BL.Models;
using GroceryGetter.PL;

namespace GroceryGetter.BL
{
    public class ProductManager
    {

        // TODO: Add code to order list of Products alphabetically
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

        public static List<Product> Load()
        {
            try
            {
                List<Product> products = new List<Product>();

                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    var results = (from p in dc.tblProducts
                                   orderby p.Title
                                   select new
                                   {
                                       p.Id,
                                       p.Title
                                   }).ToList();
                    foreach (var p in results)
                    {
                        Product product = new Product();
                        product.Id = p.Id;
                        product.Title = p.Title;
                        products.Add(product);
                    }
                    return products;
                }
            }
            catch (Exception)
            {

                throw;
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

        public static string LoadNutritionData(Guid id)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblProduct tblProduct = dc.tblProducts.FirstOrDefault(c => c.Id == id);
                    if (tblProduct != null)
                    {

                        return tblProduct.Title;

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

        public static int Delete(Guid id)
        {

            using (GroceryGetterEntities dc = new GroceryGetterEntities())
            {
                tblProduct deleterow = dc.tblProducts.FirstOrDefault(p => p.Id == id);
                if (deleterow != null)
                {
                    dc.tblProducts.Remove(deleterow);
                    return dc.SaveChanges();
                }
                else
                {
                    throw new Exception("Row was not found!!");
                }
            }

        }

        public static int Insert(Product product)
        {

            using (GroceryGetterEntities dc = new GroceryGetterEntities())
            {

                tblProduct newRow = new tblProduct();


                newRow.Id = Guid.NewGuid();
                newRow.Title = product.Title;

                dc.tblProducts.Add(newRow);
                return dc.SaveChanges();
            }

        }

    }
}
