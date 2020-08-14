using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.Entities.Concrete;
using YSKProje.ToDo.Web.Areas.Admin.Models;

namespace YSKProje.ToDo.Web.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "Member")]
    public class IsEmriController : Controller
    {
        private readonly IGorevService _gorevService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IRaporService _raporService;
        private readonly IBildirimService _bildirimService;

        public IsEmriController(IGorevService gorevService,UserManager<AppUser> userManager,
            IRaporService raporService,IBildirimService bildirimService)
        {
            _gorevService = gorevService;
            _userManager = userManager;
            _raporService = raporService;
            _bildirimService = bildirimService;
        }
        public async Task<IActionResult> Index()
        {
            //Giriş yapmış kullanıcının username ini User.Identity.Name bu şekilde alıyoruz.
             var user = await _userManager.FindByNameAsync(User.Identity.Name);

            TempData["Active"] = "isemri";
           var gorev = _gorevService.GetirTumTablolarla(I => I.AppUserId == user.Id && !I.Durum);
            List<GorevListAllViewModel> models = new List<GorevListAllViewModel>();
            foreach (var item in gorev)
            {
                GorevListAllViewModel model = new GorevListAllViewModel();
                model.Id = item.Id;
                model.Ad = item.Ad;
                model.Aciklama = item.Aciklama;
                model.Aciliyet = item.Aciliyet;
                model.AppUser = item.AppUser;
                model.Raporlar = item.Raporlar;
                model.OlusturulmaTarih = item.OlusturulmaTarih;
                models.Add(model);


            }

            return View(models);
        }


        public IActionResult EkleRapor(int id)
        {
            TempData["Active"] = "isemri";
            var gorev = _gorevService.GetirAciliyetileId(id);
            RaporAddViewModel model = new RaporAddViewModel();
            model.GorevId = id;
            model.Gorev = gorev;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EkleRapor(RaporAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _raporService.Kaydet(new Rapor()
                {
                    GorevId=model.GorevId,
                    Detay =model.Detay,
                    Tanim = model.Tanim
                });

                var adminList = await _userManager.GetUsersInRoleAsync("Admin");
                var memberName = await _userManager.FindByNameAsync(User.Identity.Name);

                foreach (var admin in adminList)
                {
                    _bildirimService.Kaydet(new Bildirim
                    {

                        Aciklama = $"{memberName.Name} {memberName.Surname} yeni bir rapor yazdı",
                        AppUserId = admin.Id
                    }) ;
                }

                return RedirectToAction("Index");
            }

            return View(model);
        }



        

        public IActionResult GuncelleRapor(int id)
        {
            TempData["Active"] = "isemri";
           var rapor = _raporService.GetirGorevIleId(id);
            RaporUpdateViewModel model = new RaporUpdateViewModel();
            model.Tanim = rapor.Tanim;
            model.Detay = rapor.Detay;
            model.GorevId = rapor.GorevId;
            model.Gorev = rapor.Gorev;
            model.Id = rapor.Id;

            return View(model);
        }

        [HttpPost]
        public IActionResult GuncelleRapor(RaporUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var guncelle = _raporService.GetirIdile(model.Id);
                guncelle.Tanim = model.Tanim;
                guncelle.Detay = model.Detay;
                _raporService.Guncelle(guncelle);

                return RedirectToAction("Index");


            }

            return View(model);
        }


        public async Task<IActionResult> TamamlaGorevAsync(int gorevId)
        {
          var guncellenecekGorev =  _gorevService.GetirIdile(gorevId);
            guncellenecekGorev.Durum = true;
            _gorevService.Guncelle(guncellenecekGorev);

            var adminList = await _userManager.GetUsersInRoleAsync("Admin");
            var memberName = await _userManager.FindByNameAsync(User.Identity.Name);

            foreach (var admin in adminList)
            {
                _bildirimService.Kaydet(new Bildirim
                {

                    Aciklama = $"{memberName.Name} {memberName.Surname} verilen bir görevi tamamladı",
                    AppUserId = admin.Id
                });
            }
            return Json(null);


        }


    }
}
