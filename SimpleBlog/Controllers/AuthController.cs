using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlog.ViewModels;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {


            if (!ModelState.IsValid)           
                return View(form);

            if(form.Username != "beren" || form.Password != "myPass")
            {
                ModelState.AddModelError("Username", "Username or Password isn't Valid");
                return View(form);
            }

            return Content("The form is Valid!");
        }
    }
}