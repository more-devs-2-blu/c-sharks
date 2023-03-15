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
            return PartialView("~/Views/Register/Services/_ServicesPartial.cshtml");
        }

        public IActionResult RegisterUser()
        {
            return PartialView("~/Views/Register/Users/_UsersPartial.cshtml");
        }

        public IActionResult RegisterClient()
        {
            return PartialView("~/Views/Register/Clients/_ClientsPartial.cshtml");
        }
    }
}
