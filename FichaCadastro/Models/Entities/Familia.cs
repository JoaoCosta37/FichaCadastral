﻿namespace FichaCadastro.Models.Entities
{
    public class Familia
    {
        public virtual int Id { get; set; }

        public virtual Pessoa Responsavel { get; set; }

        public virtual int QuantidadeMoradores { get; set; }

        public virtual int QuantidadeCriancas { get; set; }

        public virtual int QuantidadeTrabalhadores { get; set; }

        public virtual string Cep { get; set; }

        public virtual string Logradouro { get; set; }

        public virtual int NumeroEndereco { get; set; }

        public virtual string Bairro { get; set; }

        public virtual string Municipio { get; set; }

        public virtual string PontoReferencia { get; set; }

        public virtual string Complemento { get; set; }

        public virtual bool ResidenciaPropria { get; set; }

        public virtual bool EstaRecebendoCestaBasica { get; set; }

        public virtual decimal Renda { get; set; }
        public virtual string RelatoVida { get; set; }



    }
}
