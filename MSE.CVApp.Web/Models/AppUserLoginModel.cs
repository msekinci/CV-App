using System.ComponentModel.DataAnnotations;

namespace MSE.CVApp.Web.Models
{
    public class AppUserLoginModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
