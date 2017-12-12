using System;
using System.Collections.Generic;
using Xperiments.DesignPatterns.Builder.Models;

namespace Xperiments.DesignPatterns.Builder
{

    public class NotaFiscalBuilder
    {   
        public NotaFiscalBuilder()
        {
            this.Itens = new List<ItemNotaFiscal>();
        }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public double ValorTotal { get; set; }
        public double Impostos { get; set; }
        public IList<ItemNotaFiscal> Itens {get; set;}
        public string Observacoes { get; set; }

        public DateTime DataEmissaoNotaFiscal { get; private set; }
        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCNPJ(string cnpj)
        {
            this.CNPJ = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacao)
        {
            this.Observacoes = observacao;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.DataEmissaoNotaFiscal = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemNotaFiscal item)
        {
            this.Itens.Add(item);
            this.ValorTotal += item.Valor;
            this.Impostos = this.ValorTotal * 0.05;
            return this;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal( RazaoSocial, CNPJ, DataEmissaoNotaFiscal, ValorTotal, Impostos, Itens, Observacoes);
        }
    }

}