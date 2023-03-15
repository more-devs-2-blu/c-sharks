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
        private readonly IEmitedNfRepository _emitedRepo;

        public NfeController(IServicesRepository serviceRepo, IClientRepository clientRepo, IApiClientService serviceApi, IEmitedNfRepository emitedRepo)
        {
            _serviceRepo = serviceRepo;
            _clientRepo = clientRepo;
            _serviceApi = serviceApi;
            _emitedRepo = emitedRepo;
        }
        public IActionResult Index()
        {
            ViewBag.ListEmiteds = _emitedRepo.GetAll().ToList();
            return View();
        }

        public IActionResult DownloadAction(string fileName)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", $"{fileName}.xml");

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }

            string fileUrl = Url.Content("~/files/" + $"{fileName}.xml");
            return Json(new { fileUrl = fileUrl });
        }

    }
}