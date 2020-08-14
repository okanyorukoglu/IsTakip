using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.DTO.DTOs.GorevDto;
using YSKProje.ToDo.Entities.Concrete;
using YSKProje.ToDo.Web.Areas.Admin.Models;

namespace YSKProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class GorevController : Controller
    {
        private readonly IGorevService _gorevService;
        private readonly IAciliyetService _aciliyetService;
        private readonly IMapper _mapper;

        public GorevController(IGorevService gorevService, IAciliyetService aciliyetService, IMapper mapper)
        {
            _aciliyetService = aciliyetService;
            _mapper = mapper;
            _gorevService = gorevService;
        }

        public IActionResult Index()
        {
            TempData["Active"] = "gorev";
           // List<Gorev> gorevler = _gorevService.GetirAciliyetIleTamamlanmayan();
            //List<GorevListViewModel> models = new List<GorevListViewModel>();
            //foreach (var item in gorevler)
            //{
            //    GorevListViewModel model = new GorevListViewModel
            //    {
            //        Aciklama = item.Aciklama,
            //        Aciliyet = item.Aciliyet,
            //        AciliyetId = item.AciliyetId,
            //        Ad = item.Ad,
            //        Durum = item.Durum,
            //        Id = item.Id,
            //        OlusturulmaTarih = item.OlusturulmaTarih
            //    };

            //    models.Add(model);
            //}

           
            return View(_mapper.Map<List<GorevListDto>>(_gorevService.GetirAciliyetIleTamamlanmayan()));
        }

        

        public IActionResult EkleGorev()
        {
            TempData["Active"] = "gorev";


            ViewBag.Aciliyetler = new SelectList(_aciliyetService.GetirHepsi(), "Id", "Tanim");
            return View(new GorevAddDto());
        }

        [HttpPost]
        public IActionResult EkleGorev(GorevAddDto model)
        {
            if (ModelState.IsValid)
            {
                _gorevService.Kaydet(new Gorev
                {
                    Aciklama = model.Aciklama,
                    Ad = model.Ad,
                    AciliyetId = model.AciliyetId,

                });

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult GuncelleGorev(int id)
        {
            TempData["Active"] = "gorev";
            var gorev = _gorevService.GetirIdile(id);
            //GorevUpdateViewModel model = new GorevUpdateViewModel
            //{
            //    Id = gorev.Id,
            //    Aciklama = gorev.Aciklama,
            //    AciliyetId = gorev.AciliyetId,
            //    Ad = gorev.Ad
            //};

            
            ViewBag.Aciliyetler = new SelectList(_aciliyetService.GetirHepsi(), "Id", "Tanim", gorev.AciliyetId /*gorev.AciliyetId*/);
            return View(_mapper.Map<GorevUpdateDto>(gorev));
        }

        [HttpPost]
        public IActionResult GuncelleGorev(GorevUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                _gorevService.Guncelle(new Gorev()
                {
                    Id = model.Id,
                    Aciklama = model.Aciklama,
                    AciliyetId = model.AciliyetId,
                    Ad = model.Ad

                });
                return RedirectToAction("Index");
            }
            ViewBag.Aciliyetler = new SelectList(_aciliyetService.GetirHepsi(), "Id", "Tanim", model.AciliyetId /*gorev.AciliyetId*/);
            return View(model);
        }

        public IActionResult SilGorev(int id)
        {
            _gorevService.Sil(new Gorev { Id = id });
            return Json(null);
        }
    }
}