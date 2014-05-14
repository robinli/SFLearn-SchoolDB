using SchoolEF6.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace WebApplication1.Controllers
{
    public class StandardsController : Controller
    {
        private SchoolDBEntities db = new SchoolDBEntities();

        // GET: Standards
        public ActionResult Index()
        {
            return View(db.Standard.ToList());
        }

        // GET: Standards/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Standard standard = db.Standard.Find(id);
            if (standard == null)
            {
                return HttpNotFound();
            }
            return View(standard);
        }

        // GET: Standards/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Standards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StandardId,StandardName,Description")] Standard standard)
        {
            if (ModelState.IsValid)
            {
                db.Standard.Add(standard);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(standard);
        }

        // GET: Standards/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Standard standard = db.Standard.Find(id);
            if (standard == null)
            {
                return HttpNotFound();
            }
            return View(standard);
        }

        // POST: Standards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StandardId,StandardName,Description")] Standard standard)
        {
            if (ModelState.IsValid)
            {
                db.Entry(standard).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(standard);
        }

        // GET: Standards/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Standard standard = db.Standard.Find(id);
            if (standard == null)
            {
                return HttpNotFound();
            }
            return View(standard);
        }

        // POST: Standards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Standard standard = db.Standard.Find(id);
            db.Standard.Remove(standard);
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
