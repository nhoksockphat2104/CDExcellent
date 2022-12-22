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
    public class AddNewUserController : Controller
    {
        private CDExcellentDBContext db = new CDExcellentDBContext();

        public ActionResult Import()
        {
            return View();
        }
        
        // GET: Admin/AddNewUser
        public ActionResult Index()
        {
            return View(db.AddNewUsers.ToList());
        }

        

        // GET: Admin/AddNewUser/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddNewUser addNewUser = db.AddNewUsers.Find(id);
            if (addNewUser == null)
            {
                return HttpNotFound();
            }
            return View(addNewUser);
        }

        // GET: Admin/AddNewUser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AddNewUser/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FullName,Email,Title,Area,ReportTo,Status")] AddNewUser addNewUser)
        {
            if (ModelState.IsValid)
            {
                db.AddNewUsers.Add(addNewUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(addNewUser);
        }

        // GET: Admin/AddNewUser/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddNewUser addNewUser = db.AddNewUsers.Find(id);
            if (addNewUser == null)
            {
                return HttpNotFound();
            }
            return View(addNewUser);
        }

        // POST: Admin/AddNewUser/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FullName,Email,Title,Area,ReportTo,Status")] AddNewUser addNewUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addNewUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(addNewUser);
        }

        // GET: Admin/AddNewUser/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddNewUser addNewUser = db.AddNewUsers.Find(id);
            if (addNewUser == null)
            {
                return HttpNotFound();
            }
            return View(addNewUser);
        }

        // POST: Admin/AddNewUser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            AddNewUser addNewUser = db.AddNewUsers.Find(id);
            db.AddNewUsers.Remove(addNewUser);
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
