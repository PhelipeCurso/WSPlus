using Microsoft.AspNetCore.Mvc;
using WSPlus.DATA.Models;
using WSPlus.DATA.Services;
namespace WSPlus.WEB.Controllers
{
    
    public class UsuarioController : Controller
    {
        private UsuarioService oUsuarioService = new UsuarioService();
        public IActionResult Index()
        {
            List<Usuario>oListUsuario = oUsuarioService.oRepositoryUsuario.SelecionarTodos();
            return View(oListUsuario);
        }

        public IActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult Create(Usuario model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            oUsuarioService.oRepositoryUsuario.Incluir(model);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Usuario oUsuario=oUsuarioService.oRepositoryUsuario.SelecionarPk(id);
            return View(oUsuario);
        }

        public IActionResult Edit (int id)
        {
            Usuario oUsuario = oUsuarioService.oRepositoryUsuario.SelecionarPk(id);
            return View(oUsuario);
        }

    }
}
