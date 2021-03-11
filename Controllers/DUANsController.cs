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
    public class DUANsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: DUANs
        public ActionResult Index()
        {
            var dUANs = db.DUANs.Include(d => d.CHITIETDUANs);
            return View(dUANs.ToList());
        }

        // GET: DUANs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DUAN dUAN = db.DUANs.Find(id);
            if (dUAN == null)
            {
                return HttpNotFound();
            }
            return View(dUAN);
        }

        // GET: DUANs/Create
        public ActionResult Create()
        {
            ViewBag.MaDuAn = new SelectList(db.CHITIETDUANs, "MaDuAn", "TenDuAn");
            return View();
        }

        // POST: DUANs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TenDuAn,MaDuAn,MaNV")] DUAN dUAN)
        {
            if (ModelState.IsValid)
            {
                db.DUANs.Add(dUAN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaDuAn = new SelectList(db.CHITIETDUANs, "MaDuAn", "TenDuAn", dUAN.MaDuAn);
            return View(dUAN);
        }

        // GET: DUANs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DUAN dUAN = db.DUANs.Find(id);
            if (dUAN == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDuAn = new SelectList(db.CHITIETDUANs, "MaDuAn", "TenDuAn", dUAN.MaDuAn);
            return View(dUAN);
        }

        // POST: DUANs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TenDuAn,MaDuAn,MaNV")] DUAN dUAN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dUAN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaDuAn = new SelectList(db.CHITIETDUANs, "MaDuAn", "TenDuAn", dUAN.MaDuAn);
            return View(dUAN);
        }

        // GET: DUANs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DUAN dUAN = db.DUANs.Find(id);
            if (dUAN == null)
            {
                return HttpNotFound();
            }
            return View(dUAN);
        }

        // POST: DUANs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DUAN dUAN = db.DUANs.Find(id);
            db.DUANs.Remove(dUAN);
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
