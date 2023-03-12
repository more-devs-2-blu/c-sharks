using CSharks.NFEs.Domain.Interfaces.Repositories.NF_UTILS;
using CSharks.NFEs.Domain.Models.NF;
using Microsoft.AspNetCore.Mvc;

namespace CSharks.NFEs.WebApp.Controllers
{
    public class NfeController : Controller
    {
        private readonly IListaRepository _listaRepo;
        private readonly IPesquisaRepository _pesquisaRepo;
        private readonly INFRepository _NFRepo;
        private readonly ITomadorRepository _tomadorRepo;
        private readonly IPrestadorRepository _prestadorRepo;

        public NfeController(IListaRepository listaRepo, IPesquisaRepository pesquisaRepo, INFRepository nFRepo, ITomadorRepository tomadorRepo, IPrestadorRepository prestadorRepo)
        {
            _listaRepo = listaRepo;
            _pesquisaRepo = pesquisaRepo;
            _NFRepo = nFRepo;
            _tomadorRepo = tomadorRepo;
            _prestadorRepo = prestadorRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListaRegistering()
        {
            return View("~/Views/Nfe/RegisterNF/ListaNF.cshtml");
        }

        [HttpPost]
        public IActionResult CreateLista(Lista lista)
        {
            if (ModelState.IsValid)
            {
                _listaRepo.Save(lista);
                TempData["Success"] = "Salvo com sucesso";
            }
            else
            {
                //do something here
                //can return with temp data error or warning
                //return View("~/Views/Nfe/RegisterNF/ListaNF.cshtml");
            }


            return View("~/Views/Nfe/RegisterNF/ListaNF.cshtml");
        }

        public IActionResult PesquisaRegistering()
        {
            return View("~/Views/Nfe/RegisterNF/PesquisaNF.cshtml");
        }

        [HttpPost]
        public IActionResult CreatePesquisa(Pesquisa pesquisa)
        {
            if (ModelState.IsValid)
            {
                _pesquisaRepo.Save(pesquisa);
                TempData["Success"] = "Salvo com sucesso";
            }
            else
            {
                //do something here
                //can return with temp data error or warning
                //return View("~/Views/Nfe/RegisterNF/ListaNF.cshtml");
            }


            return View("~/Views/Nfe/RegisterNF/PesquisaNF.cshtml");
        }

        public IActionResult NFRegistering()
        {
            return View("~/Views/Nfe/RegisterNF/NF.cshtml");
        }

        [HttpPost]
        public IActionResult CreateNF(NF nf)
        {
            if (ModelState.IsValid)
            {
                _NFRepo.Save(nf);
                TempData["Success"] = "Salvo com sucesso";
            }
            else
            {
                //do something here
                //can return with temp data error or warning
                //return View("~/Views/Nfe/RegisterNF/ListaNF.cshtml");
            }


            return View("~/Views/Nfe/RegisterNF/NF.cshtml");
        }

        public IActionResult TomadorRegistering()
        {
            return View("~/Views/Nfe/RegisterNF/TomadorNF.cshtml");
        }

        [HttpPost]
        public IActionResult CreateTomador(Tomador tomador)
        {
            if (ModelState.IsValid)
            {
                _tomadorRepo.Save(tomador);
                TempData["Success"] = "Salvo com sucesso";
            }
            else
            {
                //do something here
                //can return with temp data error or warning
                //return View("~/Views/Nfe/RegisterNF/ListaNF.cshtml");
            }


            return View("~/Views/Nfe/RegisterNF/TomadorNF.cshtml");
        }

        public IActionResult PrestadorRegistering()
        {
            return View("~/Views/Nfe/RegisterNF/PrestadorNF.cshtml");
        }

        [HttpPost]
        public IActionResult CreatePrestador(Prestador prestador)
        {
            if (ModelState.IsValid)
            {
                _prestadorRepo.Save(prestador);
                TempData["Success"] = "Salvo com sucesso";
            }
            else
            {
                //do something here
                //can return with temp data error or warning
                //return View("~/Views/Nfe/RegisterNF/ListaNF.cshtml");
            }


            return View("~/Views/Nfe/RegisterNF/PrestadorNF.cshtml");
        }

        public IActionResult ListNFE()
        {
            return View("~/Views/Nfe/ListNF.cshtml");
        }
        public IActionResult EmitNFE()
        {
            ViewBag.listas = _listaRepo.GetAll().ToList();
            ViewBag.pesquisas = _pesquisaRepo.GetAll().ToList();
            ViewBag.NFS = _NFRepo.GetAll().ToList();
            ViewBag.tomadores = _tomadorRepo.GetAll().ToList();
            ViewBag.prestadores = _prestadorRepo.GetAll().ToList();
            return View("~/Views/Nfe/EmitNF.cshtml");
        }

    }
}
