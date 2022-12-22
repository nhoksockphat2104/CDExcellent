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
    public class CreatePlanVisitController : Controller
    {
        private CDExcellentDBContext db = new CDExcellentDBContext();

        // GET: Admin/CreatePlanVisit
        public ActionResult Index()
        {
            return View(db.CreatePlanVisits.ToList());
        }

        // GET: Admin/CreatePlanVisit/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreatePlanVisit createPlanVisit = db.CreatePlanVisits.Find(id);
            if (createPlanVisit == null)
            {
                return HttpNotFound();
            }
            return View(createPlanVisit);
        }

        // GET: Admin/CreatePlanVisit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CreatePlanVisit/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlanId,Time,Distributor,Purpose,Guest")] CreatePlanVisit createPlanVisit)
        {
            if (ModelState.IsValid)
            {
                db.CreatePlanVisits.Add(createPlanVisit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(createPlanVisit);
        }

        // GET: Admin/CreatePlanVisit/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreatePlanVisit createPlanVisit = db.CreatePlanVisits.Find(id);
            if (createPlanVisit == null)
            {
                return HttpNotFound();
            }
            return View(createPlanVisit);
        }

        // POST: Admin/CreatePlanVisit/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlanId,Time,Distributor,Purpose,Guest")] CreatePlanVisit createPlanVisit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(createPlanVisit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(createPlanVisit);
        }

        // GET: Admin/CreatePlanVisit/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreatePlanVisit createPlanVisit = db.CreatePlanVisits.Find(id);
            if (createPlanVisit == null)
            {
                return HttpNotFound();
            }
            return View(createPlanVisit);
        }

        // POST: Admin/CreatePlanVisit/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CreatePlanVisit createPlanVisit = db.CreatePlanVisits.Find(id);
            db.CreatePlanVisits.Remove(createPlanVisit);
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
