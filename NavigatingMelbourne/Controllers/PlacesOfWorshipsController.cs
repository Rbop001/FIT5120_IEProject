using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NavigatingMelbourne.Models;

namespace NavigatingMelbourne.Controllers
{
    public class PlacesOfWorshipsController : Controller
    {
        private PointsOfInterestEntities db = new PointsOfInterestEntities();

        // GET: PlacesOfWorships
        public ActionResult Index()
        {
            return View(db.PlacesOfWorships.ToList());
        }

        // GET: PlacesOfWorships/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlacesOfWorship placesOfWorship = db.PlacesOfWorships.Find(id);
            if (placesOfWorship == null)
            {
                return HttpNotFound();
            }
            return View(placesOfWorship);
        }

        // GET: PlacesOfWorships/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlacesOfWorships/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Theme,Sub_Theme,Feature_Name,Co_ordinates")] PlacesOfWorship placesOfWorship)
        {
            if (ModelState.IsValid)
            {
                db.PlacesOfWorships.Add(placesOfWorship);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(placesOfWorship);
        }

        // GET: PlacesOfWorships/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlacesOfWorship placesOfWorship = db.PlacesOfWorships.Find(id);
            if (placesOfWorship == null)
            {
                return HttpNotFound();
            }
            return View(placesOfWorship);
        }

        // POST: PlacesOfWorships/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Theme,Sub_Theme,Feature_Name,Co_ordinates")] PlacesOfWorship placesOfWorship)
        {
            if (ModelState.IsValid)
            {
                db.Entry(placesOfWorship).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(placesOfWorship);
        }

        // GET: PlacesOfWorships/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlacesOfWorship placesOfWorship = db.PlacesOfWorships.Find(id);
            if (placesOfWorship == null)
            {
                return HttpNotFound();
            }
            return View(placesOfWorship);
        }

        // POST: PlacesOfWorships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlacesOfWorship placesOfWorship = db.PlacesOfWorships.Find(id);
            db.PlacesOfWorships.Remove(placesOfWorship);
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
