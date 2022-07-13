using FichaCadastro.Models;
using NHibernate.Mapping;
using NHibernate.Mapping.ByCode.Conformist;

namespace FichaCadastro.Mappers
{
    public class SituacaoEmpregoMapping : ClassMapping<SituacaoEmprego>
    {
        public SituacaoEmpregoMapping()
        {
            Table("T_ST_EMPREGO");

            Id(x => x.IdSituacao,
               map => map.Column("ID_ST_EMPREGO"));

            Property(x => x.Descricao,
                map => map.Column("DC_ST_EMPREGO"));


        }
    }
}
