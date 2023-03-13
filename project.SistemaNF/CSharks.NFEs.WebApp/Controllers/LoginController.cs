using CSharks.NFEs.Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Services.Helpers;
using CSharks.NFEs.Services.Interfaces;
using CSharks.NFEs.WebApp.Services;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class LoginController : Controller
    {

        private readonly IUserRepository _userRepo;
        private readonly ISessionService _session;
        private readonly IEnterpriseRepository _enterpriseRepo;
        public LoginController(IUserRepository userRepo, ISessionService session, IEnterpriseRepository enterpriseRepository)
        {
            _userRepo = userRepo;
            _session = session;
            _enterpriseRepo = enterpriseRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InputValidate(LoginDTO credentials)
        {
            if (ModelState.IsValid)
            {
                Enterprise enterprise = _enterpriseRepo.GetByCnpj(credentials.Cnpj);
                if (enterprise == null) {
                    TempData["Warning"] = "Empresa não cadastrada no sistema";
                } else
                {
                    User user = _userRepo.GetByLogin(credentials.Login);
                    if (user != null)
                    {
                        try
                        {
                            //user.Enterprise!.Id = enterprise.Id;
                            user.EnterpriseId = enterprise.Id;
                            user.Enterprise = enterprise;
                            string passEncoded = StringCodec.EncodeToBase64(credentials.Password);
                            if (user.InputValidation(passEncoded))
                            {
                                _session.CreateSession(user);
                                return RedirectToAction("Index", "Home");
                            }

                            TempData["Error"] = "Senha inválida";
                            return View("Index");
                        }
                        catch (Exception) {
                            TempData["Error"] = "Dados não conferem. "; 
                        }
                    }
                    else
                    {
                        TempData["Error"] = "Usuário não existe";
                        return View("Index");
                    }
                }

                

            }
            
            return View("Index");
            

        }

        public IActionResult Exit()
        {
            _session.RemoveSession();
            TempData["Success"] = "Usuário Deslogado!";
            return RedirectToAction("Index");
        }
    }
}
