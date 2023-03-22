using Microsoft.AspNetCore.Mvc;

namespace Webapp_tarde.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

    }
}
