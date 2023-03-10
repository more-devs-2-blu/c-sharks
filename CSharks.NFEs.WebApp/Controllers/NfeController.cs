using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class NfeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
