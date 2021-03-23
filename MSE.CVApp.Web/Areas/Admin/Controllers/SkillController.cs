using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MSE.CVApp.Business.Interfaces;
using MSE.CVApp.DTO.DTOs.SkillDTOs;
using MSE.CVApp.Entities.Concrete;

namespace MSE.CVApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SkillController : Controller
    {
        private readonly IGenericService<Skill> _genericSkillService;
        private readonly IMapper _mapper;

        public SkillController(IGenericService<Skill> genericSkillService, IMapper mapper)
        {
            _genericSkillService = genericSkillService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "yetenek";
            return View(_mapper.Map<List<SkillListDTO>>(_genericSkillService.GetAll()));
        }

        public IActionResult Add()
        {
            TempData["active"] = "yetenek";
            return View(new SkillAddDTO());
        }

        [HttpPost]
        public IActionResult Add(SkillAddDTO model)
        {
            TempData["active"] = "yetenek";
            if (ModelState.IsValid)
            {
                _genericSkillService.Insert(_mapper.Map<Skill>(model));
                TempData["message"] = "Ekleme işleminiz başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int id)
        {
            TempData["active"] = "yetenek";
            return View(_mapper.Map<SkillUpdateDTO>(_genericSkillService.GetById(id)));
        }

        [HttpPost]
        public IActionResult Update(SkillUpdateDTO model)
        {
            TempData["active"] = "yetenek";
            if (ModelState.IsValid)
            {
                var updatedSkill = _genericSkillService.GetById(model.Id);

                updatedSkill.Description = model.Description;
                _genericSkillService.Update(updatedSkill);

                TempData["message"] = "Güncelleme işleminiz başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            TempData["active"] = "yetenek";
            var deletedSkill= _genericSkillService.GetById(id);
            _genericSkillService.Delete(deletedSkill);
            TempData["message"] = "Silme işleminiz başarılı";
            return RedirectToAction("Index");
        }
    }
}
