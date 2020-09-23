using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryGetter.PL;
using GroceryGetter.BL.Models;

namespace GroceryGetter.BL
{
    public class UserProductManager
    {
        public static int Insert(UserProduct userProduct)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblUserProduct up = new tblUserProduct();
                    up.Id = Guid.NewGuid();
                    up.UserId = userProduct.UserId;
                    up.ProductId = userProduct.ProductId;
                    up.Amount = userProduct.Amount;
                    up.Notes = userProduct.Notes;
                    up.InCart = userProduct.InCart;

                    dc.tblUserProducts.Add(up);

                    return dc.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int Update(UserProduct userProduct)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblUserProduct tbluserProduct = dc.tblUserProducts.FirstOrDefault(up => up.Id == userProduct.Id);
                    if (tbluserProduct != null)
                    {
                        tbluserProduct.UserId = userProduct.UserId;
                        tbluserProduct.ProductId = userProduct.ProductId;
                        tbluserProduct.Amount = userProduct.Amount;
                        tbluserProduct.Notes = userProduct.Notes;
                        tbluserProduct.InCart = userProduct.InCart;

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

        public static int Delete(Guid id)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblUserProduct row = dc.tblUserProducts
                                             .FirstOrDefault(up => up.Id == id);

                    if (row != null)
                    {
                        dc.tblUserProducts.Remove(row);
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

        // Load GroceryList by UserId
        public static List<UserProduct> LoadByUserId(Guid userId)
        {
            try
            {
                List<UserProduct> userProducts = new List<UserProduct>();

                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    var results = (from up in dc.tblUserProducts
                                   join p in dc.tblProducts on up.ProductId equals p.Id
                                   where up.UserId == userId
                                   select new
                                   {
                                       up.Id,
                                       up.UserId,
                                       up.ProductId,
                                       p.Title,
                                       up.Amount,
                                       up.Notes,
                                       up.InCart
                                   }).ToList();
                    foreach (var up in results)
                    {
                        UserProduct userProduct = new UserProduct();
                        userProduct.Id = up.Id;
                        userProduct.UserId = up.UserId;
                        userProduct.ProductId = up.ProductId;
                        userProduct.ProductTitle = up.Title;
                        userProduct.Amount = up.Amount;
                        userProduct.Notes = up.Notes;
                        userProduct.InCart = up.InCart;
                        userProducts.Add(userProduct);
                    }
                    return userProducts;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Load GroceryList by StoreId and order by...
        public static List<UserProduct> LoadGroceryByLayout(Guid userId, Guid storeId)
        {
            try
            {
                List<UserProduct> userProducts = new List<UserProduct>();

                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    var results = (from up in dc.tblUserProducts
                                   join p in dc.tblProducts on up.ProductId equals p.Id
                                   join ap in dc.tblAisleProducts on p.Id equals ap.ProductId
                                   join a in dc.tblAisles on ap.AisleId equals a.Id
                                   join l in dc.tblLayouts on a.LayoutId equals l.Id
                                   join s in dc.tblStores on l.StoreId equals s.Id
                                   where up.UserId == userId && s.Id == storeId
                                   orderby a.Lineup, p.Title
                                   select new
                                   {
                                       up.Id,
                                       up.UserId,
                                       up.ProductId,
                                       p.Title,
                                       up.Amount,
                                       up.Notes,
                                       up.InCart,
                                       a.Number
                                   }).ToList();
                    foreach (var up in results)
                    {
                        UserProduct userProduct = new UserProduct();
                        userProduct.Id = up.Id;
                        userProduct.UserId = up.UserId;
                        userProduct.ProductId = up.ProductId;
                        userProduct.ProductTitle = up.Title;
                        userProduct.Amount = up.Amount;
                        userProduct.Notes = up.Notes;
                        userProduct.InCart = up.InCart;
                        userProduct.ProductAisle = up.Number;

                        userProducts.Add(userProduct);
                    }
                    return userProducts;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<UserProduct> LoadGroceryByLayout(Guid userId)
        {
            try
            {
                List<UserProduct> userProducts = new List<UserProduct>();

                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    var results = (from up in dc.tblUserProducts
                                   join p in dc.tblProducts on up.ProductId equals p.Id
                                   join ap in dc.tblAisleProducts on p.Id equals ap.ProductId
                                   join a in dc.tblAisles on ap.AisleId equals a.Id
                                   where up.UserId == userId
                                   select new
                                   {
                                       up.Id,
                                       up.UserId,
                                       up.ProductId,
                                       p.Title,
                                       up.Amount,
                                       up.Notes,
                                       up.InCart,
                                       a.Number
                                   }).ToList();
                    foreach (var up in results)
                    {
                        UserProduct userProduct = new UserProduct();
                        userProduct.Id = up.Id;
                        userProduct.UserId = up.UserId;
                        userProduct.ProductId = up.ProductId;
                        userProduct.ProductTitle = up.Title;
                        userProduct.Amount = up.Amount;
                        userProduct.Notes = up.Notes;
                        userProduct.InCart = up.InCart;
                        userProduct.ProductAisle = up.Number;
                        userProducts.Add(userProduct);
                    }
                    return userProducts;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // Check to see if a user's grocery list includes a product
        public static UserProduct SearchGroceryByProduct(Guid userId, string productTitle)
        {
            try
            {
                List<UserProduct> userProducts = new List<UserProduct>();

                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    var results = (from up in dc.tblUserProducts
                                   join p in dc.tblProducts on up.ProductId equals p.Id
                                   where up.UserId == userId && p.Title == productTitle
                                   orderby productTitle
                                   select new
                                   {
                                       up.Id,
                                       up.UserId,
                                       up.ProductId,
                                       p.Title,
                                       up.Amount,
                                       up.Notes,
                                       up.InCart
                                   }).ToList();
                    foreach (var up in results)
                    {
                        UserProduct userProduct = new UserProduct();
                        userProduct.Id = up.Id;
                        userProduct.UserId = up.UserId;
                        userProduct.ProductId = up.ProductId;
                        userProduct.ProductTitle = up.Title;
                        userProduct.Amount = up.Amount;
                        userProduct.Notes = up.Notes;
                        userProduct.InCart = up.InCart;
                        userProducts.Add(userProduct);
                    }
                    return userProducts.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
