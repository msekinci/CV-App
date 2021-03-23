using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MSE.CVApp.Business.Interfaces;
using MSE.CVApp.DTO.DTOs.CertificationDTOs;
using MSE.CVApp.Entities.Concrete;

namespace MSE.CVApp.Web.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class CertificationController : Controller
    {
        private readonly IGenericService<Certification> _certificationGenericService;
        private readonly IMapper _mapper;

        public CertificationController(IGenericService<Certification> certificationGenericService, IMapper mapper)
        {
            _certificationGenericService = certificationGenericService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {

            TempData["active"] = "sertifika";
            return View(_mapper.Map<List<CertificationListDTO>>(_certificationGenericService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            TempData["active"] = "sertifika";
            var deletedEntity = _certificationGenericService.GetById(id);
            _certificationGenericService.Delete(deletedEntity);

            TempData["message"] = "Sertifika silindi";
            return RedirectToAction("Index");
        }


        public IActionResult Add()
        {
            TempData["active"] = "sertifika";
            return View(new CertificationAddDTO());
        }

        [HttpPost]
        public IActionResult Add(CertificationAddDTO model)
        {
            TempData["active"] = "sertifika";

            if (ModelState.IsValid)
            {
                _certificationGenericService.Insert(_mapper.Map<Certification>(model));
                TempData["message"] = "Sertifika eklendi";
                return RedirectToAction("Index");
            }

            return View(model);
        }


        public IActionResult Update(int id)
        {
            TempData["active"] = "sertifika";
            return View(_mapper.Map<CertificationUpdateDTO>( _certificationGenericService.GetById(id)));
        }

        [HttpPost]
        public IActionResult Update(CertificationUpdateDTO model)
        {
            TempData["active"] = "sertifika";
            if (ModelState.IsValid)
            {
                var updatedCertification= _certificationGenericService.GetById(model.Id);
                updatedCertification.Description = model.Description;
                _certificationGenericService.Update(updatedCertification);
                TempData["message"] = "Güncelleme işlemi başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
