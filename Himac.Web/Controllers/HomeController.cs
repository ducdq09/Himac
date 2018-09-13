using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Himac.Service;

namespace Himac.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVanBanService _vanBanService;
        private readonly ITinTucService _tinTucService;

        public HomeController(IVanBanService vanBanService, ITinTucService tinTucService)
        {
            this._vanBanService = vanBanService;
            this._tinTucService = tinTucService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Get5VanBanMoiNhat()
        {
            var vanBans = _vanBanService.Select5VanBanMoiNhat().ToList();
            return PartialView("_TopVanBan", vanBans);
        }

        public ActionResult Get5HoiDapMoiNhat()
        {
            var vanBans = _vanBanService.Select5VanBanMoiNhat().ToList();
            return PartialView("_TopVanBan", vanBans);
        }

        public ActionResult Get16TinTucMoiNhat()
        {
            var tinTucs = _tinTucService.Select16TinPhapLuatMoiNhat().ToList();
            return PartialView("_TopHoiDap", tinTucs);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}