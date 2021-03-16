using MSE.CVApp.DTO.Interfaces;

namespace MSE.CVApp.DTO.DTOs.InterestDTOs
{
    public class SkillUpdateDTO : IDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
