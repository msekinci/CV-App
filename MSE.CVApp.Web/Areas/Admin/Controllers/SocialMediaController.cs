using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MSE.CVApp.Business.Interfaces;
using MSE.CVApp.Entities.Concrete;
using MSE.CVApp.DTO.DTOs.SocialMediaDTOs;

namespace MSE.CVApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SocialMediaController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(IAppUserService appUserService, ISocialMediaService socialMediaService, IMapper mapper)
        {
            _appUserService = appUserService;
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "ikon";
            var user = _appUserService.FindByName(User.Identity.Name);

            return View(_mapper.Map<List<SocialMediaListDTO>>(_socialMediaService.GetByUserId(user.Id)));

        }

        public IActionResult Add()
        {
            TempData["active"] = "ikon";
            return View(new SocialMediaAddDTO());
        }

        [HttpPost]
        public IActionResult Add(SocialMediaAddDTO model)
        {
            TempData["active"] = "ikon";
            if (ModelState.IsValid)
            {
                var user = _appUserService.FindByName(User.Identity.Name);
                model.AppUserId = user.Id;

                _socialMediaService.Insert(_mapper.Map<SocialMediaIcon>(model));
                TempData["message"] = "Ekleme işlemi başarılı";

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int id)
        {
            TempData["active"] = "ikon";
            return View(_mapper.Map<SocialMediaUpdateDTO>(_socialMediaService.GetById(id)));
        }

        [HttpPost]
        public IActionResult Update(SocialMediaUpdateDTO model)
        {
            TempData["active"] = "ikon";
            if (ModelState.IsValid)
            {
                var user = _appUserService.FindByName(User.Identity.Name);
                var updatedSocialMedia = _socialMediaService.GetById(model.Id);

                updatedSocialMedia.AppUserId = user.Id;
                updatedSocialMedia.Icon= model.Icon;
                updatedSocialMedia.Link = model.Link;

                _socialMediaService.Update(updatedSocialMedia);
                TempData["message"] = "Güncelleme işlemi başarılı";

                return RedirectToAction("Index");
            }
            return View(model);
        }


        public IActionResult Delete(int id)
        {

            TempData["active"] = "ikon";
            var deleted = _socialMediaService.GetById(id);
            _socialMediaService.Delete(deleted);
            TempData["message"] = "Silme işlemi başarılı";

            return RedirectToAction("Index");
        }
    }
}
