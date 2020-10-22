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
                ViewBag.Message = ViewBag.Message;
                return View(AisleList);
            //}
            //else
            //{
                //Need to authenticate
                //return RedirectToAction("Login", "User", new { returnurl = HttpContext.Request.Url });
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
            Aisle aisle = new Aisle();
            return View(aisle);
        }

        // POST: 
        [HttpPost]
        public ActionResult Create(Aisle aisle)
        {
            try
            {
                // TODO: Add insert logic here
                AisleManager.Insert(aisle);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(aisle);
            }
        }

        // GET:
        public ActionResult Edit(Guid layoutId)
        {
            List<Aisle> aisle = AisleManager.LoadByLayoutId(layoutId);
            return View(layoutId);
        }

        // POST: 
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Number, Lineup")] Aisle aisle, Guid LayoutId)
        {
            try
            {
                // TODO: Add update logic here
                AisleManager.Update(aisle);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(aisle);
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
