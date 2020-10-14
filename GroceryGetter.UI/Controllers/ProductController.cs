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
    public class ProductController : Controller
    {
        // GET
        public ActionResult Index()
        {
            // Remove commenting once login is fixed
            if (Authenticate.IsAuthenticated())
            {
                var products = ProductManager.LoadAll();
                ViewBag.Message = ViewBag.Message;
                return View(products);
            }
            else
            {
                //Need to authenticate
                return RedirectToAction("Login", "User", new { returnurl = HttpContext.Request.Url });
            }
        }
    }
}