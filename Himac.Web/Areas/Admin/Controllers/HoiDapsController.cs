using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Himac.Data;
using Himac.Model.Models;

namespace Himac.Web.Areas.Admin.Controllers
{
    public class HoiDapsController : Controller
    {
        private HimacDbContext db = new HimacDbContext();

        // GET: Admin/HoiDaps
        public ActionResult Index()
        {
            var hoiDaps = db.HoiDaps.Include(h => h.LoaiHoiDap);
            return View(hoiDaps.ToList());
        }

        // GET: Admin/HoiDaps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoiDap hoiDap = db.HoiDaps.Find(id);
            if (hoiDap == null)
            {
                return HttpNotFound();
            }
            return View(hoiDap);
        }

        // GET: Admin/HoiDaps/Create
        public ActionResult Create()
        {
            ViewBag.LoaiHoiDapId = new SelectList(db.LoaiHoiDaps, "LoaiHoiDapId", "TenLoaiHoiDap");
            return View();
        }

        // POST: Admin/HoiDaps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HoiDapId,CauHoi,Content,ImagePath,FilePath,LoaiHoiDapId,OrderHint,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,MetaKeyword,MetaDescription,Status")] HoiDap hoiDap)
        {
            if (ModelState.IsValid)
            {
                db.HoiDaps.Add(hoiDap);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LoaiHoiDapId = new SelectList(db.LoaiHoiDaps, "LoaiHoiDapId", "TenLoaiHoiDap", hoiDap.LoaiHoiDapId);
            return View(hoiDap);
        }

        // GET: Admin/HoiDaps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoiDap hoiDap = db.HoiDaps.Find(id);
            if (hoiDap == null)
            {
                return HttpNotFound();
            }
            ViewBag.LoaiHoiDapId = new SelectList(db.LoaiHoiDaps, "LoaiHoiDapId", "TenLoaiHoiDap", hoiDap.LoaiHoiDapId);
            return View(hoiDap);
        }

        // POST: Admin/HoiDaps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HoiDapId,CauHoi,Content,ImagePath,FilePath,LoaiHoiDapId,OrderHint,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,MetaKeyword,MetaDescription,Status")] HoiDap hoiDap)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hoiDap).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LoaiHoiDapId = new SelectList(db.LoaiHoiDaps, "LoaiHoiDapId", "TenLoaiHoiDap", hoiDap.LoaiHoiDapId);
            return View(hoiDap);
        }

        // GET: Admin/HoiDaps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoiDap hoiDap = db.HoiDaps.Find(id);
            if (hoiDap == null)
            {
                return HttpNotFound();
            }
            return View(hoiDap);
        }

        // POST: Admin/HoiDaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HoiDap hoiDap = db.HoiDaps.Find(id);
            db.HoiDaps.Remove(hoiDap);
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
