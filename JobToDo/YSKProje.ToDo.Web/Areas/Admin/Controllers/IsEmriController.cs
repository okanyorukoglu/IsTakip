using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.DTO.DTOs.AppUserDto;
using YSKProje.ToDo.DTO.DTOs.GorevDto;
using YSKProje.ToDo.DTO.DTOs.PersonelDto;
using YSKProje.ToDo.Entities.Concrete;
using YSKProje.ToDo.Web.Areas.Admin.Models;

namespace YSKProje.ToDo.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class IsEmriController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IGorevService _gorevService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IDosyaService _dosyaService;
        private readonly IBildirimService _bildirimService;
        private readonly IMapper _mapper;

        public IsEmriController(IAppUserService appUserService, IGorevService gorevService,
            UserManager<AppUser> userManager, IDosyaService dosyaService,
            IBildirimService bildirimService,IMapper mapper)
        {
            _dosyaService = dosyaService;
            _bildirimService = bildirimService;
            _mapper = mapper;
            _userManager = userManager;
            _gorevService = gorevService;
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            TempData["Active"] = "isemri";


            //List<Gorev> gorevler = _gorevService.GetirTumTablolarla();
            //List<GorevListAllViewModel> models = new List<GorevListAllViewModel>();

            //foreach (var item in gorevler)
            //{
            //    GorevListAllViewModel model = new GorevListAllViewModel();
            //    model.Id = item.Id;
            //    model.Aciklama = item.Aciklama;
            //    model.Aciliyet = item.Aciliyet;
            //    model.Ad = item.Ad;
            //    model.AppUser = item.AppUser;
            //    model.OlusturulmaTarih = item.OlusturulmaTarih;
            //    model.Raporlar = item.Raporlar;
            //    models.Add(model);
            //}

            

            return View(_mapper.Map<List<GorevListAllDto>>(_gorevService.GetirTumTablolarla()));
        }


        public IActionResult Detaylandir(int id)
        {
            TempData["Active"] = "isemri";
            //var gorev = _gorevService.GetirRaporlarileId(id);
            //GorevListAllViewModel model = new GorevListAllViewModel();
            //model.Id = gorev.Id;

            //model.Raporlar = gorev.Raporlar;
            //model.Ad = gorev.Ad;
            //model.Aciklama = gorev.Aciklama;
            //model.AppUser = gorev.AppUser;

            
            return View(_mapper.Map<GorevListAllDto>(_gorevService.GetirRaporlarileId(id)));
        }

        public IActionResult GetirExcel(int id)
        {
            return File(_dosyaService.AktarExcel(_gorevService.GetirRaporlarileId(id).Raporlar), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", Guid.NewGuid() + ".xlsx");
        }

        public IActionResult GetirPdf(int id)
        {
            var path = _dosyaService.AktarPdf(_gorevService.GetirRaporlarileId(id).Raporlar);
            return File(path, "application/pdf", Guid.NewGuid() + ".pdf");
        }

        // ysk.com.tr/?s=yavuz
        public IActionResult AtaPersonel(int id, string s, int sayfa = 1)
        {
            TempData["Active"] = "isemri";

            ViewBag.AktifSayfa = sayfa;
            //ViewBag.ToplamSayfa = (int)Math.Ceiling((double)_appUserService.GetirAdminOlmayanlar().Count / 3);

            ViewBag.Aranan = s;

            int toplamSayfa;
            //var gorev = _gorevService.GetirAciliyetileId(id);
            //var personeller = _appUserService.GetirAdminOlmayanlar(out toplamSayfa, s, sayfa);

           var personeller = _mapper.Map<List<AppUserListDto>>(_appUserService.GetirAdminOlmayanlar(out toplamSayfa, s, sayfa));

            ViewBag.ToplamSayfa = toplamSayfa;

            //List<AppUserListViewModel> appUserListModel = new List<AppUserListViewModel>();
            //foreach (var item in personeller)
            //{
            //    AppUserListViewModel model = new AppUserListViewModel();
            //    model.Id = item.Id;
            //    model.Name = item.Name;
            //    model.SurName = item.Surname;
            //    model.Email = item.Email;
            //    model.Picture = item.Picture;
            //    appUserListModel.Add(model);
            //}

            ViewBag.Personeller = personeller;

            
            //GorevListViewModel gorevModel = new GorevListViewModel();
            //gorevModel.Id = gorev.Id;
            //gorevModel.Ad = gorev.Ad;
            //gorevModel.Aciklama = gorev.Aciklama;
            //gorevModel.Aciliyet = gorev.Aciliyet;
            //gorevModel.OlusturulmaTarih = gorev.OlusturulmaTarih;
            return View(_mapper.Map<GorevListDto>(_gorevService.GetirAciliyetileId(id)));
        }


        [HttpPost]
        public IActionResult AtaPersonel(PersonelGorevlendirDto model)
        {
            var guncellenecekGorev = _gorevService.GetirIdile(model.GorevId);
            guncellenecekGorev.AppUserId = model.PersonelId;
            _bildirimService.Kaydet(new Bildirim
            {
                AppUserId = model.PersonelId,
                Aciklama = $"{guncellenecekGorev.Ad} adlı iş için görevlendirildiniz."
            }) ;

            _gorevService.Guncelle(guncellenecekGorev);
            return RedirectToAction("Index");
        }



        public IActionResult GorevlendirPersonel(PersonelGorevlendirDto model)
        {

            TempData["Active"] = "isemri";
            PersonelGorevlendirListDto personelGorevlendirModel = new PersonelGorevlendirListDto();

            personelGorevlendirModel.AppUser = _mapper.Map<AppUserListDto>(_userManager.Users.FirstOrDefault(I => I.Id == model.PersonelId));
            //var user = _userManager.Users.FirstOrDefault(I => I.Id == model.PersonelId);

            //var gorev = _gorevService.GetirAciliyetileId(model.GorevId);

            //var userModel =
            //AppUserListViewModel userModel = new AppUserListViewModel();
            //userModel.Id = user.Id;
            //userModel.Name = user.Name;
            //userModel.Picture = user.Picture;
            //userModel.SurName = user.Surname;
            //userModel.Email = user.Email;

           // var gorevModel = 
            //GorevListViewModel gorevModel = new GorevListViewModel();
            //gorevModel.Id = gorev.Id;
            //gorevModel.Aciklama = gorev.Aciklama;
            //gorevModel.Aciliyet = gorev.Aciliyet;
            //gorevModel.Ad = gorev.Ad;


           

            
            personelGorevlendirModel.Gorev = _mapper.Map<GorevListDto>(_gorevService.GetirAciliyetileId(model.GorevId));

            return View(personelGorevlendirModel);
        }

    }
}