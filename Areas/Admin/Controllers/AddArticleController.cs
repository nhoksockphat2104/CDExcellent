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
    public class AddArticleController : Controller
    {
        private CDExcellentDBContext db = new CDExcellentDBContext();

        // GET: Admin/AddArticle
        public ActionResult Index()
        {
            return View(db.AddArticles.ToList());
        }

        public ActionResult Post()
        {
            return View();
        }

        // GET: Admin/AddArticle/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddArticle addArticle = db.AddArticles.Find(id);
            if (addArticle == null)
            {
                return HttpNotFound();
            }
            return View(addArticle);
        }

        // GET: Admin/AddArticle/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AddArticle/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Creator,DateCreate,Title,Status")] AddArticle addArticle)
        {
            if (ModelState.IsValid)
            {
                db.AddArticles.Add(addArticle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(addArticle);
        }

        // GET: Admin/AddArticle/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddArticle addArticle = db.AddArticles.Find(id);
            if (addArticle == null)
            {
                return HttpNotFound();
            }
            return View(addArticle);
        }

        // POST: Admin/AddArticle/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Creator,DateCreate,Title,Status")] AddArticle addArticle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addArticle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(addArticle);
        }

        // GET: Admin/AddArticle/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddArticle addArticle = db.AddArticles.Find(id);
            if (addArticle == null)
            {
                return HttpNotFound();
            }
            return View(addArticle);
        }

        // POST: Admin/AddArticle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AddArticle addArticle = db.AddArticles.Find(id);
            db.AddArticles.Remove(addArticle);
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
