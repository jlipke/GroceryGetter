using System;
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
                var userProductList = UserProductManager.LoadByUserId(user.Id);
                ViewBag.Message = ViewBag.Message;
                return View(userProductList);
            }
            else
            {
                //Need to authenticate
                return RedirectToAction("Login", "User", new { returnurl = HttpContext.Request.Url });
            }

        }

        // Index used for the Edit screen
        public ActionResult EditIndex()
        {
            if (Authenticate.IsAuthenticated())
            {
                var user = Session["user"] as User;
                var userProductList = UserProductManager.LoadByUserId(user.Id);
                ViewBag.Message = ViewBag.Message;
                return View(userProductList);
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
        public ActionResult AddProducts()
        {
            if (Authenticate.IsAuthenticated())
            {
                UserUserProduct uup = new UserUserProduct();
                
                uup.User = Session["user"] as User;
                uup.Products = ProductManager.LoadAll();
                uup.UserProduct = new UserProduct();
                uup.UserProduct.UserId = uup.User.Id;

                return View(uup);
            }

            return View("Index");

        }

        // POST
        [HttpPost]
        public ActionResult AddProducts(UserUserProduct uup)
        {

            // TODO: Add insert logic here

            UserProductManager.Insert(uup.UserProduct);

            return RedirectToAction("Index");

        }

        // GET
        public ActionResult Create()
        {
            if (Authenticate.IsAuthenticated())
            {
                var user = Session["user"] as User;
                List<Product> products = ProductManager.LoadAll();
                ViewBag.Message = ViewBag.Message;


                return View(products);
            }

            return View();

        }

        // POST
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

        // GET
        public ActionResult Edit(Guid id)
        {
            var user = Session["user"] as User;
            UserProduct userProduct = UserProductManager.LoadById(id);
            //UserProduct userProduct = UserProductManager.SearchGroceryByProduct(user.Id, product.Title);

            return View(userProduct);
        }

        // POST
        [HttpPost]
        public ActionResult Edit(UserProduct userProduct, FormCollection collection)
        {
            try
            {
                UserProductManager.Update(userProduct);
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
