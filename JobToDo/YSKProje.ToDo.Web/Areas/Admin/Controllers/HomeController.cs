using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles ="Admin")]
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IGorevService _gorevService;
        private readonly IBildirimService _bildirimService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IRaporService _raporService;

        public HomeController(IGorevService gorevService,IBildirimService bildirimService,UserManager<AppUser> userManager,IRaporService raporService)
        {
            _gorevService = gorevService;
            _bildirimService = bildirimService;
            _userManager = userManager;
            _raporService = raporService;
        }
        public async Task<IActionResult> Index()
        {
            TempData["Active"] = "anasayfa";
            ViewBag.AtanmayiBekleyenGorevSayisi = _gorevService.AtanmayiBekleyenGorevSayisi();


            ViewBag.TamamlanmisGorevSayisi = _gorevService.TamamlanmisGorevSayisi();

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.OkunmamisBildirimSayisi = _bildirimService.GetirOkunmayanSayisiileAppUserId(user.Id);

            ViewBag.ToplamRaporSayisi = _raporService.GetirRaporSayisi();
            return View();
        }

    }
}