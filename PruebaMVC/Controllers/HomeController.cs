using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult prueba(string name ="" , int numTimes = 1)
        {
            ViewData["Nombre"] = name;
            ViewData["NumVeces"] = numTimes;
            ViewBag.Message = "Hola " + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
    }
}