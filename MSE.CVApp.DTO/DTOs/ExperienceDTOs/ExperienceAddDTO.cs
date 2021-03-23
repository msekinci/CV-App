using MSE.CVApp.DTO.Interfaces;
using System;

namespace MSE.CVApp.DTO.DTOs.ExperienceDTOs
{
    public class ExperienceAddDTO : IDTO
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; }
    }
}
