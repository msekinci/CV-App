using MSE.CVApp.DTO.Interfaces;

namespace MSE.CVApp.DTO.DTOs.AppUserDTOs
{
    public class AppUserUpdateDTO : IDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ShortDescription { get; set; }
        public string ImageUrl { get; set; }
        public string UserName { get; set; }
    }
}
