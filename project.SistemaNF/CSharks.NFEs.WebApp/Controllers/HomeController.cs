using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISessionService _session;
        private readonly IEmitedNfRepository _emitedRepo;

        public HomeController(ISessionService  session, IEmitedNfRepository emitedNfRepository)
        {
            _session = session;
            _emitedRepo= emitedNfRepository;
        }


        public IActionResult Index()
        { 
            List<EmitedNF> emiteds = _emitedRepo.GetAll().ToList();
            TempData["EmitQuantity"] = emiteds.Count > 0 ? emiteds.Count : "0";
            TempData["EmitCanceled"] = emiteds.Count(e => e.Situation == "Cancel") > 0 ? emiteds.Count(e => e.Situation == "Cancel") : "0";
            double valueCounter = 0; 
            foreach (EmitedNF emited in emiteds)
            {
                valueCounter += Double.Parse(emited.ValueNF); 
            }
            TempData["TotalValue"] = valueCounter.ToString();
            ViewBag.ListRecents = _emitedRepo.GetAll().OrderByDescending(e => e.EmitDate).Take(10).ToList(); 
            return View();
        }



        public IActionResult GetMenuBar()
        {
            TempData["NameUserLogged"] = _session.GetSession().Name;
            return PartialView("~/Views/Shared/_MenuBar.cshtml");
        }
    }
}