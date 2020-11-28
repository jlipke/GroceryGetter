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
        public ActionResult UpdateCart(Guid id, Guid userId, Guid productId, bool inCart, int amount, string notes, string productTitle, string productAisle)
        {
            try
            {
                UserProduct up = new UserProduct();
                up.Id = id;
                up.UserId = userId;
                up.ProductId = productId;
                up.InCart = inCart;
                up.Amount = amount;
                up.Notes = notes;
                up.ProductTitle = productTitle;
                up.ProductAisle = productAisle;
                
                UserProductManager.Update(up);
                return View();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // Order UserProduct List by StoreId
        public ActionResult LoadByStoreId(Guid id)
        {
            if (Authenticate.IsAuthenticated())
            {
                var user = Session["user"] as User;
                var userProductList = UserProductManager.LoadGroceryByLayout(user.Id, id);

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
                uup.Products = ProductManager.Load();
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
                List<Product> products = ProductManager.Load();
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
            //var user = Session["user"] as User;
            UserProduct userProduct = UserProductManager.LoadById(id);
            //UserProduct userProduct = UserProductManager.SearchGroceryByProduct(user.Id, product.Title);

            return View(userProduct);
        }

        // POST
        [HttpPost]
        public ActionResult Edit(UserProduct userProduct)
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
        public ActionResult Delete(Guid id)
        {
            UserProduct userProduct = UserProductManager.LoadById(id);
            return View(userProduct);
        }

        // POST
        [HttpPost]
        public ActionResult Delete(UserProduct userProduct)
        {
            try
            {
                UserProductManager.Delete(userProduct.Id);

                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

    }
}
