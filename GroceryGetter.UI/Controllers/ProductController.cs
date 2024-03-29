﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GroceryGetter.BL;
using GroceryGetter.BL.Models;
using GroceryGetter.UI.Models;

namespace GroceryGetter.UI.Controllers
{
    public class ProductController : Controller
    {
        // GET
        public ActionResult Index()
        {
            // Remove commenting once login is fixed
            if (Authenticate.IsAuthenticated())
            {
                var products = ProductManager.Load();
                ViewBag.Message = ViewBag.Message;
                return View(products);
            }
            else
            {
                //Need to authenticate
                return RedirectToAction("Login", "User", new { returnurl = HttpContext.Request.Url });
            }
        }

        public ActionResult Nutrition(Guid id)
        {
            var product = ProductManager.LoadNutritionData(id);
            ViewBag.Title = product;
            return View();
            //"~/Views/Product/Nutrition.cshtml"

        }

        public ActionResult Details(Guid id)
        {
            Product product = ProductManager.LoadById(id);
            ViewBag.Title = "Details";
            return View(product);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(Guid id)
        {
            Product product = ProductManager.LoadById(id);
            ViewBag.Title = "Edit Product";
            return View(product);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, Product product)
        {
            try
            {
                // TODO: Add update logic here
                ProductManager.Update(product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Create()
        {
            if (Authenticate.IsAuthenticated())
            {
                Product product = new Product();
                return View(product);
            }

            return View();

        }

        
        [HttpPost]
        public ActionResult Create(Product p)
        {
            try
            {
                ProductManager.Insert(p);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(Guid id)
        {
            Product product = ProductManager.LoadById(id);
            return View(product);
        }


        [HttpPost]
        public ActionResult Delete(Guid id, Store store)
        {
            try
            {
                
                ProductManager.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(id);
            }
        }

    }
}