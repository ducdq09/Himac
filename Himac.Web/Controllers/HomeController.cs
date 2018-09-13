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
        private readonly IHoiDapService _hoiDapService;

        public HomeController(IVanBanService vanBanService, ITinTucService tinTucService, IHoiDapService hoiDapService)
        {
            this._vanBanService = vanBanService;
            this._tinTucService = tinTucService;
            this._hoiDapService = hoiDapService;
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
            var hoiDaps = _hoiDapService.Select5HoiDapMoiNhat();
            return PartialView("_TopHoiDap", hoiDaps);
        }

        public ActionResult Get16TinTucMoiNhat()
        {
            var tinTucs = _tinTucService.Select16TinPhapLuatMoiNhat().ToList();
            return PartialView("_TopTinTuc", tinTucs);
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