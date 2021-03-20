using MSE.CVApp.DTO.Interfaces;

namespace MSE.CVApp.DTO.DTOs.CertificationDTOs
{
    public class CertificationUpdateDTO : IDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
