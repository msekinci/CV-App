using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MSE.CVApp.Business.Interfaces;
using MSE.CVApp.DTO.DTOs.EducationDTOs;
using MSE.CVApp.Entities.Concrete;
using System.Collections.Generic;

namespace MSE.CVApp.Web.ViewComponents
{
    public class EducationComponent : ViewComponent
    {
        private readonly IGenericService<Education> _genericService;
        private readonly IMapper _mapper;

        public EducationComponent(IGenericService<Education> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<EducationListDTO>>(_genericService.GetAll()));
        }
    }
}
