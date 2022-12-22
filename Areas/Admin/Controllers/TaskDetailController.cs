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
    public class TaskDetailController : Controller
    {
        private CDExcellentDBContext db = new CDExcellentDBContext();

        // GET: Admin/TaskDetail
        public ActionResult Index()
        {
            return View(db.TaskDetails.ToList());
        }

        // GET: Admin/TaskDetail/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskDetail taskDetail = db.TaskDetails.Find(id);
            if (taskDetail == null)
            {
                return HttpNotFound();
            }
            return View(taskDetail);
        }

        // GET: Admin/TaskDetail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/TaskDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Create_by,Status,Category,Performer,Description")] TaskDetail taskDetail)
        {
            if (ModelState.IsValid)
            {
                db.TaskDetails.Add(taskDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taskDetail);
        }

        // GET: Admin/TaskDetail/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskDetail taskDetail = db.TaskDetails.Find(id);
            if (taskDetail == null)
            {
                return HttpNotFound();
            }
            return View(taskDetail);
        }

        // POST: Admin/TaskDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Create_by,Status,Category,Performer,Description")] TaskDetail taskDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taskDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taskDetail);
        }

        // GET: Admin/TaskDetail/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskDetail taskDetail = db.TaskDetails.Find(id);
            if (taskDetail == null)
            {
                return HttpNotFound();
            }
            return View(taskDetail);
        }

        // POST: Admin/TaskDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TaskDetail taskDetail = db.TaskDetails.Find(id);
            db.TaskDetails.Remove(taskDetail);
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
