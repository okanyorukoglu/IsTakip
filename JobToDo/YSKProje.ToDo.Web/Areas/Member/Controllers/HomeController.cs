using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Web.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "Member")]
    public class HomeController : Controller
    {
        private readonly IRaporService _raporService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IGorevService _gorevService;
        private readonly IBildirimService _bildirimService;

        public HomeController(IRaporService raporService,UserManager<AppUser> userManager,
            IGorevService gorevService,IBildirimService bildirimService)
        {
            _raporService = raporService;
            _userManager = userManager;
            _gorevService = gorevService;
            _bildirimService = bildirimService;
        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            TempData["Active"] = "anasayfa";
            ViewBag.RaporSayisi = _raporService.GetirRaporSayisiIleAppUserId(user.Id);
            ViewBag.TamamlananGorevSayisi =
                _gorevService.GetirGorevSayisiTamamlananileAppUserId(user.Id);

            ViewBag.TamamlananmasıGerekenGorevSayisi =
                _gorevService.GetirGorevSayisiTamamlanmasıGerekenileAppUserId(user.Id);

            ViewBag.OkunmamisBildirimSayisi = _bildirimService.GetirOkunmayanSayisiileAppUserId(user.Id);

            return View();
        }
    }
}