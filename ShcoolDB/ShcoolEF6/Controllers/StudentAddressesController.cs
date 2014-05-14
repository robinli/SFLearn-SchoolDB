using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1;

namespace WebApplication1.Controllers
{
    public class StudentAddressesController : Controller
    {
        private SchoolDBEntities db = new SchoolDBEntities();

        // GET: StudentAddresses
        public ActionResult Index()
        {
            var studentAddress = db.StudentAddress.Include(s => s.Student);
            return View(studentAddress.ToList());
        }

        // GET: StudentAddresses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAddress studentAddress = db.StudentAddress.Find(id);
            if (studentAddress == null)
            {
                return HttpNotFound();
            }
            return View(studentAddress);
        }

        // GET: StudentAddresses/Create
        public ActionResult Create()
        {
            ViewBag.StudentID = new SelectList(db.Student, "StudentID", "StudentName");
            return View();
        }

        // POST: StudentAddresses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentID,Address1,Address2,City,State")] StudentAddress studentAddress)
        {
            if (ModelState.IsValid)
            {
                db.StudentAddress.Add(studentAddress);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentID = new SelectList(db.Student, "StudentID", "StudentName", studentAddress.StudentID);
            return View(studentAddress);
        }

        // GET: StudentAddresses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAddress studentAddress = db.StudentAddress.Find(id);
            if (studentAddress == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentID = new SelectList(db.Student, "StudentID", "StudentName", studentAddress.StudentID);
            return View(studentAddress);
        }

        // POST: StudentAddresses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentID,Address1,Address2,City,State")] StudentAddress studentAddress)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentAddress).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StudentID = new SelectList(db.Student, "StudentID", "StudentName", studentAddress.StudentID);
            return View(studentAddress);
        }

        // GET: StudentAddresses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAddress studentAddress = db.StudentAddress.Find(id);
            if (studentAddress == null)
            {
                return HttpNotFound();
            }
            return View(studentAddress);
        }

        // POST: StudentAddresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentAddress studentAddress = db.StudentAddress.Find(id);
            db.StudentAddress.Remove(studentAddress);
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
