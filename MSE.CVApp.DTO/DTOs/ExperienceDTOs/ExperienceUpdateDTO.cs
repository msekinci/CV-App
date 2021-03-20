using MSE.CVApp.DTO.Interfaces;

namespace MSE.CVApp.DTO.DTOs.ExperienceDTOs
{
    public class ExperienceUpdateDTO : IDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
