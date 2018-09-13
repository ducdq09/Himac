using Himac.Data;
using Himac.Model.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Himac.Service;

namespace Himac.Web.Areas.Admin.Controllers
{
    public class HoiDapsController : Controller
    {
        private HimacDbContext db = new HimacDbContext();
        private readonly IHoiDapService _hoiDapService;

        public HoiDapsController(IHoiDapService hoiDapService)
        {
            this._hoiDapService = hoiDapService;
        }

        // GET: Admin/HoiDaps
        public ActionResult Index()
        {
            ViewBag.vTitle = "Hỏi đáp Pháp luật";
            ViewBag.vMenu = "Admin";
            ViewBag.vController = "Hỏi đáp Pháp luật";
            ViewBag.vAction = "Danh sách";

            var hoiDaps = _hoiDapService.SelectAll();
            return View(hoiDaps.ToList());
        }

        // GET: Admin/HoiDaps/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            HoiDap hoiDap = _hoiDapService.SelectById(id);
            if (hoiDap == null)
            {
                return HttpNotFound();
            }
            return View(hoiDap);
        }

        // GET: Admin/HoiDaps/Create
        public ActionResult Create()
        {
            ViewBag.LinhVucId = new SelectList(db.LinhVucs, "LinhVucId", "TenLinhVuc");
            return View();
        }

        // POST: Admin/HoiDaps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HoiDapId,CauHoi,Content,ImagePath,FilePath,LinhVucId,OrderHint,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,MetaKeyword,MetaDescription,Status")] HoiDap hoiDap)
        {
            if (ModelState.IsValid)
            {
                _hoiDapService.Insert(hoiDap);
                _hoiDapService.Save();
                return RedirectToAction("Index");
            }

            ViewBag.LinhVucId = new SelectList(db.LinhVucs, "LinhVucId", "TenLinhVuc", hoiDap.LinhVucId);
            return View(hoiDap);
        }

        // GET: Admin/HoiDaps/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoiDap hoiDap = _hoiDapService.SelectById(id);
            if (hoiDap == null)
            {
                return HttpNotFound();
            }
            ViewBag.LinhVucId = new SelectList(db.LinhVucs, "LinhVucId", "TenLinhVuc", hoiDap.LinhVucId);
            return View(hoiDap);
        }

        // POST: Admin/HoiDaps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HoiDapId,CauHoi,Content,ImagePath,FilePath,LinhVucId,OrderHint,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,MetaKeyword,MetaDescription,Status")] HoiDap hoiDap)
        {
            if (ModelState.IsValid)
            {
                _hoiDapService.Update(hoiDap);
                _hoiDapService.Save();
                return RedirectToAction("Index");
            }
            ViewBag.LinhVucId = new SelectList(db.LinhVucs, "LinhVucId", "TenLinhVuc", hoiDap.LinhVucId);
            return View(hoiDap);
        }

        // GET: Admin/HoiDaps/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            HoiDap hoiDap = _hoiDapService.SelectById(id);
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
            _hoiDapService.Delete(id);
            _hoiDapService.Save();

            return RedirectToAction("Index");
        }
    }
}