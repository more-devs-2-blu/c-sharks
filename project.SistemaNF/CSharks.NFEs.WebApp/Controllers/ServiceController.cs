using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Domain.Models.NF_UTILS;
using CSharks.NFEs.Infra.Data.Repositories;
using CSharks.NFEs.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServicesRepository _serviceRepo;
        private readonly IIsqnRepository _isqnRepo;
        private readonly ICacheMemory _memoryCache;
        private readonly ISessionService _sessionService;


        public ServiceController(
            IServicesRepository servicesRepository, IIsqnRepository isqnRepository, ICacheMemory cacheMemory, ISessionService sessionService)
        {
            _serviceRepo = servicesRepository;
            _isqnRepo = isqnRepository;
            _memoryCache = cacheMemory;
            _sessionService = sessionService;
        }
        public IActionResult Index()
        {
            ViewBag.isqns = GetISQNS();
            ViewBag.enterpise = _sessionService.GetSession();
            return PartialView("~/Views/Register/Services/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Create(Service service)
        {
            service.tributa_municipio_prestador = service.tributa_municipio_prestador == "true" ? "1" : "0";

            ViewBag.isqns = GetISQNS();
            if (ModelState.IsValid)
            {
                _serviceRepo.Save(service); 
                TempData["Success"] = "Salvo com sucesso";
                return RedirectToAction("Index", "Registrations");
            }

            return RedirectToAction("Index", "Registrations");
        }

        private List<ISQN> GetISQNS()
        {
            List<ISQN> isqns = _memoryCache.Get<List<ISQN>>("ISQN_LIST");

            if (isqns == null)
            {
                isqns = _isqnRepo.GetAll().ToList();
                _memoryCache.Set("ISQN_LIST", isqns, TimeSpan.FromMinutes(45));
            }

            return isqns;
        }
    }
}
