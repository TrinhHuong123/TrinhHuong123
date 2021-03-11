using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _1721050522_Trinh_Thu_Huong_BTL_LTQL.Models;

namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Controllers
{
    public class CHUYENMONsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: CHUYENMONs
        public ActionResult Index()
        {
            return View(db.CHUYENMONs.ToList());
        }

        // GET: CHUYENMONs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHUYENMON cHUYENMON = db.CHUYENMONs.Find(id);
            if (cHUYENMON == null)
            {
                return HttpNotFound();
            }
            return View(cHUYENMON);
        }

        // GET: CHUYENMONs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CHUYENMONs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TenCM,MaCM")] CHUYENMON cHUYENMON)
        {
            if (ModelState.IsValid)
            {
                db.CHUYENMONs.Add(cHUYENMON);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cHUYENMON);
        }

        // GET: CHUYENMONs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHUYENMON cHUYENMON = db.CHUYENMONs.Find(id);
            if (cHUYENMON == null)
            {
                return HttpNotFound();
            }
            return View(cHUYENMON);
        }

        // POST: CHUYENMONs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TenCM,MaCM")] CHUYENMON cHUYENMON)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cHUYENMON).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cHUYENMON);
        }

        // GET: CHUYENMONs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHUYENMON cHUYENMON = db.CHUYENMONs.Find(id);
            if (cHUYENMON == null)
            {
                return HttpNotFound();
            }
            return View(cHUYENMON);
        }

        // POST: CHUYENMONs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CHUYENMON cHUYENMON = db.CHUYENMONs.Find(id);
            db.CHUYENMONs.Remove(cHUYENMON);
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
