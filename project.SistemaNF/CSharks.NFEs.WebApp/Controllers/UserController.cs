using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Services.Helpers;
using CSharks.NFEs.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepo;
        private readonly ISessionService _session; 
        public UserController(IUserRepository userRepository, ISessionService session)
        {

            _userRepo = userRepository;
            _session = session;
        }
        public IActionResult Index()
        {

            return PartialView("~/Views/Register/Users/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Create(User user)
        {

            User userRegistering = _session.GetSession();
            user.EnterpriseId = userRegistering.EnterpriseId;
            if (ModelState.IsValid)
            {
                user.Password = StringCodec.EncodeToBase64(user.Password);
                _userRepo.Save(user);
                TempData["Success"] = "Salvo com sucesso";
            } else
            {
                return PartialView("~/Views/Register/Users/Index.cshtml");
            }

                    
            return PartialView("~/Views/Register/Users/Index.cshtml");
        }
    }
}
