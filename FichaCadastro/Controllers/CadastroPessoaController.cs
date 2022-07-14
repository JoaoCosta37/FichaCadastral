using FichaCadastro.Models;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using System.Linq;

namespace FichaCadastro.Controllers
{
    public class CadastroPessoaController : Controller
    {
        private readonly ISessionFactory sessionFactory;

        public CadastroPessoaController(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory;
        }
        public IActionResult Index()
        {
            var session = sessionFactory.OpenSession();

            var query = session.Get<SituacaoEmprego>(1);



           var situacoes = query;

            return View();
        }
    }
}
