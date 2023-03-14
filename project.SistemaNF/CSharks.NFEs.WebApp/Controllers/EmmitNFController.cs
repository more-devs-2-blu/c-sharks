using CSharks.NFEs.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class EmmitNFController : Controller
    {
        private readonly IServicesRepository _serviceRepo;
        private readonly IClientRepository _clientRepo;

        public EmmitNFController(IServicesRepository serviceRepo, IClientRepository clientRepo)
        {
            _serviceRepo = serviceRepo;
            _clientRepo = clientRepo;
        }

        public IActionResult Index()
        {
            ViewBag.services = _serviceRepo.GetAll().ToList();
            ViewBag.clients = _clientRepo.GetAll().ToList();
            return View("~/Views/Nfe/EmitNF.cshtml");
        }
    }
}
