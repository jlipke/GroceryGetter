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
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            if (Authenticate.IsAuthenticated())
            {
                List<User> users = UserManager.Load();
                ViewBag.Message = ViewBag.Message;
                return View(users);
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
                    // Login worked. Save User to session
                    Session["user"] = user;
                    if (user.GroceryList.Length == 1)
                    {
                        user.GroceryListObj = ProductHelper.GetSomeDummyData();  // to add default data (temp fix)
                    }
                    else
                    {
                        user.GroceryListObj = ProductHelper.JsonToOjects(user.GroceryList);
                    }

                    if (!String.IsNullOrEmpty(returnurl))
                        return Redirect(returnurl);
                    else

                        //return RedirectToAction("Index", "User");
                        return RedirectToAction("Index", "UserProduct");
                    //return RedirectToAction("Index", "Account");
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

        public ActionResult ChangePassword()
        {
            User user = new User();
            ViewBag.Title = "Reset Password";
            return View(user);

        }

        [HttpPost]
        public ActionResult ChangePassword(User user)
        {
            try
            {
                //var user = Session["user"] as User;
                PasswordResetManager.SendMessage(user.Email);
                return RedirectToAction("EmailSent");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public ActionResult EmailSent()
        {
            ViewBag.Title = "Email Sent";
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

            UserManager.Insert(user);
            return RedirectToAction("Index");
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
