using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Himac.Data;
using Himac.Data.Infrastructure;
using Himac.Data.Repositories;
using Himac.Model.Models;
using Himac.Service;

namespace Himac.Web.Areas.Admin.Controllers
{
    public class LoaiVanBansController : Controller
    {
        private readonly ILoaiVanBanService _loaiVanBanService;

        public LoaiVanBansController(ILoaiVanBanService loaiVanBanService)
        {
            this._loaiVanBanService = loaiVanBanService;
        }

        //readonly ILoaiVanBanRepository _loaiVanBanService;
        //readonly IUnitOfWork _unitOfWork;
        //public LoaiVanBansController(ILoaiVanBanRepository repository, IUnitOfWork unitOfWork)
        //{
        //    this._loaiVanBanService = repository;
        //    this._unitOfWork = unitOfWork;
        //}

        // GET: Admin/LoaiVanBans
        public ActionResult Index()
        {
            var loaiVanBans = _loaiVanBanService.SelectAll().ToList();
            return View(loaiVanBans);
        }

        // GET: Admin/LoaiVanBans/Details/5
        //public ActionResult Details(int id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }

        //    LoaiVanBan loaiVanBan = _loaiVanBanService.SelectById(id);
        //    if (loaiVanBan == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(loaiVanBan);
        //}

        //// GET: Admin/LoaiVanBans/Create
        public ActionResult Create()
        {
            return View();
        }

        //// POST: Admin/LoaiVanBans/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LoaiVanBanId,TenLoaiVanBan,Description,Image,ParentID,DisplayOrder,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,MetaKeyword,MetaDescription,Status")] LoaiVanBan loaiVanBan)
        {
            if (ModelState.IsValid)
            {
                _loaiVanBanService.Insert(loaiVanBan);
                _loaiVanBanService.Save();
                return RedirectToAction("Index");
            }

            return View(loaiVanBan);
        }

        //// GET: Admin/LoaiVanBans/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    LoaiVanBan loaiVanBan = _loaiVanBanService.SelectById(id);
        //    if (loaiVanBan == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(loaiVanBan);
        //}

        //// POST: Admin/LoaiVanBans/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "LoaiVanBanId,TenLoaiVanBan,Description,Image,ParentID,DisplayOrder,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,MetaKeyword,MetaDescription,Status")] LoaiVanBan loaiVanBan)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _loaiVanBanService.Insert(loaiVanBan);
        //        _loaiVanBanService.Save();
        //        return RedirectToAction("Index");
        //    }
        //    return View(loaiVanBan);
        //}

        //// GET: Admin/LoaiVanBans/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    LoaiVanBan loaiVanBan = _loaiVanBanService.SelectById(id);
        //    if (loaiVanBan == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(loaiVanBan);
        //}

        //// POST: Admin/LoaiVanBans/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    LoaiVanBan loaiVanBan = _loaiVanBanService.SelectById(id);
        //    _loaiVanBanService.Delete(id);
        //    _loaiVanBanService.Save();
        //    return RedirectToAction("Index");
        //}
    }
}
