using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MSE.CVApp.Business.Interfaces;
using MSE.CVApp.DTO.DTOs.EducationDTOs;
using MSE.CVApp.Entities.Concrete;

namespace MSE.CVApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class EducationController : Controller
    {
        private readonly IGenericService<Education> _educationGenericService;
        private readonly IMapper _mapper;

        public EducationController(IGenericService<Education> educationGenericService, IMapper mapper)
        {
            _educationGenericService = educationGenericService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "egitim";
            return View(_mapper.Map<List<EducationListDTO>>(_educationGenericService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            TempData["active"] = "egitim";
            var deletedEntity= _educationGenericService.GetById(id);
            _educationGenericService.Delete(deletedEntity);

            TempData["message"] = "Silme işlemi başarılı";
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            TempData["active"] = "egitim";
            return View(new EducationAddDTO());
        }

        [HttpPost]
        public IActionResult Add(EducationAddDTO model)
        {
            TempData["active"] = "egitim";
            if (ModelState.IsValid)
            {
                _educationGenericService.Insert(_mapper.Map<Education>(model));
                TempData["message"] = "Ekleme işlemi başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int id)
        {
            TempData["active"] = "egitim";
            return View(_mapper.Map<EducationUpdateDTO>( _educationGenericService.GetById(id)));
        }
        [HttpPost]
        public IActionResult Update(EducationUpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                var updatedEducation= _educationGenericService.GetById(model.Id);
                updatedEducation.StartDate = model.StartDate;
                updatedEducation.SubTitle = model.SubTitle;
                updatedEducation.Title = model.Title;
                updatedEducation.Description = model.Description;
                updatedEducation.EndDate = model.EndDate;

                _educationGenericService.Update(updatedEducation);
                TempData["message"] = "Güncelleme işleminiz başarı ile gerçekleşti";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
