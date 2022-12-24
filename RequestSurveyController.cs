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
    public class RequestSurveyController : Controller
    {
        private CDExcellentDBContext db = new CDExcellentDBContext();

        // GET: Admin/RequestSurvey
        public ActionResult Index()
        {
            return View(db.RequestSurveys.ToList());
        }

        public ActionResult SurveyList()
        {
            return View();
        }

        public ActionResult RequestTable()
        {
            return View();
        }

        public ActionResult DetailsSurvey()
        {
            return View();
        }

        // GET: Admin/RequestSurvey/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RequestSurvey requestSurvey = db.RequestSurveys.Find(id);
            if (requestSurvey == null)
            {
                return HttpNotFound();
            }
            return View(requestSurvey);
        }

        // GET: Admin/RequestSurvey/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/RequestSurvey/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SurveyId,SurveyName,SurveyQuestion,StartDate,EndDate,Get_by,Email")] RequestSurvey requestSurvey)
        {
            if (ModelState.IsValid)
            {
                db.RequestSurveys.Add(requestSurvey);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(requestSurvey);
        }

        // GET: Admin/RequestSurvey/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RequestSurvey requestSurvey = db.RequestSurveys.Find(id);
            if (requestSurvey == null)
            {
                return HttpNotFound();
            }
            return View(requestSurvey);
        }

        // POST: Admin/RequestSurvey/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SurveyId,SurveyName,SurveyQuestion,StartDate,EndDate,Get_by,Email")] RequestSurvey requestSurvey)
        {
            if (ModelState.IsValid)
            {
                db.Entry(requestSurvey).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(requestSurvey);
        }

        // GET: Admin/RequestSurvey/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RequestSurvey requestSurvey = db.RequestSurveys.Find(id);
            if (requestSurvey == null)
            {
                return HttpNotFound();
            }
            return View(requestSurvey);
        }

        // POST: Admin/RequestSurvey/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RequestSurvey requestSurvey = db.RequestSurveys.Find(id);
            db.RequestSurveys.Remove(requestSurvey);
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
