using FichaCadastro.Models.Entities;
using FichaCadastro.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using System.Linq;

namespace FichaCadastro.Controllers
{
    public class CadastroFamiliaController : Controller
    {
        private readonly IFamiliaRepository familiaRepository;
        private readonly ISituacaoEmpregoRepository situacaoEmpregoRepository;

        public CadastroFamiliaController(IFamiliaRepository familiaRepository,ISituacaoEmpregoRepository situacaoEmpregoRepository)
        {
            this.familiaRepository = familiaRepository;
            this.situacaoEmpregoRepository = situacaoEmpregoRepository;
        }
        public IActionResult Index()
        {
            // var familias =  familiaRepository.GetAll();
            
            ViewData["situacoesEmprego"] = situacaoEmpregoRepository.GetAll();

            return View();
        }

        public IActionResult Inserir(Familia familia)
        {
            return View();
        }

    }
}
