using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MSE.CVApp.Business.Interfaces;
using MSE.CVApp.DTO.DTOs.InterestDTOs;
using MSE.CVApp.Entities.Concrete;
using System.Collections.Generic;

namespace MSE.CVApp.Web.ViewComponents
{
    public class InterestComponent : ViewComponent
    {
        private readonly IGenericService<Interest> _genericService;
        private readonly IMapper _mapper;

        public InterestComponent(IGenericService<Interest> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<InterestListDTO>>(_genericService.GetAll()));
        }
    }
}
