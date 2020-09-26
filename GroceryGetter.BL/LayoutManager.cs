using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryGetter.PL;
using GroceryGetter.BL.Models;

namespace GroceryGetter.BL
{
    public class LayoutManager
    {
        public static Layout LoadById(Guid id)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblLayout tbllayout = dc.tblLayouts.FirstOrDefault(l => l.Id == id);
                    Layout layout = new Layout();

                    if (tbllayout != null)
                    {
                        layout.Id = tbllayout.Id;
                        //layout.StoreId = (StoreManager.LoadByLayoutId(id)).Id;
                        layout.Title = tbllayout.Title;

                        return layout;
                    }
                    else
                    {
                        throw new Exception("Cannot find Layout.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Layout> LoadByStoreId(Guid StoreId)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    var results = dc.tblLayouts.Where(l => l.StoreId == StoreId).ToList();
                    List<Layout> layouts = new List<Layout>();
                    if (results != null)
                    {
                        foreach (var item in results)
                        {
                            Layout layout = new Layout
                            {
                                Id = item.Id,
                                StoreId = item.StoreId,
                                Title = item.Title,
                                Aisles = AisleManager.LoadByLayoutId(item.Id)
                            };
                            layouts.Add(layout);
                        }
                        return layouts;
                    }
                    else
                    {
                        throw new Exception("Cannot find Layout.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int Insert(Layout layout)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    // Make a new row
                    tblLayout newrow = new tblLayout();

                    // Set the properties
                    newrow.Id = Guid.NewGuid();
                    newrow.Title = layout.Title;
                    newrow.StoreId = layout.StoreId;

                    // Insert
                    dc.tblLayouts.Add(newrow);
                    return dc.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int Update(Layout layout)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblLayout updatedrow = dc.tblLayouts.FirstOrDefault(l => l.Id == layout.Id);

                    if (updatedrow != null)
                    {
                        updatedrow.StoreId = layout.StoreId;
                        updatedrow.Title = layout.Title;

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

        public static int Delete(Layout layout)
        {
            try
            {
                using (GroceryGetterEntities dc = new GroceryGetterEntities())
                {
                    tblLayout deletedrow = dc.tblLayouts.FirstOrDefault(l => l.Id == layout.Id);

                    if (deletedrow != null)
                    {
                        dc.tblLayouts.Remove(deletedrow);
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
