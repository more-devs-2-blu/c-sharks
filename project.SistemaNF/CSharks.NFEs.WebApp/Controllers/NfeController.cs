using CSharks.NFEs.Domain.DTOs;
using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Domain.Models.NF;
using CSharks.NFEs.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class NfeController : Controller
    {
        private readonly IServicesRepository _serviceRepo;
        private readonly IClientRepository _clientRepo;
        private readonly IApiClientService _serviceApi;

        public NfeController(IServicesRepository serviceRepo, IClientRepository clientRepo, IApiClientService serviceApi)
        {
            _serviceRepo = serviceRepo;
            _clientRepo = clientRepo;   
            _serviceApi = serviceApi;
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

        private NFEDTO MapNF(NFE nfse, Enterprise enterprise, Client client, Service service)
        {
            NFEDTO nfe = new NFEDTO();
            nfe.Identificador = nfse.Identificador;
            nfe.Nf = new Domain.DTOs.NF()
            {
                ValorTotal = "1,00"
            };
            nfe.Prestador = new Domain.DTOs.Prestador(enterprise);
            nfe.Tomador = new Domain.DTOs.Tomador(client);
            lista item = new Domain.DTOs.lista(service);           
            nfe.Itens = new List<lista>
            {
                item
            };

            return nfe;
        }

    }
}
