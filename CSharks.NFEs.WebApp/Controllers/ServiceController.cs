using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class ServiceController : Controller
    {
        private readonly ICategoriesRepository _categoryRepo;
        private readonly IServicesRepository _serviceRepo; 

        public ServiceController(
            ICategoriesRepository categoriesRepository,
            IServicesRepository servicesRepository)
        {
            _categoryRepo = categoriesRepository;
            _serviceRepo = servicesRepository;
        }
        public IActionResult Index()
        {

            List<Category> categories = _categoryRepo.GetAll().ToList();
            ViewBag.categories = categories;
            return View("~/Views/Register/Services/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Create(Service service)
        {
            if (ModelState.IsValid)
            {
                _serviceRepo.Save(service); 
                TempData["Success"] = "Salvo com sucesso";
                return RedirectToAction("Index");
            }
            else
            {
                return View("~/Views/Register/Services/Index.cshtml");
            }


            return View("~/Views/Register/Services/Index.cshtml");
        }
    }
}
