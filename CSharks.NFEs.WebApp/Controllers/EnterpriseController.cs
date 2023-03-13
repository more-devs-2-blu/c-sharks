using CSharks.NFEs.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Services.Helpers;
using CSharks.NFEs.Services.Interfaces;
using System.Data.Entity.Core.Objects;

namespace CSharks.NFEs.WebApp.Controllers
{
   
    public class EnterpriseController : Controller
    {
        private readonly IEnterpriseRepository _enterpriseRepo;
        private readonly IUserRepository _userRepo;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _email; 

        public EnterpriseController(
            IEnterpriseRepository enterprise, IUserRepository userRepo, IConfiguration configuration, IEmailService email)
        {
            _enterpriseRepo = enterprise;
            _userRepo = userRepo;
            _configuration = configuration;
            _email = email;    
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
                user.Email = enterprise.Email;
                if (SendEmail(user.Email, user.Login, StringCodec.DecodeFromBase64(user.Password)))
                {
                    _userRepo.Save(user);
                    _enterpriseRepo.Save(enterprise);
                    TempData["Success"] = $"Empresa cadastrada com sucesso, um email foi enviado para {user.Email}.";
                    return View("~/Views/Login/Index.cshtml");
                } else
                {
                    TempData["Warning"] = "Este não é um email de empresa válido. Por favor, tente novamente. ";
                    return RedirectToAction("Index", "Enterprise");
                }
            }

            return View("~/Views/Register/Enterprises/Index.cshtml");
        }

        public bool SendEmail(string email, string login, string pass)
        {
            Email objEmail = new Email();

            //email config
            objEmail.Host = _configuration.GetValue<string>("EmailConf:Host")!;
            objEmail.Display = _configuration.GetValue<string>("EmailConf:Nome")!;
            objEmail.Username = _configuration.GetValue<string>("EmailConf:Username")!;
            objEmail.Password = _configuration.GetValue<string>("EmailConf:Senha")!;
            objEmail.Port = _configuration.GetValue<int>("EmailConf:Porta")!;

            //data message
            objEmail.Clients = email;
            objEmail.Subject = "CSHARKS - Cadastro de empresa";
            objEmail.Message = $"Você foi cadastrado com sucesso em nosso sistema \r\n Login: {login} \r\n Senha: {pass} \r\n "; 
            
            return _email.SendEmail(objEmail);
        }
    }
}
