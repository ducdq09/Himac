using Himac.Data;
using Himac.Model.Models;
using System;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Himac.Service;

namespace Himac.Web.Areas.Admin.Controllers
{
    public class TinTucsController : Controller
    {
        private HimacDbContext db = new HimacDbContext();
        private readonly ITinTucService _tinTucService;

        public TinTucsController(ITinTucService tinTucService)
        {
            this._tinTucService = tinTucService;
        }

        // GET: Admin/TinTucs
        public ActionResult Index()
        {
            ViewBag.vTitle = "Tin tức";
            ViewBag.vMenu = "Admin";
            ViewBag.vController = "Tin tức";
            ViewBag.vAction = "Danh sách";

            var tinTucs = _tinTucService.SelectAll();
            return View(tinTucs.ToList());
        }

        // GET: Admin/TinTucs/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            TinTuc tinTuc = _tinTucService.SelectById(id);
            if (tinTuc == null)
            {
                return HttpNotFound();
            }
            return View(tinTuc);
        }

        // GET: Admin/TinTucs/Create
        public ActionResult Create()
        {
            ViewBag.LoaiTinTucId = new SelectList(db.LoaiTinTucs, "LoaiTinTucId", "TenLoaiTinTuc");
            return View();
        }

        // POST: Admin/TinTucs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TinTucId,TieuDe,Content,ImagePath,LoaiTinTucId,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,MetaKeyword,MetaDescription,Status")] TinTuc tinTuc, HttpPostedFileBase ImageFile)
        {
            if (ModelState.IsValid)
            {
                if (ImageFile == null)
                {
                    tinTuc.ImagePath = "~/FileUploads/" + "newsDefault.jpg";
                }
                else
                {
                    string fileName = Path.GetFileNameWithoutExtension(ImageFile.FileName);
                    string extension = Path.GetExtension(ImageFile.FileName);
                    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    tinTuc.ImagePath = "~/FileUploads/" + fileName;
                    ImageFile.SaveAs(Server.MapPath("~/FileUploads/") + fileName);
                }

                _tinTucService.Insert(tinTuc);
                _tinTucService.Save();
                return RedirectToAction("Index");
            }

            ViewBag.LoaiTinTucId = new SelectList(db.LoaiTinTucs, "LoaiTinTucId", "TenLoaiTinTuc", tinTuc.LoaiTinTucId);
            return View(tinTuc);
        }

        // GET: Admin/TinTucs/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            TinTuc tinTuc = _tinTucService.SelectById(id);
            if (tinTuc == null)
            {
                return HttpNotFound();
            }
            ViewBag.LoaiTinTucId = new SelectList(db.LoaiTinTucs, "LoaiTinTucId", "TenLoaiTinTuc", tinTuc.LoaiTinTucId);
            return View(tinTuc);
        }

        // POST: Admin/TinTucs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TinTucId,TieuDe,Content,ImagePath,LoaiTinTucId,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,MetaKeyword,MetaDescription,Status")] TinTuc tinTuc)
        {
            if (ModelState.IsValid)
            {
                _tinTucService.Update(tinTuc);
                _tinTucService.Save();
                return RedirectToAction("Index");
            }
            ViewBag.LoaiTinTucId = new SelectList(db.LoaiTinTucs, "LoaiTinTucId", "MaLoaiTinTuc", tinTuc.LoaiTinTucId);
            return View(tinTuc);
        }

        // GET: Admin/TinTucs/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            TinTuc tinTuc = _tinTucService.SelectById(id);
            if (tinTuc == null)
            {
                return HttpNotFound();
            }
            return View(tinTuc);
        }

        // POST: Admin/TinTucs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _tinTucService.Delete(id);
            _tinTucService.Save();
            return RedirectToAction("Index");
        }
    }
}