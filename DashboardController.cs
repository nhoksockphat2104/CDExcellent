using CDExcellent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CDExcellent.Controllers
{
    public class DashboardController : Controller
    {
        private CDExcellentDBContext db = new CDExcellentDBContext();
        // GET: Dashboard
        public ActionResult Index()
        {
            ViewBag.SoMauTin = db.CreatePlanVisits.Count();
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(int a)
        {
            return View("Index");
        }

        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(int b)
        {
            return View();
        }

        public ActionResult ForgetPass()
        {
            return View();
        }
    }
}