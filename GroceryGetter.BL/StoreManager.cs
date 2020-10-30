using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryGetter.BL.Models;
using GroceryGetter.PL;

namespace GroceryGetter.BL
{
    public class StoreManager
    {
        public static bool Insert(Store store)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblStore newrow = new tblStore();
                    newrow.Id = Guid.NewGuid();
                    newrow.Title = store.Title;
                    dc.tblStores.Add(newrow);
                    dc.SaveChanges();
                    store.Id = newrow.Id;
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static int Update(Store store)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblStore updatedrow = dc.tblStores.Where(c => c.Id == store.Id).FirstOrDefault();
                    if(updatedrow != null)
                    {
                        updatedrow.Title = store.Title;

                        return dc.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Row was not found!");
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public static int Delete(Guid id)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblStore deleterow = dc.tblStores.FirstOrDefault(c => c.Id == id);
                    if(deleterow != null)
                    {
                        dc.tblStores.Remove(deleterow);
                        return dc.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Row was not found!!");
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static Store LoadbyId(Guid id)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblStore tblStore = dc.tblStores.FirstOrDefault(c => c.Id == id);
                    if(tblStore != null)
                    {
                        Store store = new Store
                        {
                            Id = tblStore.Id,
                            Title = tblStore.Title
                        };
                        return store;
                    }
                    else
                    {
                        throw new Exception("Row was not found!!!");
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static Store LoadByTitle(string title)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblStore tblStore = dc.tblStores.FirstOrDefault(s => s.Title == title);
                    if(tblStore != null)
                    {
                        Store store = new Store
                        {
                            Id = tblStore.Id,
                            Title = tblStore.Title
                        };
                        return store;
                    }
                    else
                    {
                        throw new Exception("Row was not found!!!!");
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static Store LoadByLayoutId(Guid layoutId)
        {
            try
            {
                Store store = new Store();
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    Guid resolvedId = dc.tblLayouts.Where(layout => layout.Id == layoutId).FirstOrDefault().StoreId;
                    var result = dc.tblStores.Where(s => s.Id == resolvedId).FirstOrDefault();

                    if(result != null)
                    {
                        store.Id = result.Id;
                        store.Title = result.Title;
                    }
                    return store;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // TODO: Add code to sort the list alphabetically by Store.Title
        public static List<Store> Load()
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    List<Store> stores = new List<Store>();
                    dc.tblStores.ToList().ForEach(s => stores.Add(new Store
                    {
                        Id = s.Id,
                        Title = s.Title
                    }));
                    return stores;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
