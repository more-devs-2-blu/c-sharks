using CSharks.NFEs.Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using CSharks.NFEs.Domain.Models;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InputValidate(LoginDTO credentials)
        {
            if (ModelState.IsValid)
            {
                User user = new User();
                if (user.InputValidation(credentials.Login, credentials.Password))
                {
                    return View("~/Views/Home/Index.cshtml");
                }

                TempData["Error"] = "Senha ou usuário inválidos"; 
                return View("Index");

            }
            
            return View("Index");
            

        }
    }
}
