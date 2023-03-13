using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoriesRepository _categoryRepo;

        public CategoryController(ICategoriesRepository categoriesRepository)
        {
            _categoryRepo = categoriesRepository;
        }

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
                _categoryRepo.Save(category);
                TempData["Success"] = "Salvo com sucesso";
                return View("~/Views/Register/Categories/Index.cshtml");
            }


            return View("~/Views/Register/Categories/Index.cshtml");
        }
        
}
}
