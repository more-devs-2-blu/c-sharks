using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}