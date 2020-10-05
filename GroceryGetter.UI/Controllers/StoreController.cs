using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GroceryGetter.BL;
using GroceryGetter.BL.Models;

namespace GroceryGetter.UI.Controllers
{
    public class StoreController : Controller
    {

        //StoreManager storeList;

        // GET
        public ActionResult Index()
        {
            //storeList = new StoreManager();
            var storeList = StoreManager.Load();
            return View(storeList);
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
