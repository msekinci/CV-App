using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MSE.CVApp.Business.Interfaces;
using MSE.CVApp.DTO.DTOs.InterestDTOs;
using MSE.CVApp.Entities.Concrete;

namespace MSE.CVApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class InterestController: Controller
    {
        private readonly IGenericService<Interest> _genericInterestService;
        private readonly IMapper _mapper;
        public InterestController(IGenericService<Interest> genericInterestService, IMapper mapper)
        {
            _genericInterestService = genericInterestService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "hobi";
            return View(_mapper.Map<List<InterestListDTO>>(_genericInterestService.GetAll()));
        }

        public IActionResult Add()
        {
            TempData["active"] = "hobi";
            return View(new InterestAddDTO());
        }

        [HttpPost]
        public IActionResult Add(InterestAddDTO model)
        {
            TempData["active"] = "hobi";
            if (ModelState.IsValid)
            {
                _genericInterestService.Insert(_mapper.Map<Interest>(model));
                TempData["message"] = "Ekleme işleminiz başarılı";
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Update(int id)
        {
            TempData["active"] = "hobi";
            return View( _mapper.Map<InterestUpdateDTO>( _genericInterestService.GetById(id)));
        }

        [HttpPost]
        public IActionResult Update(InterestUpdateDTO model)
        {
            TempData["active"] = "hobi";
            if (ModelState.IsValid)
            {
                var updatedInterest = _genericInterestService.GetById(model.Id);
                updatedInterest.Description = model.Description;
                _genericInterestService.Update(updatedInterest);

                TempData["message"] = "Güncelleme işleminiz başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            TempData["active"] = "hobi";
            var deletedInterest = _genericInterestService.GetById(id);
            _genericInterestService.Delete(deletedInterest);
            TempData["message"] = "Silme işleminiz başarılı";
            return RedirectToAction("Index");
        }
    }
}
