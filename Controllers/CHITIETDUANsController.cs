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
    public class CHITIETDUANsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: CHITIETDUANs
        public ActionResult Index()
        {
            return View(db.CHITIETDUANs.ToList());
        }

        // GET: CHITIETDUANs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHITIETDUAN cHITIETDUAN = db.CHITIETDUANs.Find(id);
            if (cHITIETDUAN == null)
            {
                return HttpNotFound();
            }
            return View(cHITIETDUAN);
        }

        // GET: CHITIETDUANs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CHITIETDUANs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDuAn,TenDuAn,MaNhanVien,Ngaybatdau,Ngaygiahan,Ngayketthuc,SoLuong,DonGia,ChietKhau")] CHITIETDUAN cHITIETDUAN)
        {
            if (ModelState.IsValid)
            {
                db.CHITIETDUANs.Add(cHITIETDUAN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cHITIETDUAN);
        }

        // GET: CHITIETDUANs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHITIETDUAN cHITIETDUAN = db.CHITIETDUANs.Find(id);
            if (cHITIETDUAN == null)
            {
                return HttpNotFound();
            }
            return View(cHITIETDUAN);
        }

        // POST: CHITIETDUANs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDuAn,TenDuAn,MaNhanVien,Ngaybatdau,Ngaygiahan,Ngayketthuc,SoLuong,DonGia,ChietKhau")] CHITIETDUAN cHITIETDUAN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cHITIETDUAN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cHITIETDUAN);
        }

        // GET: CHITIETDUANs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHITIETDUAN cHITIETDUAN = db.CHITIETDUANs.Find(id);
            if (cHITIETDUAN == null)
            {
                return HttpNotFound();
            }
            return View(cHITIETDUAN);
        }

        // POST: CHITIETDUANs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CHITIETDUAN cHITIETDUAN = db.CHITIETDUANs.Find(id);
            db.CHITIETDUANs.Remove(cHITIETDUAN);
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
