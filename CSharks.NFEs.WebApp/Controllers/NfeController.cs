using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models.NF;
using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class NfeController : Controller
    {
        private readonly IServicesRepository _serviceRepo;
        private readonly IClientRepository _clientRepo;

        public NfeController(IServicesRepository serviceRepo, IClientRepository clientRepo)
        {
            _serviceRepo = serviceRepo;
            _clientRepo = clientRepo;   
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListNFE()
        {
            ViewBag.services = _serviceRepo.GetAll().ToList();
            return View("~/Views/Nfe/ListNF.cshtml");
        }
        public IActionResult EmitNFE()
        {
            ViewBag.services = _serviceRepo.GetAll().ToList();
            ViewBag.clients = _clientRepo.GetAll().ToList();
            return View("~/Views/Nfe/EmitNF.cshtml");
        }

    }
}
