using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CDExcellent.Areas.Admin.Controllers
{
    public class DashboardAdminController : Controller
    {
        // GET: Admin/DashboardAdmin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyAccount()
        {
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

        public ActionResult Forget()
        {
            return View();
        }
    }
}