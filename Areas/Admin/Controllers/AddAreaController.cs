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
    public class AddAreaController : Controller
    {
        private CDExcellentDBContext db = new CDExcellentDBContext();

        // GET: Admin/AddArea
        public ActionResult Index()
        {
            return View(db.AddAreas.ToList());
        }

        public ActionResult Import()
        {
            return View(db.AddNewUsers.ToList());
        }

        // GET: Admin/AddArea/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddArea addArea = db.AddAreas.Find(id);
            if (addArea == null)
            {
                return HttpNotFound();
            }
            return View(addArea);
        }

        // GET: Admin/AddArea/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AddArea/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AreaId,AreaCode,AreaName,DistributorQty")] AddArea addArea)
        {
            if (ModelState.IsValid)
            {
                db.AddAreas.Add(addArea);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(addArea);
        }

        // GET: Admin/AddArea/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddArea addArea = db.AddAreas.Find(id);
            if (addArea == null)
            {
                return HttpNotFound();
            }
            return View(addArea);
        }

        // POST: Admin/AddArea/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AreaId,AreaCode,AreaName,DistributorQty")] AddArea addArea)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addArea).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(addArea);
        }

        // GET: Admin/AddArea/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddArea addArea = db.AddAreas.Find(id);
            if (addArea == null)
            {
                return HttpNotFound();
            }
            return View(addArea);
        }

        // POST: Admin/AddArea/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AddArea addArea = db.AddAreas.Find(id);
            db.AddAreas.Remove(addArea);
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
