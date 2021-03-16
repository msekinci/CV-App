using MSE.CVApp.DTO.Interfaces;

namespace MSE.CVApp.DTO.DTOs.SkillDTOs
{
    public class SkillListDTO : IDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
