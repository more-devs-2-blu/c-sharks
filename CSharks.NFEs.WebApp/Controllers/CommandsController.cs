using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class CommandsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
