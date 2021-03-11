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
    public class TRINHDOsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: TRINHDOs
        public ActionResult Index()
        {
            return View(db.TRINHDOs.ToList());
        }

        // GET: TRINHDOs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRINHDO tRINHDO = db.TRINHDOs.Find(id);
            if (tRINHDO == null)
            {
                return HttpNotFound();
            }
            return View(tRINHDO);
        }

        // GET: TRINHDOs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TRINHDOs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TenTrinhDo,MaTrinhDo")] TRINHDO tRINHDO)
        {
            if (ModelState.IsValid)
            {
                db.TRINHDOs.Add(tRINHDO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tRINHDO);
        }

        // GET: TRINHDOs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRINHDO tRINHDO = db.TRINHDOs.Find(id);
            if (tRINHDO == null)
            {
                return HttpNotFound();
            }
            return View(tRINHDO);
        }

        // POST: TRINHDOs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TenTrinhDo,MaTrinhDo")] TRINHDO tRINHDO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRINHDO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tRINHDO);
        }

        // GET: TRINHDOs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRINHDO tRINHDO = db.TRINHDOs.Find(id);
            if (tRINHDO == null)
            {
                return HttpNotFound();
            }
            return View(tRINHDO);
        }

        // POST: TRINHDOs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TRINHDO tRINHDO = db.TRINHDOs.Find(id);
            db.TRINHDOs.Remove(tRINHDO);
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
