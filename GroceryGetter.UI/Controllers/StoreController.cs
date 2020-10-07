using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GroceryGetter.BL;
using GroceryGetter.BL.Models;
using GroceryGetter.UI.Models;

namespace GroceryGetter.UI.Controllers
{
    public class StoreController : Controller
    {

        //StoreManager storeList;

        // GET
        public ActionResult Index()
        {
            // Remove commenting once login is fixed
            //if (Authenticate.IsAuthenticated())
            //{
            //storeList = new StoreManager();
            var storeList = StoreManager.Load();
            return View(storeList);
            //}
            //else
            //{
            //    //Need to authenticate
            //    return RedirectToAction("Login", "User", new { returnurl = HttpContext.Request.Url });
            //}
        }

        // GET
        /*
        public ActionResult Details(int id)
        {
            return View();
        }
        */

        // GET
        public ActionResult Create()
        {
            Store store = new Store();
            return View(store);
        }

        // POST
        [HttpPost]
        public ActionResult Create(Store store)
        {
            try
            {
                // TODO: Add insert logic here
                StoreManager.Insert(store);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(store);
            }
        }

        // GET
        public ActionResult Edit(Guid id)
        {
            Store store = StoreManager.LoadbyId(id);
            return View(store);
        }

        // POST
        [HttpPost]
        public ActionResult Edit([Bind(Include ="Id, Title")] Store store)
        {
            try
            {
                // TODO: Add update logic here
                StoreManager.Update(store);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(store);
            }
        }

        // GET
        public ActionResult Delete(Guid id)
        {
            Store store = StoreManager.LoadbyId(id);
            return View(store);
        }

        // POST
        [HttpPost]
        public ActionResult Delete(Guid id, Store store)
        {
            try
            {
                // TODO: Add delete logic here
                StoreManager.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(id);
            }
        }
    }
}
