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
                
                uup.UserProduct = new UserProduct();
                uup.User = Session["user"] as User;
                uup.UserProduct.UserId = uup.User.Id;
                uup.Products = ProductManager.LoadAll();
                //Product product = ProductManager.LoadById();
                //uup.UserProduct.ProductId = uup.Products.FirstOrDefault().Id;

                //UserProduct uup = new UserProduct();
                //var user = Session["user"] as User;
                //List<Product> products = ProductManager.LoadAll();



                ViewBag.Message = ViewBag.Message;

                return View(uup);
            }

            return View();

        }

        // POST
        [HttpPost]
        public ActionResult AddProducts(UserUserProduct uup, FormCollection collection)
        {

            // TODO: Add insert logic here
            //uup.UserProduct.Id = Guid.NewGuid();
            //uup.UserProduct.UserId = uup.User.Id;
            //uup.UserProduct.ProductId = ProductManager.LoadById(uup.Products.);
            //uup.UserProduct.InCart = uup.UserProduct.InCart;
            //uup.UserProduct.Amount = uup.UserProduct.Amount;
            //uup.UserProduct.Notes = uup.UserProduct.Notes;

            UserProductManager.Insert(uup.UserProduct);
            //uup.Products.ToList().ForEach(p => ProductManager.)

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
