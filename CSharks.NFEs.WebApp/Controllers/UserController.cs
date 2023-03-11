using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepo; 
        public UserController(IUserRepository userRepository){

            _userRepo = userRepository;

        }
        public IActionResult Index()
        {

            return View("~/Views/Register/Users/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                
                _userRepo.Save(user);
                TempData["Success"] = "Salvo com sucesso";
            } else
            {
                return View("~/Views/Register/Users/Index.cshtml");
            }


            return View("~/Views/Register/Users/Index.cshtml");
        }
    }
}
