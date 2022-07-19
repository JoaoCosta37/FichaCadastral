using FichaCadastro.Models.Entities;
using FichaCadastro.Models.Repositories;
using NHibernate;

namespace FichaCadastro.ORM.Repositories
{
    public class FamiliaRepository : BaseRepository<Familia>, IFamiliaRepository
    {
        public FamiliaRepository(ISession session) : base(session)
        {
        }
    }
}
