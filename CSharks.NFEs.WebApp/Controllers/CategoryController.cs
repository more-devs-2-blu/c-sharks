using CSharks.NFEs.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            //recive list of categories 
            //  List<categories> categories = _requestMySql and passit on parameters
            return View("~/Views/Register/Categories/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if(ModelState.IsValid) {
                //save the category on database _saveOnDataBase (category) 
                TempData["Success"] = "Salvo com sucesso";
            }


            return View("~/Views/Register/Categories/Index.cshtml");
        }
        
}
}
