using CSharks.NFEs.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Services.Helpers;

namespace CSharks.NFEs.WebApp.Controllers
{
   
    public class EnterpriseController : Controller
    {
        private readonly IEnterpriseRepository _enterpriseRepo;
        private readonly IUserRepository _userRepo;

        public EnterpriseController(
            IEnterpriseRepository enterprise, IUserRepository userRepo)
        {
            _enterpriseRepo = enterprise;
            _userRepo = userRepo;
        }
        public IActionResult Index()
        {
            return View("~/Views/Register/Enterprises/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Create(Enterprise enterprise)
        {
            if (ModelState.IsValid)
            {
                User user = new User();
                user.Login = "master";
                user.Name = "master";
                user.EnterpriseId = enterprise.Id;
                user.Enterprise = enterprise;
                user.Profile = Domain.Enums.TypeProfile.Admin;
                user.Password = StringCodec.EncodeToBase64(user.GeneratePassword());
                _userRepo.Save(user);
                _enterpriseRepo.Save(enterprise);
                TempData["Success"] = "Empresa cadastrada com sucesso!";
                return View("~/Views/Login/Index.cshtml"); 
            }

            return View("~/Views/Register/Enterprises/Index.cshtml");
        }
    }
}
