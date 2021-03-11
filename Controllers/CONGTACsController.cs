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
    public class CONGTACsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: CONGTACs
        public ActionResult Index()
        {
            return View(db.CONGTACs.ToList());
        }

        // GET: CONGTACs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONGTAC cONGTAC = db.CONGTACs.Find(id);
            if (cONGTAC == null)
            {
                return HttpNotFound();
            }
            return View(cONGTAC);
        }

        // GET: CONGTACs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CONGTACs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNV,MaCT,CongViec,ChucVu,PhongBan,NoiLamViec")] CONGTAC cONGTAC)
        {
            if (ModelState.IsValid)
            {
                db.CONGTACs.Add(cONGTAC);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cONGTAC);
        }

        // GET: CONGTACs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONGTAC cONGTAC = db.CONGTACs.Find(id);
            if (cONGTAC == null)
            {
                return HttpNotFound();
            }
            return View(cONGTAC);
        }

        // POST: CONGTACs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNV,MaCT,CongViec,ChucVu,PhongBan,NoiLamViec")] CONGTAC cONGTAC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cONGTAC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cONGTAC);
        }

        // GET: CONGTACs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONGTAC cONGTAC = db.CONGTACs.Find(id);
            if (cONGTAC == null)
            {
                return HttpNotFound();
            }
            return View(cONGTAC);
        }

        // POST: CONGTACs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CONGTAC cONGTAC = db.CONGTACs.Find(id);
            db.CONGTACs.Remove(cONGTAC);
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
