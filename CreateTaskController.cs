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
    public class CreateTaskController : Controller
    {
        private CDExcellentDBContext db = new CDExcellentDBContext();

        // GET: Admin/CreateTask
        public ActionResult Index()
        {
            return View(db.CreateTasks.ToList());
        }

        public ActionResult History()
        {
            return View();
        }

        public ActionResult VisitPlanDetails()
        {
            return View();
        }

        // GET: Admin/CreateTask/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateTask createTask = db.CreateTasks.Find(id);
            if (createTask == null)
            {
                return HttpNotFound();
            }
            return View(createTask);
        }

        // GET: Admin/CreateTask/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CreateTask/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Create_by,Description,ChooseCalendar,StartDate,EndDate")] CreateTask createTask)
        {
            if (ModelState.IsValid)
            {
                db.CreateTasks.Add(createTask);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(createTask);
        }

        // GET: Admin/CreateTask/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateTask createTask = db.CreateTasks.Find(id);
            if (createTask == null)
            {
                return HttpNotFound();
            }
            return View(createTask);
        }

        // POST: Admin/CreateTask/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Create_by,Description,ChooseCalendar,StartDate,EndDate")] CreateTask createTask)
        {
            if (ModelState.IsValid)
            {
                db.Entry(createTask).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(createTask);
        }

        // GET: Admin/CreateTask/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateTask createTask = db.CreateTasks.Find(id);
            if (createTask == null)
            {
                return HttpNotFound();
            }
            return View(createTask);
        }

        // POST: Admin/CreateTask/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CreateTask createTask = db.CreateTasks.Find(id);
            db.CreateTasks.Remove(createTask);
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
