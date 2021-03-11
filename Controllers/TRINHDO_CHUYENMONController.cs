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
    public class TRINHDO_CHUYENMONController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: TRINHDO_CHUYENMON
        public ActionResult Index()
        {
            return View(db.TRINHDO_CHUYENMONs.ToList());
        }

        // GET: TRINHDO_CHUYENMON/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRINHDO_CHUYENMON tRINHDO_CHUYENMON = db.TRINHDO_CHUYENMONs.Find(id);
            if (tRINHDO_CHUYENMON == null)
            {
                return HttpNotFound();
            }
            return View(tRINHDO_CHUYENMON);
        }

        // GET: TRINHDO_CHUYENMON/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TRINHDO_CHUYENMON/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNV,STT,MaTrinhDo,MaCM")] TRINHDO_CHUYENMON tRINHDO_CHUYENMON)
        {
            if (ModelState.IsValid)
            {
                db.TRINHDO_CHUYENMONs.Add(tRINHDO_CHUYENMON);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tRINHDO_CHUYENMON);
        }

        // GET: TRINHDO_CHUYENMON/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRINHDO_CHUYENMON tRINHDO_CHUYENMON = db.TRINHDO_CHUYENMONs.Find(id);
            if (tRINHDO_CHUYENMON == null)
            {
                return HttpNotFound();
            }
            return View(tRINHDO_CHUYENMON);
        }

        // POST: TRINHDO_CHUYENMON/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNV,STT,MaTrinhDo,MaCM")] TRINHDO_CHUYENMON tRINHDO_CHUYENMON)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRINHDO_CHUYENMON).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tRINHDO_CHUYENMON);
        }

        // GET: TRINHDO_CHUYENMON/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRINHDO_CHUYENMON tRINHDO_CHUYENMON = db.TRINHDO_CHUYENMONs.Find(id);
            if (tRINHDO_CHUYENMON == null)
            {
                return HttpNotFound();
            }
            return View(tRINHDO_CHUYENMON);
        }

        // POST: TRINHDO_CHUYENMON/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TRINHDO_CHUYENMON tRINHDO_CHUYENMON = db.TRINHDO_CHUYENMONs.Find(id);
            db.TRINHDO_CHUYENMONs.Remove(tRINHDO_CHUYENMON);
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
