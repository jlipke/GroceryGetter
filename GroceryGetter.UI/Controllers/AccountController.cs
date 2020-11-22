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

                if (updateduser.LastName != user.LastName && updateduser.LastName != null)
                    user.LastName = updateduser.LastName;

                if (updateduser.Email != user.Email && updateduser.Email != null)
                    user.Email = updateduser.Email;

                if (UserManager.Update(user))
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
            ViewModels.ChangePasswordViewModel vm = new ViewModels.ChangePasswordViewModel();
            ViewBag.Title = "Change Password";
            return View(vm);
        }

        [HttpPost]
        public ActionResult ChangePassword(ViewModels.ChangePasswordViewModel vm)
        {
            try
            {
                //ViewModels.ChangePasswordViewModel oldnewpasswords =  new ViewModels.ChangePasswordViewModel();

                if (vm.newpass1 == vm.newpass2)
                {
                    if (vm.newpass1 != null || vm.newpass2 != null)
                    {
                        
                        var oldpass = vm.password;
                        var newpass = vm.newpass2;
                        var user = Session["user"] as User;

                        if (oldpass == user.UserPass)
                        {
                            user.UserPass = newpass;

                            if (UserManager.Update(user))
                            {
                                Session["user"] = user;
                                return RedirectToAction("Index");
                            }
                            else
                            {
                                ViewBag.Message = "Something went wrong";
                                return View();
                            }

                        }
                        else
                        {
                            ViewBag.Message = "Password does not match our records";
                            return View();
                        }
                    }
                    else
                    {
                        ViewBag.Message = "You must enter a value for all fields";
                        return View();
                    }
                    
                }
                else
                {
                    ViewBag.Message = "New password and Confirm password do not match";
                    return View();

                }
                
            }
            catch (Exception ex)
            {

                ViewBag.Message = ex.Message;
                return View();
            }


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