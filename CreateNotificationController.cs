using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CDExcellent.Models;

namespace CDExcellent.Areas.Admin.Controllers
{
    public class CreateNotificationController : Controller
    {
        private CDExcellentDBContext db = new CDExcellentDBContext();

        // GET: Admin/CreateNotification
        public ActionResult Index()
        {
            return View(db.CreateNotifications.ToList());
        }

        public ActionResult TableList ()
        {
            return View();
        }

        // GET: Admin/CreateNotification/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateNotification createNotification = db.CreateNotifications.Find(id);
            if (createNotification == null)
            {
                return HttpNotFound();
            }
            return View(createNotification);
        }

        // GET: Admin/CreateNotification/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CreateNotification/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Staff,Note")] CreateNotification createNotification)
        {
            if (ModelState.IsValid)
            {
                db.CreateNotifications.Add(createNotification);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(createNotification);
        }

        // GET: Admin/CreateNotification/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateNotification createNotification = db.CreateNotifications.Find(id);
            if (createNotification == null)
            {
                return HttpNotFound();
            }
            return View(createNotification);
        }

        // POST: Admin/CreateNotification/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Staff,Note")] CreateNotification createNotification)
        {
            if (ModelState.IsValid)
            {
                db.Entry(createNotification).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(createNotification);
        }

        // GET: Admin/CreateNotification/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateNotification createNotification = db.CreateNotifications.Find(id);
            if (createNotification == null)
            {
                return HttpNotFound();
            }
            return View(createNotification);
        }

        // POST: Admin/CreateNotification/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CreateNotification createNotification = db.CreateNotifications.Find(id);
            db.CreateNotifications.Remove(createNotification);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
