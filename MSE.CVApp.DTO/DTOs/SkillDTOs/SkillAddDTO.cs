using MSE.CVApp.DTO.Interfaces;

namespace MSE.CVApp.DTO.DTOs.SkillDTOs
{
    public class SkillAddDTO : IDTO
    {
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
