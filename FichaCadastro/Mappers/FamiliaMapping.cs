﻿using FichaCadastro.Models.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace FichaCadastro.Mappers
{
    public class FamiliaMapping : ClassMapping<Familia>
    {
        public FamiliaMapping() 
        {
          Table("T_FAMILIA");

            Id(x => x.Id,
                  map => map.Column("ID_FAMILIA"));

            Property(x => x.IdResponsavel,
            map => map.Column("ID_RESPONSAVEL"));

            Property(x => x.QuantidadeMoradores,
            map => map.Column("QTD_MORADORES"));

            Property(x => x.QuantidadeCriancas,
            map => map.Column("QTD_CRIANCAS"));


            Property(x => x.QuantidadeTrabalhadores,
            map => map.Column("QTD_EMPREGADOS"));


            Property(x => x.Cep,
            map => map.Column("END_CEP_FAMILIA"));

            Property(x => x.Logradouro,
            map => map.Column("END_DC_FAMILIA"));

            Property(x => x.NumeroEndereco,
            map => map.Column("END_NUMERO"));

            Property(x => x.Bairro,
            map => map.Column("END_BAIRRO_FAMILIA"));

            Property(x => x.Municipio,
            map => map.Column("END_MUNICIPIO"));

            Property(x => x.PontoReferencia,
            map => map.Column("END_PONTO_REF"));

            Property(x => x.Complemento,
            map => map.Column("END_COMPLEMENTO_FAMILIA"));

            Property(x => x.ResidenciaPropria,
            map => map.Column("FL_RESIDENCIA_PROPRIA"));

            Property(x => x.EstaRecebendoCestaBasica,
            map => map.Column("FL_CESTA_BASICA"));

            Property(x => x.RelatoVida,
            map => map.Column("RELATO_VIDA"));

            Property(x => x.Renda,
            map => map.Column("VL_RENDA"));

        }
    }
}
