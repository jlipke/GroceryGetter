using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GroceryGetter.BL;
using GroceryGetter.BL.Models;

namespace GroceryGetter.UI.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            // Authenticate.cs needs to be added to the Models folder (DVDCentral)
            /*if (Authenticate.IsAuthenticated())
            {
                List<User> users = UserManager.Load();
                return View(users);
            }
            else*/
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

        // GET User/Login
        public ActionResult Login(string returnurl)
        {
            User user = new User();
            ViewBag.ReturnUrl = returnurl;
            return View(user);
        }

        //POST User/Login
        [HttpPost]
        public ActionResult Login(User user, string returnurl)
        {
            try
            {
                if (UserManager.Login(user))
                {
                    Session["user"] = user;
                    if (!String.IsNullOrEmpty(returnurl))
                        return Redirect(returnurl);
                    else
                        return RedirectToAction("Index", "User");
                }
                ViewBag.Message = "Login could not be completed.";
                return View(user);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(user);
            }
        }

        public ActionResult Logout()
        {
            Session["user"] = null;
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            User user = new User();
            ViewBag.Title = "Create User";
            return View(user);
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            try
            {
                UserManager.Insert(user);
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
            // Might work
            User user = UserManager.LoadById(id); 
            return View(user);
        }

        // POST
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here


                //UserManager.Update(user);

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
