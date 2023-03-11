using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Services.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            //recive list of categories to display
            //  List<users> users = _requestMySql and pass it on parameters
            return View("~/Views/Register/Users/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                //save the category on database _saveOnDataBase (category) 
                TempData["Success"] = "Salvo com sucesso";
            } else
            {
                return View("~/Views/Register/Users/Index.cshtml");
            }


            return View("~/Views/Register/Users/Index.cshtml");
        }
    }
}
