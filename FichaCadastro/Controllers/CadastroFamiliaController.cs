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

        public CadastroFamiliaController(IFamiliaRepository familiaRepository)
        {
            this.familiaRepository = familiaRepository;
        }
        public IActionResult Index()
        {
           var familias =  familiaRepository.GetAll();
            return View();
        }

        public IActionResult Inserir()
        {
            return View();
        }

    }
}
