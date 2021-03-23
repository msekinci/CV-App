using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace MSE.CVApp.Web.Models
{
    public class AppUserUpdateModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        public string PhoneNumber { get; set; }
        public IFormFile Picture { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string ShortDescription { get; set; }
    }
}
