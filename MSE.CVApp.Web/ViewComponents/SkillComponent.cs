using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MSE.CVApp.Business.Interfaces;
using MSE.CVApp.DTO.DTOs.SkillDTOs;
using MSE.CVApp.Entities.Concrete;
using System.Collections.Generic;

namespace MSE.CVApp.Web.ViewComponents
{
    public class SkillComponent : ViewComponent
    {
        private readonly IGenericService<Skill> _genericService;
        private readonly IMapper _mapper;

        public SkillComponent(IGenericService<Skill> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<SkillListDTO>>(_genericService.GetAll()));
        }
    }
}
