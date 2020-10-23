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
            var layoutList = LayoutManager.LoadById(id); //Manually add LayoutId to url for now
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
        public ActionResult Edit(Guid id)
        {
            Layout layout = LayoutManager.LoadById(id);
            return View(layout);
        }

        // POST
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, StoreId, Title")] Layout layout)
        {
            try
            {
                // TODO: Add update logic here
                LayoutManager.Update(layout);
                return RedirectToAction("Index/" + layout.Id);
            }
            catch
            {
                return View(layout);
            }
        }

        // GET
        public ActionResult Delete(Guid id)
        {
            Layout layout = LayoutManager.LoadById(id);
            return View(layout);
        }

        // POST
        [HttpPost]
        public ActionResult Delete(Guid id, Layout layout)
        {
            try
            {
                // TODO: Add delete logic here
                LayoutManager.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
