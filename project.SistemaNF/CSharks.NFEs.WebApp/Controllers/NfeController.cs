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

    }
}
