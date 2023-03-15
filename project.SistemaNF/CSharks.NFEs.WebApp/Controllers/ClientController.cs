using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Services.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class ClientController : Controller
    {

        private readonly IClientRepository _clientRepo;

        public ClientController(IClientRepository clientRepo)
        {
            _clientRepo = clientRepo;
        }

        public IActionResult Index()
        {
            //recive list of clients to display
            //  List<clients> clients = _requestMySql and pass it on parameters
            return PartialView("~/Views/Register/Clients/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Create(Client client)
        {
            
            if (ModelState.IsValid)
            {
                client.CpfCnpj = client.CpfCnpj.Replace(".", "").Replace("/", "").Replace("-", "");
                client.Ie = client.Ie.Replace(".", "").Replace("/", "");
                _clientRepo.Save(client);
                TempData["Success"] = "Salvo com sucesso";
            }
            else
            {
                return RedirectToAction("Index", "Registrations");
            }


            return RedirectToAction("Index", "Registrations");
        }
    }
}
