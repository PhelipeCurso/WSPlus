using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;
using WSPlus.DATA.Models;
using WSPlus.DATA.Services;

namespace WSPlus.WEB.Controllers
{
    public class AtendenteController : Controller
    {
        private  AtendenteService oAtendenteService = new AtendenteService();
        public IActionResult Index()
        {
            List<Atendente> oListAtendente = oAtendenteService.oRepositoryAtendente.SelecionarTodos();
            return View(oListAtendente);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Atendente model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            oAtendenteService.oRepositoryAtendente.Incluir(model);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Atendente oAtendente = oAtendenteService.oRepositoryAtendente.SelecionarPk(id);
            return View(oAtendente);
        }

        public IActionResult Edit(int id)
        {
            Atendente oAtendente = oAtendenteService.oRepositoryAtendente.SelecionarPk(id);
            return View(oAtendente);
        }
    }
}
