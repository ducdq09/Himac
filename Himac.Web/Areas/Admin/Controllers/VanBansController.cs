using Himac.Data;
using Himac.Model.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Himac.Service;

namespace Himac.Web.Areas.Admin.Controllers
{
    public class VanBansController : Controller
    {
        private HimacDbContext db = new HimacDbContext();
        private readonly IVanBanService _vanBanService;

        public VanBansController(IVanBanService vanBanService)
        {
            this._vanBanService = vanBanService;
        }

        // GET: Admin/VanBans
        public ActionResult Index()
        {
            ViewBag.vTitle = "Văn bản";
            ViewBag.vMenu = "Admin";
            ViewBag.vController = "Văn bản";
            ViewBag.vAction = "Danh sách";

            var vanBans = _vanBanService.SelectAll();
            return View(vanBans.ToList());
        }

        // GET: Admin/VanBans/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            VanBan vanBan = _vanBanService.SelectById(id);
            if (vanBan == null)
            {
                return HttpNotFound();
            }
            return View(vanBan);
        }

        // GET: Admin/VanBans/Create
        public ActionResult Create()
        {
            ViewBag.LinhVucId = new SelectList(db.LinhVucs, "LinhVucId", "TenLinhVuc");
            ViewBag.LoaiVanBanId = new SelectList(db.LoaiVanBans, "LoaiVanBanId", "TenLoaiVanBan");
            return View();
        }

        // POST: Admin/VanBans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VanBanId,TenVanBan,Content,ImagePath,CoQuanBanHanh,NgayBanHanh,SoHieu,ApDung,LinhVucId,LoaiVanBanId,SoCongBao,NgayDangCongBao,NguoiKy,NgayHetHieuLuc,TinhTrangHieuLuc,OrderHint,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,MetaKeyword,MetaDescription,Status")] VanBan vanBan)
        {
            if (ModelState.IsValid)
            {
                _vanBanService.Insert(vanBan);
                _vanBanService.Save();
                return RedirectToAction("Index");
            }

            ViewBag.LinhVucId = new SelectList(db.LinhVucs, "LinhVucId", "TenLinhVuc", vanBan.LinhVucId);
            ViewBag.LoaiVanBanId = new SelectList(db.LoaiVanBans, "LoaiVanBanId", "TenLoaiVanBan", vanBan.LoaiVanBanId);
            return View(vanBan);
        }

        // GET: Admin/VanBans/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            VanBan vanBan = _vanBanService.SelectById(id);
            if (vanBan == null)
            {
                return HttpNotFound();
            }
            ViewBag.LinhVucId = new SelectList(db.LinhVucs, "LinhVucId", "TenLinhVuc", vanBan.LinhVucId);
            ViewBag.LoaiVanBanId = new SelectList(db.LoaiVanBans, "LoaiVanBanId", "TenLoaiVanBan", vanBan.LoaiVanBanId);
            return View(vanBan);
        }

        // POST: Admin/VanBans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VanBanId,TenVanBan,Content,ImagePath,CoQuanBanHanh,NgayBanHanh,SoHieu,ApDung,LinhVucId,LoaiVanBanId,SoCongBao,NgayDangCongBao,NguoiKy,NgayHetHieuLuc,TinhTrangHieuLuc,OrderHint,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,MetaKeyword,MetaDescription,Status")] VanBan vanBan)
        {
            if (ModelState.IsValid)
            {
                _vanBanService.Update(vanBan);
                _vanBanService.Save();
                return RedirectToAction("Index");
            }
            ViewBag.LinhVucId = new SelectList(db.LinhVucs, "LinhVucId", "TenLinhVuc", vanBan.LinhVucId);
            ViewBag.LoaiVanBanId = new SelectList(db.LoaiVanBans, "LoaiVanBanId", "TenLoaiVanBan", vanBan.LoaiVanBanId);
            return View(vanBan);
        }

        // GET: Admin/VanBans/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VanBan vanBan = _vanBanService.SelectById(id);
            if (vanBan == null)
            {
                return HttpNotFound();
            }
            return View(vanBan);
        }

        // POST: Admin/VanBans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _vanBanService.Delete(id);
            _vanBanService.Save();
            return RedirectToAction("Index");
        }
    }
}