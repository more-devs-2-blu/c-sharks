using CSharks.NFEs.Domain.DTOs;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Domain.Models.NF_UTILS;
using CSharks.NFEs.Infra.Data.Repositories;
using CSharks.NFEs.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{

    public class ExcelHandlerController : Controller
    {
        private readonly IExcel _excelService;
        private readonly IIsqnRepository _isqnRepo;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IDataProviderService _dataProviderService;

        public ExcelHandlerController(IExcel excelService, IIsqnRepository isqnRepository, IWebHostEnvironment hostingEnvironment, IDataProviderService dataProvider)
        {
            _dataProviderService = dataProvider;
            _excelService = excelService;
            _isqnRepo = isqnRepository;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ReadDataAndSave()
        {
            if (_isqnRepo.GetAll().Count() > 0)
            {
                TempData["Warning"] = "A tebela de ISQN já está atualizada. Você precisa fazer a limpeza antes.";
                return RedirectToAction("Index", "Registrations");
            }
            string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "files", "isqn.xlsx");
            List<ISQN> isqns = _excelService.ReadISQNFromExcel(filePath);
            if (isqns != null)
            {
                if (await _isqnRepo.SaveAll(isqns))
                {
                    TempData["Success"] = "Importação realizada com sucesso!";
                    return RedirectToAction("Index", "Registrations");
                }
            }
            TempData["Error"] = "Falha ao tentar ler os dados do arquivo excel, certifique-se se o arquivo com extensão isqn.xlsx está no diretório /wwwroot/files.";
            return RedirectToAction("Index", "Registrations");
        }

        public IActionResult DeleteAllISQNData()
        {
            if (_isqnRepo.DeleteAll())
            {

                TempData["Success"] = "Os dados foram limpos com sucesso!";

            } else
            {
                TempData["Error"] = "Não foi possível realizar a limpeza dos dados.";
            }

            return View("~/Views/Home/Index.cshtml");
        }
    
        public IActionResult RegisterAllTOMs()
        {
            List<TOMDTO> listTom = _excelService.ReadTOMFromExcel(Path.Combine(_hostingEnvironment.WebRootPath, "files", "tom.xlsx"));
            _dataProviderService.SendToms(listTom);
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
