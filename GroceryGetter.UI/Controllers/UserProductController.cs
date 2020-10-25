﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GroceryGetter.BL;
using GroceryGetter.BL.Models;
using GroceryGetter.UI.Models;
using GroceryGetter.UI.ViewModels;

namespace GroceryGetter.UI.Controllers
{
    public class UserProductController : Controller
    {
        // GET
        public ActionResult Index()
        {
            if (Authenticate.IsAuthenticated())
            {
                var user = Session["user"] as User;
                //var userProductList = UserProductManager.LoadByUserId(user.Id);
                //var userProductList = new List<UserProduct>(); 
                //ViewBag.Message = ViewBag.Message;
                return View(user);
            }
            else
            {
                //Need to authenticate
                return RedirectToAction("Login", "User", new { returnurl = HttpContext.Request.Url });
            }
            
        }

        // GET
        [HttpPost]
        public ActionResult Index(Product p)
        {
            if (Authenticate.IsAuthenticated())
            {
                var x = HttpContext.Request.Form["ItemName"];
                var user = Session["user"] as User;

                UserProduct up = new UserProduct();
                up.Aisle = p.Aisle;
                up.Id = p.Id;
                up.Store = p.Store;
                //up.Title = p.Title;
                up.Title = x;

                ProductHelper.AddItemToList(up, user.GroceryListObj);
                ViewBag.Message = x;
                return View(user);
            }
            else
            {
                //Need to authenticate
                return RedirectToAction("Login", "User", new { returnurl = HttpContext.Request.Url });
            }

        }


        // GET
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET
        public ActionResult Create()
        {
            if (Authenticate.IsAuthenticated())
            {
                UpProducts upProducts = new UpProducts();
                upProducts.UserProduct = new UserProduct();
                upProducts.Products = ProductManager.LoadAll();
                return View(upProducts);
            }

            return View();
            
        }

        // POST
        [HttpPost]
        public ActionResult Create(UpProducts upProducts)
        {
            try
            {
                // TODO: Add insert logic here
                //UserProductManager.Insert(upProducts.UserProduct);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET
        public ActionResult Edit(Product product)
        {
            var user = Session["user"] as User;
            //UpProducts upProducts = new UpProducts();
            //upProducts.UserProduct = UserProductManager.SearchGroceryByProduct(user.Id, userProduct.ProductTitle);
            //UserProduct userProduct = UserProductManager.SearchGroceryByProduct(user.Id, product.Title);


            var userProduct = new List<UserProduct>();
            return View(userProduct);
        }

        // POST
        [HttpPost]
        public ActionResult Edit(UserProduct userProduct)
        {
            try
            {
               // UserProductManager.Update(userProduct);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        //// GET
        //public ActionResult Edit(Guid id)
        //{
        //    UserProduct userProduct = UserProductManager.LoadById(id);
        //    //UpProducts upProducts = new UpProducts();
        //    //upProducts.UserProduct = new UserProduct();
        //    //upProducts.Products = ProductManager.LoadAll();
        //    return View(userProduct);
        //}

        //// POST
        //[HttpPost]
        //public ActionResult Edit(UpProducts upProducts, FormCollection collection)
        //{
        //    try
        //    {
        //        UserProductManager.Update(upProducts.UserProduct);
        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}


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
