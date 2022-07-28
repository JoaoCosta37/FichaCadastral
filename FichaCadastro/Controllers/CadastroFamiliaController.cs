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


        public IActionResult Editar(int idFamilia)
        {
           var familia = familiaRepository.Get(idFamilia);
           var familiaVm = mapper.Map<FamiliaViewModel>(familia);

            ViewData["situacoesEmprego"] = situacaoEmpregoRepository.GetAll();
            ViewData["estadoCivil"] = estadoCivilRepository.GetAll();

            return View("EditarFamilia",familiaVm);
        }

        public IActionResult Inserir()
        {
            ViewData["situacoesEmprego"] = situacaoEmpregoRepository.GetAll();
            ViewData["estadoCivil"] = estadoCivilRepository.GetAll();

            return View("InserirFamilia");
        }

        public IActionResult Salvar(Familia familia)
        {
            familiaRepository.Salvar(familia);

            return View();
            //complemento
            //logradouro
            //residencia propria
            //sacramentos
            //data de nascimento
            //verificar description do Estado Civil e Situacao emprego
        }

    }
}
