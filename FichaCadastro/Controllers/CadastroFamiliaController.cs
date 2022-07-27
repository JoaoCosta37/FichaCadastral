using AutoMapper;
using FichaCadastro.Models.Entities;
using FichaCadastro.Models.Repositories;
using FichaCadastro.ViewModel;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using System.Linq;

namespace FichaCadastro.Controllers
{
    public class CadastroFamiliaController : Controller
    {
        private readonly IMapper mapper;
        private readonly IFamiliaRepository familiaRepository;
        private readonly ISituacaoEmpregoRepository situacaoEmpregoRepository;
        private readonly IEstadoCivilRepository estadoCivilRepository;

        public CadastroFamiliaController(IMapper mapper,  IFamiliaRepository familiaRepository, ISituacaoEmpregoRepository situacaoEmpregoRepository, IEstadoCivilRepository estadoCivilRepository)
        {
            this.mapper = mapper;
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
            var familiaVm = mapper.Map<FamiliaViewModel>(familia);

            return View(familiaVm);
        }

        public IActionResult Inserir(Familia familia)
        {
            return View();
        }

    }
}
