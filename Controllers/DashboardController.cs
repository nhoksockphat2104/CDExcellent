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
    }
}