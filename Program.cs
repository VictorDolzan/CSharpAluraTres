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

            Funcionario carlos = new Funcionario("546.879.157-20");

            carlos.NomeFunc = "Carlos";            
            carlos.SalarioFunc = 2000;

            Console.WriteLine("O Total de Funcionários é: " + Funcionario.TotalDeFuncionarios);

            gerenciadorBonif.Registrar(carlos);

            Diretor roberta = new Diretor("454.658.148-3");
            roberta.NomeFunc = "Roberta";
            roberta.SalarioFunc = 5000;

            Console.WriteLine("O Total de Funcionários é: " + Funcionario.TotalDeFuncionarios);

            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificação de uma referência de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referência de Funcionario: " + robertaTeste.GetBonificacao());

            gerenciadorBonif.Registrar(roberta);


            Console.WriteLine(carlos.NomeFunc);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.NomeFunc);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: "+ gerenciadorBonif.GetTotalBonificacao());
        }
    }
}
