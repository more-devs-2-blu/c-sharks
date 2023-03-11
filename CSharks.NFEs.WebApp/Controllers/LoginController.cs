using CSharks.NFEs.Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Services.Helpers;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class LoginController : Controller
    {

        private readonly IUserRepository _userRepo;

        public LoginController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InputValidate(LoginDTO credentials)
        {
            if (ModelState.IsValid)
            {
                User user = _userRepo.GetByLogin(credentials.Login);
                if (user != null)
                {
                    string passEncoded = StringCodec.EncodeToBase64(credentials.Password);
                    if (user.InputValidation(passEncoded))
                    {
                        return View("~/Views/Home/Index.cshtml");
                    }

                    TempData["Error"] = "Senha inválida";
                    return View("Index");
                } else
                {
                    TempData["Error"] = "Usuário não existe";
                    return View("Index");
                }

            }
            
            return View("Index");
            

        }
    }
}
