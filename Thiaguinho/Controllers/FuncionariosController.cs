using Microsoft.AspNetCore.Mvc;

namespace Thiaguinho.Controllers
{
    public class FuncionariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
