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
    public class CHITIETKHENTHUONG_KYLUATController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: CHITIETKHENTHUONG_KYLUAT
        public ActionResult Index()
        {
            return View(db.CHITIETKHENTHUONG_KYLUATs.ToList());
        }

        // GET: CHITIETKHENTHUONG_KYLUAT/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHITIETKHENTHUONG_KYLUAT cHITIETKHENTHUONG_KYLUAT = db.CHITIETKHENTHUONG_KYLUATs.Find(id);
            if (cHITIETKHENTHUONG_KYLUAT == null)
            {
                return HttpNotFound();
            }
            return View(cHITIETKHENTHUONG_KYLUAT);
        }

        // GET: CHITIETKHENTHUONG_KYLUAT/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CHITIETKHENTHUONG_KYLUAT/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNV,SoQĐ,HinhThuc,NgayHieuLuc,LyDo,SoTien")] CHITIETKHENTHUONG_KYLUAT cHITIETKHENTHUONG_KYLUAT)
        {
            if (ModelState.IsValid)
            {
                db.CHITIETKHENTHUONG_KYLUATs.Add(cHITIETKHENTHUONG_KYLUAT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cHITIETKHENTHUONG_KYLUAT);
        }

        // GET: CHITIETKHENTHUONG_KYLUAT/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHITIETKHENTHUONG_KYLUAT cHITIETKHENTHUONG_KYLUAT = db.CHITIETKHENTHUONG_KYLUATs.Find(id);
            if (cHITIETKHENTHUONG_KYLUAT == null)
            {
                return HttpNotFound();
            }
            return View(cHITIETKHENTHUONG_KYLUAT);
        }

        // POST: CHITIETKHENTHUONG_KYLUAT/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNV,SoQĐ,HinhThuc,NgayHieuLuc,LyDo,SoTien")] CHITIETKHENTHUONG_KYLUAT cHITIETKHENTHUONG_KYLUAT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cHITIETKHENTHUONG_KYLUAT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cHITIETKHENTHUONG_KYLUAT);
        }

        // GET: CHITIETKHENTHUONG_KYLUAT/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHITIETKHENTHUONG_KYLUAT cHITIETKHENTHUONG_KYLUAT = db.CHITIETKHENTHUONG_KYLUATs.Find(id);
            if (cHITIETKHENTHUONG_KYLUAT == null)
            {
                return HttpNotFound();
            }
            return View(cHITIETKHENTHUONG_KYLUAT);
        }

        // POST: CHITIETKHENTHUONG_KYLUAT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CHITIETKHENTHUONG_KYLUAT cHITIETKHENTHUONG_KYLUAT = db.CHITIETKHENTHUONG_KYLUATs.Find(id);
            db.CHITIETKHENTHUONG_KYLUATs.Remove(cHITIETKHENTHUONG_KYLUAT);
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
