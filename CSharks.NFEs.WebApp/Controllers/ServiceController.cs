using CSharks.NFEs.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            //recive list of services to display
            //  List<services> services = _requestMySql and pass it on parameters
            return View("~/Views/Register/Services/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Create(Service service)
        {
            if (ModelState.IsValid)
            {
                //save the service on database _saveOnDataBase (service) 
                TempData["Success"] = "Salvo com sucesso";
            }
            else
            {
                return View("~/Views/Register/Services/Index.cshtml");
            }


            return View("~/Views/Register/Services/Index.cshtml");
        }
    }
}
