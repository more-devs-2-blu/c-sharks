using CSharks.NFEs.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InputValidate(User credentials)
        {
            if (true)
            {

                if (credentials.InputValidation(credentials.Login, credentials.Password))
                {
                    return View("~/Views/Home/Index.cshtml");
                }

                TempData["Error"] = "Senha ou usuário inválidos"; 
                return RedirectToAction("Index");

            }
            
            return RedirectToAction("Index");
            

        }
    }
}
