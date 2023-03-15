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
        private readonly IWebHostEnvironment _environment;
        private readonly IEmitedNfRepository _emitedRepo;

        public EmmitNFController(IServicesRepository serviceRepo, IClientRepository clientRepo, ISessionService session, IApiClientService serviceApi, IWebHostEnvironment environment, IEmitedNfRepository emitedRepo)
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
            ViewBag.services = _serviceRepo.GetAll().ToList();
            ViewBag.clients = _clientRepo.GetAll().ToList();
            return View("~/Views/EmmitNf/Index.cshtml");
        }
        [HttpPost]
        public async Task<IActionResult> EmmitNF(SendNFDTO dto)
        { 
            if (ModelState.IsValid)
            {

                Client client = await _clientRepo.GetById(dto.ClientId); //tomador
                Service service = await _serviceRepo.GetById(dto.ServiceId); //item - service-
                User user = _session.GetSession(); // user will be converted to 'prestador'


                NFEDTO nfe = new NFEDTO(
                    user, client, service, dto.ValueNF
                    );

                string dateNow = DateTime.Now.ToString("yy-MM-dd-HH-mm");
                string xmlFile = _serviceApi.GetFile(nfe);
                string xmlFileName = $"{dateNow}.xml";
                string xmlFilePath = Path.Combine(_environment.WebRootPath, "files", xmlFileName);

                EmitedNF emited = await _serviceApi.EmitNF(xmlFile, xmlFilePath);
                
                EmitedNF emitedDao = new EmitedNF();

                if (emited.Situation != null)
                {
                    emitedDao.EmitDate = dateNow;
                    emitedDao.ServiceName = service.descritivo;
                    emitedDao.ClientName = client.Name;
                    emitedDao.ValueNF = dto.ValueNF;
                    emitedDao.Situation = emited.Situation;
                    await _emitedRepo.Save(emitedDao);
                    TempData["Success"] = "Nota emitida com sucesso";
                }


            }




            ViewBag.services = _serviceRepo.GetAll().ToList();
            ViewBag.clients = _clientRepo.GetAll().ToList();
            return View("~/Views/EmmitNf/Index.cshtml");
        }
    }
}
