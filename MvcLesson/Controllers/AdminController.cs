using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcLesson.Models;

namespace MvcLesson.Controllers
{
    public class AdminController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(model.AdminName, false);

                return RedirectToAction("Panel");
            }
            return View();
        }

        public ViewResult Panel()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Registration()
        {
            return View();
        }

        [HttpPost]
        public string Registration(RegistrationViewModel admin)
        {
            if (ModelState.IsValid)
            {
                return "Новый администратор успешно зарегистрирован!";
            }
            return "Регистрация прошла с ошибкой. Администратор не зарегистрирован!";
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}