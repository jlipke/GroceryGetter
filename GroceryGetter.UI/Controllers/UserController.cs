﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroceryGetter.UI.Controllers
{
    public class UserController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }

        // GET
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET
        public ActionResult SignUp()
        {
            return View();
        }

        // POST
        [HttpPost]
        public ActionResult SignUp(FormCollection collection)
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
