using CSharks.NFEs.Domain.DTOs;
using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class EmmitNFController : Controller
    {
        private readonly IServicesRepository _serviceRepo;
        private readonly IClientRepository _clientRepo;
        private readonly ISessionService _session;
        private readonly IApiClientService _serviceApi;

        public EmmitNFController(IServicesRepository serviceRepo, IClientRepository clientRepo, ISessionService session, IApiClientService serviceApi)
        {
            _serviceRepo = serviceRepo;
            _clientRepo = clientRepo;
            _session = session;
            _serviceApi = serviceApi;
        }
        public IActionResult Index()
        {
            ViewBag.services = _serviceRepo.GetAll().ToList();
            ViewBag.clients = _clientRepo.GetAll().ToList();
            return View("~/Views/EmmitNf/Index.cshtml");
        }
        [HttpPost]
        public IActionResult EmmitNf(Guid idClient, Service service)
        {
            NFE nfse = new NFE();
            Client client = new Client();
            NFEDTO nf = new NFEDTO(nfse, _session.GetSession(), client, service);

            string xmlFile = _serviceApi.GetFile(nf);


            ViewBag.services = _serviceRepo.GetAll().ToList();
            ViewBag.clients = _clientRepo.GetAll().ToList();
            return View("~/Views/EmmitNf/Index.cshtml");
        }
    }
}
