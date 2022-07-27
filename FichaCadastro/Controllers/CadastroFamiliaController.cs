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
        private readonly IEstadoCivilRepository estadoCivilRepository;

        public CadastroFamiliaController(IFamiliaRepository familiaRepository, ISituacaoEmpregoRepository situacaoEmpregoRepository, IEstadoCivilRepository estadoCivilRepository)
        {
            this.familiaRepository = familiaRepository;
            this.situacaoEmpregoRepository = situacaoEmpregoRepository;
            this.estadoCivilRepository = estadoCivilRepository;
        }
        public IActionResult Index()
        {
            ViewData["situacoesEmprego"] = situacaoEmpregoRepository.GetAll();
            ViewData["estadoCivil"] = estadoCivilRepository.GetAll();

            return View();
        }


        public IActionResult Editar(int idFamilia)
        {
           var familia = familiaRepository.Get(idFamilia);
            return View(familia);
        }

        public IActionResult Inserir(Familia familia)
        {
            return View();
        }

    }
}
