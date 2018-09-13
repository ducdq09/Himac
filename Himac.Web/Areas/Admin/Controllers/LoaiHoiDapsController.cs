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
    public class LoaiHoiDapsController : Controller
    {
        private HimacDbContext db = new HimacDbContext();

        // GET: Admin/LoaiHoiDaps
        public ActionResult Index()
        {
            return View(db.LoaiHoiDaps.ToList());
        }

        // GET: Admin/LoaiHoiDaps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiHoiDap loaiHoiDap = db.LoaiHoiDaps.Find(id);
            if (loaiHoiDap == null)
            {
                return HttpNotFound();
            }
            return View(loaiHoiDap);
        }

        // GET: Admin/LoaiHoiDaps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/LoaiHoiDaps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LoaiHoiDapId,TenLoaiHoiDap,Description,OrderHint,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,MetaKeyword,MetaDescription,Status")] LoaiHoiDap loaiHoiDap)
        {
            if (ModelState.IsValid)
            {
                db.LoaiHoiDaps.Add(loaiHoiDap);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loaiHoiDap);
        }

        // GET: Admin/LoaiHoiDaps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiHoiDap loaiHoiDap = db.LoaiHoiDaps.Find(id);
            if (loaiHoiDap == null)
            {
                return HttpNotFound();
            }
            return View(loaiHoiDap);
        }

        // POST: Admin/LoaiHoiDaps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LoaiHoiDapId,TenLoaiHoiDap,Description,OrderHint,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,MetaKeyword,MetaDescription,Status")] LoaiHoiDap loaiHoiDap)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaiHoiDap).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaiHoiDap);
        }

        // GET: Admin/LoaiHoiDaps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiHoiDap loaiHoiDap = db.LoaiHoiDaps.Find(id);
            if (loaiHoiDap == null)
            {
                return HttpNotFound();
            }
            return View(loaiHoiDap);
        }

        // POST: Admin/LoaiHoiDaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LoaiHoiDap loaiHoiDap = db.LoaiHoiDaps.Find(id);
            db.LoaiHoiDaps.Remove(loaiHoiDap);
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
