using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLesson.Models;

namespace MvcLesson.Controllers
{
    public class HomeController : Controller
    {
     public ViewResult Index()
        {
            return View();
        }

        public ViewResult Admin()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RegisterAdmin()
        {
            return View();
        }

        [HttpPost]
        public string RegisterAdmin(Admin admin)
        {
            if (ModelState.IsValid)
            {
                return "Новый администратор успешно зарегистрирован!";
            }
            return "Регистрация прошла с ошибкой. Администратор не зарегистрирован!";
        }

        [HttpGet]
        public ViewResult HelpDeskForm()
        {
            ViewBag.ID = Guid.NewGuid();
            return View();
        }

        [HttpPost]
        public ViewResult HelpDeskForm(HelpDeskRequest helpDesk)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", helpDesk);
            }
            else
            {
                return View();
            }
            
        }
    }
}