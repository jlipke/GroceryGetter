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
    public class AisleController : Controller
    {
        // GET:
        public ActionResult Index()
        {
            // Remove commenting once login is fixed
            //if (Authenticate.IsAuthenticated())
            //{
            
            var AisleList = AisleManager.Load();
            return View(AisleList);
            //}
            //else
            //{
            //    //Need to authenticate
            //    return RedirectToAction("Login", "User", new { returnurl = HttpContext.Request.Url });
            //}
        }

        // GET: 
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: 
        public ActionResult Create()
        {
            return View();
        }

        // POST: 
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET:
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: 
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

        // GET: Aisle/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Aisle/Delete/5
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
