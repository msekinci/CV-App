using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MSE.CVApp.Business.Interfaces;
using MSE.CVApp.DTO.DTOs.CertificationDTOs;
using MSE.CVApp.Entities.Concrete;
using System.Collections.Generic;

namespace MSE.CVApp.Web.ViewComponents
{
    public class CertificationComponent : ViewComponent
    {
        private readonly IGenericService<Certification> _genericService;
        private readonly IMapper _mapper;

        public CertificationComponent(IGenericService<Certification> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<CertificationListDTO>>(_genericService.GetAll()));
        }
    }
}
