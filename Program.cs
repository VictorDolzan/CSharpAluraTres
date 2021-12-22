using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;
using CSharpAluraTresByteBank.Funcionarios;


namespace CSharpAluraTresByteBank
{
    class Program
    {
        public static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciadorBonif = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();

            carlos.NomeFunc = "Carlos";
            carlos.CPFFunc = "546.879.157-20";
            carlos.SalarioFunc = 2000;

            gerenciadorBonif.Registrar(carlos);

            Diretor roberta = new Diretor();
            roberta.NomeFunc = "Roberta";
            roberta.CPFFunc = "454.658.148-3";
            roberta.SalarioFunc = 5000;

            gerenciadorBonif.Registrar(roberta);


            Console.WriteLine(carlos.NomeFunc);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.NomeFunc);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: "+ gerenciadorBonif.GetTotalBonificacao());
        }
    }
}
