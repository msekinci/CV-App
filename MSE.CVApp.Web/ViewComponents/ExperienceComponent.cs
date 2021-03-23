using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MSE.CVApp.Business.Interfaces;
using MSE.CVApp.DTO.DTOs.ExperienceDTOs;
using MSE.CVApp.Entities.Concrete;
using System.Collections.Generic;

namespace MSE.CVApp.Web.ViewComponents
{
    public class ExperienceComponent : ViewComponent
    {
        private readonly IGenericService<Experience> _genericService;
        private readonly IMapper _mapper;

        public ExperienceComponent(IGenericService<Experience> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<ExperienceListDTO>>(_genericService.GetAll()));
        }
    }
}
