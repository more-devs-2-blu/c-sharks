using CSharks.NFEs.Domain.DTOs;
using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class CancelNFController : Controller
    {
        private readonly IServicesRepository _serviceRepo;
        private readonly IClientRepository _clientRepo;
        private readonly ISessionService _session;
        private readonly IApiClientService _serviceApi;
        private readonly IWebHostEnvironment _environment;
        private readonly IEmitedNfRepository _emitedRepo;

        public CancelNFController(IServicesRepository serviceRepo, IClientRepository clientRepo, ISessionService session, IApiClientService serviceApi, IWebHostEnvironment environment, IEmitedNfRepository emitedRepo)
        {
            _serviceRepo = serviceRepo;
            _clientRepo = clientRepo;
            _session = session;
            _serviceApi = serviceApi;
            _environment = environment;
            _emitedRepo = emitedRepo;
        }
        public IActionResult Index()
        {
            return View("~/Views/Nfe/Index.cshtml");
        }
        [HttpPost]
        public async Task<IActionResult> CancelNF(string noNfse)
        { 
            if (ModelState.IsValid)
            {
                NFEDTO nfe = new NFEDTO(noNfse, _session.GetSession());

                string dateNow = DateTime.Now.ToString("yy-MM-dd-HH-mm-ss");
                string xmlFile = _serviceApi.GetFile(nfe);
                string xmlFileName = $"{dateNow}.xml";
                string xmlFilePath = Path.Combine(_environment.WebRootPath, "files", xmlFileName);

                EmitedNF emited = await _serviceApi.CancelNF(xmlFile, xmlFilePath);

                EmitedNF emitedDao = _emitedRepo.GetByNoNfse(noNfse); 

                if (emited.Situation != null)
                {
                    if(emited.Situation.Equals("Already canceled"))
                    {
                        TempData["Warning"] = "Nota já cancelada";
                    }
                    else
                    {
                        emitedDao.Situation = emited.Situation;
                        await _emitedRepo.Update(emitedDao);
                        TempData["Success"] = "Nota emitida com sucesso";
                    }                    
                }
            }

            ViewBag.services = _serviceRepo.GetAll().ToList();
            ViewBag.clients = _clientRepo.GetAll().ToList();
            return View("~/Views/EmmitNf/Index.cshtml");
        }
    }
}
