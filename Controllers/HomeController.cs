using Net1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Net1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.WelComeString = "Chao mung ban den voi ViewBag";
            var mes = new MessageModel();
            mes.Welcome = "Chao mung den boi Model";
            return View(mes);
        }
    }
}