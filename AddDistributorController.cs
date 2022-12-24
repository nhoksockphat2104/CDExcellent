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
    public class AddDistributorController : Controller
    {
        private CDExcellentDBContext db = new CDExcellentDBContext();

        // GET: Admin/AddDistributor
        public ActionResult Index()
        {
            return View(db.AddDistributors.ToList());
        }

        // GET: Admin/AddDistributor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddDistributor addDistributor = db.AddDistributors.Find(id);
            if (addDistributor == null)
            {
                return HttpNotFound();
            }
            return View(addDistributor);
        }

        // GET: Admin/AddDistributor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AddDistributor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Address,Email,Phone")] AddDistributor addDistributor)
        {
            if (ModelState.IsValid)
            {
                db.AddDistributors.Add(addDistributor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(addDistributor);
        }

        // GET: Admin/AddDistributor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddDistributor addDistributor = db.AddDistributors.Find(id);
            if (addDistributor == null)
            {
                return HttpNotFound();
            }
            return View(addDistributor);
        }

        // POST: Admin/AddDistributor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Address,Email,Phone")] AddDistributor addDistributor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addDistributor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(addDistributor);
        }

        // GET: Admin/AddDistributor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddDistributor addDistributor = db.AddDistributors.Find(id);
            if (addDistributor == null)
            {
                return HttpNotFound();
            }
            return View(addDistributor);
        }

        // POST: Admin/AddDistributor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AddDistributor addDistributor = db.AddDistributors.Find(id);
            db.AddDistributors.Remove(addDistributor);
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
