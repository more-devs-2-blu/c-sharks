using CSharks.NFEs.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            //recive list of clients to display
            //  List<clients> clients = _requestMySql and pass it on parameters
            return View("~/Views/Register/Clients/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                //save the service on database _saveOnDataBase (client) 
                TempData["Success"] = "Salvo com sucesso";
            }
            else
            {
                return View("~/Views/Register/Clients/Index.cshtml");
            }


            return View("~/Views/Register/Clients/Index.cshtml");
        }
    }
}
