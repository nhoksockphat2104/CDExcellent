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
    public class AddQuestionnaireController : Controller
    {
        private CDExcellentDBContext db = new CDExcellentDBContext();

        // GET: Admin/AddQuestionnaire
        public ActionResult Index()
        {
            return View(db.AddQuestionnaires.ToList());
        }

        // GET: Admin/AddQuestionnaire/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddQuestionnaire addQuestionnaire = db.AddQuestionnaires.Find(id);
            if (addQuestionnaire == null)
            {
                return HttpNotFound();
            }
            return View(addQuestionnaire);
        }

        // GET: Admin/AddQuestionnaire/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AddQuestionnaire/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Status")] AddQuestionnaire addQuestionnaire)
        {
            if (ModelState.IsValid)
            {
                db.AddQuestionnaires.Add(addQuestionnaire);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(addQuestionnaire);
        }

        // GET: Admin/AddQuestionnaire/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddQuestionnaire addQuestionnaire = db.AddQuestionnaires.Find(id);
            if (addQuestionnaire == null)
            {
                return HttpNotFound();
            }
            return View(addQuestionnaire);
        }

        // POST: Admin/AddQuestionnaire/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Status")] AddQuestionnaire addQuestionnaire)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addQuestionnaire).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(addQuestionnaire);
        }

        // GET: Admin/AddQuestionnaire/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddQuestionnaire addQuestionnaire = db.AddQuestionnaires.Find(id);
            if (addQuestionnaire == null)
            {
                return HttpNotFound();
            }
            return View(addQuestionnaire);
        }

        // POST: Admin/AddQuestionnaire/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AddQuestionnaire addQuestionnaire = db.AddQuestionnaires.Find(id);
            db.AddQuestionnaires.Remove(addQuestionnaire);
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
