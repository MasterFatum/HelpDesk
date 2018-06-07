using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcLesson.Models;

namespace MvcLesson.Controllers
{
    public class HomeController : Controller
    {
     public ViewResult Index()
        {
            return View();
        }

        
        public ActionResult RedirectToLoginPage()
        {
            return Redirect("/Admin/Login");
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