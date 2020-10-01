using GroceryGetter.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroceryGetter.UI.Controllers
{
    public class ProductController : Controller
    {
        // GET
        public ActionResult Index()
        {
            var products = ProductManager.LoadAll();
            return View(products);
        }
    }
}