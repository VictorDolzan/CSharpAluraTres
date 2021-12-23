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

            Funcionario carlos = new Funcionario(2000, "546.879.157-20");
            carlos.NomeFunc = "Carlos";            
            

            carlos.AumentarSalario();
            Console.WriteLine("Novo salário do carlos " + carlos.SalarioFunc);

            Console.WriteLine("O Total de Funcionários é: " + Funcionario.TotalDeFuncionarios);

            gerenciadorBonif.Registrar(carlos);

            Diretor roberta = new Diretor(5000, "454.658.148-3");
            roberta.NomeFunc = "Roberta";            

            roberta.AumentarSalario();
            Console.WriteLine("Novo salário de Roberta: " + roberta.SalarioFunc);
           
            Console.WriteLine("O Total de Funcionários é: " + Funcionario.TotalDeFuncionarios);

            gerenciadorBonif.Registrar(roberta);

            Gerente pedro = new Gerente(4000, "149.600.547-36");
            pedro.NomeFunc = "Pedro";
            ;

            pedro.AumentarSalario();
            Console.WriteLine("O Novo salário do Pedro é: " + pedro.SalarioFunc);

            Console.WriteLine("O Total de Funcionários é: " + Funcionario.TotalDeFuncionarios);

            gerenciadorBonif.Registrar(pedro);

            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificação de uma referência de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referência de Funcionario: " + robertaTeste.GetBonificacao());
            Console.WriteLine("Bonificação de uma referência de Gerente: " + pedro.GetBonificacao());
            


            Console.WriteLine(carlos.NomeFunc);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.NomeFunc);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine(pedro.NomeFunc);
            Console.WriteLine(pedro.GetBonificacao());

            Console.WriteLine("Total de bonificações: "+ gerenciadorBonif.GetTotalBonificacao());
        }
    }
}
