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
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро!" : "Добрый день!";
            return View();
        }

        public ViewResult Admin()
        {
            return View();
        }

        [HttpGet]
        public ViewResult HelpDeskForm()
        {
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