using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class TextCommandsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
