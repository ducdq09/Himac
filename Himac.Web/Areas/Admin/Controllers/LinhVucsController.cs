using Himac.Data;
using Himac.Model.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Himac.Service;

namespace Himac.Web.Areas.Admin.Controllers
{
    public class LinhVucsController : Controller
    {
        private readonly ILinhVucService _linhVucService;

        public LinhVucsController(ILinhVucService linhVucService)
        {
            this._linhVucService = linhVucService;
        }

        // GET: Admin/LinhVucs
        public ActionResult Index()
        {
            ViewBag.vTitle = "Lĩnh vực";
            ViewBag.vMenu = "Admin";
            ViewBag.vController = "Lĩnh vực";
            ViewBag.vAction = "Danh sách";

            var linhVucs = _linhVucService.SelectAll().ToList();
            return View(linhVucs);
        }

        // GET: Admin/LinhVucs/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            LinhVuc linhVuc = _linhVucService.SelectById(id);
            if (linhVuc == null)
            {
                return HttpNotFound();
            }
            return View(linhVuc);
        }

        // GET: Admin/LinhVucs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/LinhVucs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LinhVucId,TenLinhVuc,Description,OrderHint,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,MetaKeyword,MetaDescription,Status")] LinhVuc linhVuc)
        {
            if (ModelState.IsValid)
            {
                _linhVucService.Insert(linhVuc);
                _linhVucService.Save();
                return RedirectToAction("Index");
            }

            return View(linhVuc);
        }

        // GET: Admin/LinhVucs/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LinhVuc linhVuc = _linhVucService.SelectById(id);
            if (linhVuc == null)
            {
                return HttpNotFound();
            }
            return View(linhVuc);
        }

        // POST: Admin/LinhVucs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LinhVucId,TenLinhVuc,Description,OrderHint,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,MetaKeyword,MetaDescription,Status")] LinhVuc linhVuc)
        {
            if (ModelState.IsValid)
            {
                _linhVucService.Update(linhVuc);
                _linhVucService.Save();
                return RedirectToAction("Index");
            }
            return View(linhVuc);
        }

        // GET: Admin/LinhVucs/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LinhVuc linhVuc = _linhVucService.SelectById(id);
            if (linhVuc == null)
            {
                return HttpNotFound();
            }
            return View(linhVuc);
        }

        // POST: Admin/LinhVucs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _linhVucService.Delete(id);
            _linhVucService.Save();
            return RedirectToAction("Index");
        }
    }
}