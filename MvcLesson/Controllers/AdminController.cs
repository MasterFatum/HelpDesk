using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLesson.Models;

namespace MvcLesson.Controllers
{
    public class AdminController : Controller
    {

        public ViewResult AdminPanel()
        {
            return View();
        }

        [HttpGet]
        public ViewResult AdminRegistration()
        {
            return View();
        }

        [HttpPost]
        public string AdminRegistration(RegistrationAdmin admin)
        {
            if (ModelState.IsValid)
            {
                return "Новый администратор успешно зарегистрирован!";
            }
            return "Регистрация прошла с ошибкой. Администратор не зарегистрирован!";
        }
    }
}