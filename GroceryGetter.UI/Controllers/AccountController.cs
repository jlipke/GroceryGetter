using GroceryGetter.BL;
using GroceryGetter.BL.Models;
using GroceryGetter.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroceryGetter.UI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            if (Authenticate.IsAuthenticated())
            {
                var user = Session["user"] as User;
                ViewBag.Message = ViewBag.Message;
                return View(user);

            }
            else
            {
                //Need to authenticate
                return RedirectToAction("Login", "User", new { returnurl = HttpContext.Request.Url });
            }
        }

        public ActionResult Edit()
        {
            User user = new User();
            ViewBag.Title = "Edit Settings";
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User updateduser)
        {
            try
            {
                var user = Session["user"] as User;

                if (updateduser.FirstName != user.FirstName && updateduser.FirstName != null)
                    user.FirstName = updateduser.FirstName;

                if(updateduser.LastName != user.LastName && updateduser.LastName != null)
                    user.LastName = updateduser.LastName;

                if (updateduser.Email != user.Email && updateduser.Email != null)
                    user.Email = updateduser.Email;

                if(UserManager.Update(user))
                {
                    Session["user"] = user;
                }
                
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }



        public ActionResult ChangePassword()
        {
            //var user = Session["user"] as User;
            //PasswordResetManager.SendMessage(user.Email); 
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult ChangePassword(User user)
        {
            //var user = Session["user"] as User;
            //PasswordResetManager.SendMessage(user.Email); 
            return RedirectToAction("Index");
        }

        [ChildActionOnly]
        public ActionResult AccountBannerbar()
        {
            var user = Session["user"] as User;
            return PartialView(user);
                   
        }

        public ActionResult Settings()
        {
            User user = new User();
            ViewBag.Title = "Account Settings";
            return View(user);
        }

        // POST: User/Settings
        //[HttpPost]
        //public ActionResult Settings(User user)
        //{
        //    try
        //    {
        //        UserManager.Insert(user);
        //        return RedirectToAction("Index");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}


    }
}