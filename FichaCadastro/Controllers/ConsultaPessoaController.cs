using FichaCadastro.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FichaCadastro.Controllers
{
    public class ConsultaPessoaController : Controller
    {
        private readonly IPessoaRepository pessoaRepository;

        public ConsultaPessoaController(IPessoaRepository pessoaRepository )
        {
            this.pessoaRepository = pessoaRepository;
        }
        public IActionResult Index()
        {
            var pessoas = pessoaRepository.GetAll();

            return View(pessoas);
        }
    }
}
