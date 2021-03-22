using Microsoft.AspNetCore.Mvc;

namespace MSE.CVApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
