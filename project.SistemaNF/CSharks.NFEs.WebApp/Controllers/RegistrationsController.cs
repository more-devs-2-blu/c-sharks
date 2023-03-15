using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class RegistrationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RegisterService()
        {
            return View("~/Views/Register/Services/Index.cshtml");
        }

        public IActionResult RegisterUser()
        {
            return View("~/Views/Register/Users/Index.cshtml");
        }

        public IActionResult RegisterClient()
        {
            return View("~/Views/Register/Clients/Index.cshtml");
        }
    }
}
