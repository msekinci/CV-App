using MSE.CVApp.DTO.Interfaces;

namespace MSE.CVApp.DTO.DTOs.AppUserDTOs
{
    public class AppUserPasswordDTO : IDTO
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}