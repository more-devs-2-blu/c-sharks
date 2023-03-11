using CSharks.NFEs.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISessionService _session;

        public HomeController(ISessionService  session)
        {
            _session = session;
        }


        public IActionResult Index()
        {
            TempData["NameUserLogged"] = _session.GetSession().Name;
            return View();
        }
    }
}