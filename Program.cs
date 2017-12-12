using System;
using Xperiments.DesignPatterns.Builder.Models;

namespace Xperiments.DesignPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder builder = new NotaFiscalBuilder();
        
            //Fluent Interface ou  Method Chain
            builder
                .ParaEmpresa("MFY IT")
                .ComCNPJ("123.456.789/0001-01")
                .ComItem(new ItemNotaFiscal("item 1", 100.00 ))
                .ComItem(new ItemNotaFiscal("item 2", 150.30 ))
                .NaDataAtual()
                .ComObservacoes("Teste com object builder");


            NotaFiscal nf = builder.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.ValorImposto);


        }
    }
}
