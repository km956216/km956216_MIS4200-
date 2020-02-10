using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using km956216_MIS4200.DAL;
using km956216_MIS4200_.Models;

namespace km956216_MIS4200_.Controllers
{
    public class appointmentDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: appointmentDetails
        public ActionResult Index()
        {
            return View(db.appointmentDetails.ToList());
        }

        // GET: appointmentDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            appointmentDetails appointmentDetails = db.appointmentDetails.Find(id);
            if (appointmentDetails == null)
            {
                return HttpNotFound();
            }
            return View(appointmentDetails);
        }

        // GET: appointmentDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: appointmentDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "appointentDetailsID,dateTime,petID,vetID")] appointmentDetails appointmentDetails)
        {
            if (ModelState.IsValid)
            {
                db.appointmentDetails.Add(appointmentDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(appointmentDetails);
        }

        // GET: appointmentDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            appointmentDetails appointmentDetails = db.appointmentDetails.Find(id);
            if (appointmentDetails == null)
            {
                return HttpNotFound();
            }
            return View(appointmentDetails);
        }

        // POST: appointmentDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "appointentDetailsID,dateTime,petID,vetID")] appointmentDetails appointmentDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appointmentDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(appointmentDetails);
        }

        // GET: appointmentDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            appointmentDetails appointmentDetails = db.appointmentDetails.Find(id);
            if (appointmentDetails == null)
            {
                return HttpNotFound();
            }
            return View(appointmentDetails);
        }

        // POST: appointmentDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            appointmentDetails appointmentDetails = db.appointmentDetails.Find(id);
            db.appointmentDetails.Remove(appointmentDetails);
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
