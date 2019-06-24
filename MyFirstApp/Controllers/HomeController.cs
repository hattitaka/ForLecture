using MyFirstApp.Areas.Admin.Controllers;
using MyFirstApp.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult List()
        {
            var res = userData.GetUserSummaries();

            if (res.HasError)
            {
                ViewData["errorMessage"] = res.ErrorMessage;
                return View();
            }

            return View(res);
        }
    }
}