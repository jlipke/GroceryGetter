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
    public class LayoutController : Controller
    {
        // GET
        public ActionResult Index(Guid id)
        {
            var layoutList = LayoutManager.LoadById(id);
            ViewBag.Message = ViewBag.Message;
            return View(layoutList);
        }

        // GET
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET
        public ActionResult Create()
        {
            Layout layout = new Layout();
            return View(layout);
        }

        // POST
        [HttpPost]
        public ActionResult Create(Layout layout)
        {
            try
            {
                // TODO: Add insert logic here
                LayoutManager.Insert(layout);
                return RedirectToAction("Index");

            }
            catch
            {
                return View(layout);
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
