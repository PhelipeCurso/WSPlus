using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;
using WSPlus.DATA.Models;
using WSPlus.DATA.Services;

namespace WSPlus.WEB.Controllers
{
    public class EmpresaController : Controller
    {
        private EmpresaService oEmpresaService = new EmpresaService();
        public IActionResult Index()
        {
            List<Empresa> oListEmpresa = oEmpresaService.oRepositoryEmpresa.SelecionarTodos();
            return View(oListEmpresa);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Empresa model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            oEmpresaService.oRepositoryEmpresa.Incluir(model);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Empresa oListEmpresa = oEmpresaService.oRepositoryEmpresa.SelecionarPk(id);
            return View(oListEmpresa);
        }

        public IActionResult Edit(int id)
        {
           Empresa oListEmpresa = oEmpresaService.oRepositoryEmpresa.SelecionarPk(id);
            return View(oListEmpresa);
        }
    }
}
