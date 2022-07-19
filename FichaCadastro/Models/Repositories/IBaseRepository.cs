using System.Collections.Generic;

namespace FichaCadastro.Models.Repositories
{
    public interface IBaseRepository<T>
    {
        List<T> GetAll();
    }
}
