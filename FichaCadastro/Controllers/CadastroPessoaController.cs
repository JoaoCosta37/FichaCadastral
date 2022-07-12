using Microsoft.AspNetCore.Mvc;
 

namespace FichaCadastro.Controllers
{
    public class CadastroPessoaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
