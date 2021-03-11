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
    public class TRINHDO_NGOAINGUController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: TRINHDO_NGOAINGU
        public ActionResult Index()
        {
            return View(db.TRINHDO_NGOAINGUs.ToList());
        }

        // GET: TRINHDO_NGOAINGU/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRINHDO_NGOAINGU tRINHDO_NGOAINGU = db.TRINHDO_NGOAINGUs.Find(id);
            if (tRINHDO_NGOAINGU == null)
            {
                return HttpNotFound();
            }
            return View(tRINHDO_NGOAINGU);
        }

        // GET: TRINHDO_NGOAINGU/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TRINHDO_NGOAINGU/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTrinhDo,MaTrinhDoNN,TenTrinhDo")] TRINHDO_NGOAINGU tRINHDO_NGOAINGU)
        {
            if (ModelState.IsValid)
            {
                db.TRINHDO_NGOAINGUs.Add(tRINHDO_NGOAINGU);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tRINHDO_NGOAINGU);
        }

        // GET: TRINHDO_NGOAINGU/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRINHDO_NGOAINGU tRINHDO_NGOAINGU = db.TRINHDO_NGOAINGUs.Find(id);
            if (tRINHDO_NGOAINGU == null)
            {
                return HttpNotFound();
            }
            return View(tRINHDO_NGOAINGU);
        }

        // POST: TRINHDO_NGOAINGU/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTrinhDo,MaTrinhDoNN,TenTrinhDo")] TRINHDO_NGOAINGU tRINHDO_NGOAINGU)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRINHDO_NGOAINGU).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tRINHDO_NGOAINGU);
        }

        // GET: TRINHDO_NGOAINGU/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRINHDO_NGOAINGU tRINHDO_NGOAINGU = db.TRINHDO_NGOAINGUs.Find(id);
            if (tRINHDO_NGOAINGU == null)
            {
                return HttpNotFound();
            }
            return View(tRINHDO_NGOAINGU);
        }

        // POST: TRINHDO_NGOAINGU/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TRINHDO_NGOAINGU tRINHDO_NGOAINGU = db.TRINHDO_NGOAINGUs.Find(id);
            db.TRINHDO_NGOAINGUs.Remove(tRINHDO_NGOAINGU);
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
