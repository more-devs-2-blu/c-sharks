using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Infra.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServicesRepository _serviceRepo;
        private readonly IIsqnRepository _isqnRepo;

        public ServiceController(
            IServicesRepository servicesRepository, IIsqnRepository isqnRepository)
        {
            _serviceRepo = servicesRepository;
            _isqnRepo = isqnRepository;
        }
        public IActionResult Index()
        {
            //ViewBag.services = _serviceRepo.GetAll().ToList();
            ViewBag.services = _isqnRepo.GetAll().ToList();
            return View("~/Views/Register/Services/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Create(Service service)
        {
            if (ModelState.IsValid)
            {
                _serviceRepo.Save(service); 
                TempData["Success"] = "Salvo com sucesso";
                return View("Index");
            }
            else
            {
                return View("~/Views/Register/Services/Index.cshtml");
            }


            return View("~/Views/Register/Services/Index.cshtml");
        }
    }
}
