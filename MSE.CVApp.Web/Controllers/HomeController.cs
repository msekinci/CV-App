using Microsoft.AspNetCore.Mvc;

namespace MSE.CVApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenericService<>
        public IActionResult Index()
        {
            return View();
        }
    }
}
