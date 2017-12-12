using System;
using System.Collections.Generic;

namespace Xperiments.DesignPatterns.Builder.Models
{
    public class NotaFiscal
    {

        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataEmissao, double valorBruto, double valorImposto, IList<ItemNotaFiscal> itens, string observacoes )
        {
            this.RazaoSocial = razaoSocial;
            this.CNPJ = cnpj;
            this.DataEmissao = dataEmissao;
            this.ValorBruto = valorBruto;
            this.ValorImposto = valorImposto;
            this.Itens = itens;
            this.Observacoes = observacoes;
        }
        public string RazaoSocial { get; set; }

         public string CNPJ { get; set; }

        public DateTime DataEmissao { get; set; }

        public double ValorBruto { get; set; }

        public double ValorImposto { get; set; }

        public IList<ItemNotaFiscal> Itens { get; set; }

        public string Observacoes { get; set; }
    }
}
