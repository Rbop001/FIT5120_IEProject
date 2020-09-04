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
    public class ChineseRestaurantsController : Controller
    {
        private PointsOfInterestEntities db = new PointsOfInterestEntities();

        // GET: ChineseRestaurants
        public ActionResult Index()
        {
            return View(db.ChineseRestaurants.ToList());
        }

        // GET: ChineseRestaurants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChineseRestaurant chineseRestaurant = db.ChineseRestaurants.Find(id);
            if (chineseRestaurant == null)
            {
                return HttpNotFound();
            }
            return View(chineseRestaurant);
        }

        // GET: ChineseRestaurants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChineseRestaurants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Year,Block,Prop_Id,Bp_Id,St_Address,Small_Area,Restaurant_name,Ind_code_,Ind_desc,Seating_Category,Total_Seats__,x_coord,y_coord,Location")] ChineseRestaurant chineseRestaurant)
        {
            if (ModelState.IsValid)
            {
                db.ChineseRestaurants.Add(chineseRestaurant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chineseRestaurant);
        }

        // GET: ChineseRestaurants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChineseRestaurant chineseRestaurant = db.ChineseRestaurants.Find(id);
            if (chineseRestaurant == null)
            {
                return HttpNotFound();
            }
            return View(chineseRestaurant);
        }

        // POST: ChineseRestaurants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Year,Block,Prop_Id,Bp_Id,St_Address,Small_Area,Restaurant_name,Ind_code_,Ind_desc,Seating_Category,Total_Seats__,x_coord,y_coord,Location")] ChineseRestaurant chineseRestaurant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chineseRestaurant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chineseRestaurant);
        }

        // GET: ChineseRestaurants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChineseRestaurant chineseRestaurant = db.ChineseRestaurants.Find(id);
            if (chineseRestaurant == null)
            {
                return HttpNotFound();
            }
            return View(chineseRestaurant);
        }

        // POST: ChineseRestaurants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChineseRestaurant chineseRestaurant = db.ChineseRestaurants.Find(id);
            db.ChineseRestaurants.Remove(chineseRestaurant);
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
