using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;
using CSharpAluraTresByteBank.Funcionarios;
using CSharpAluraTresByteBank.Sistemas;


namespace CSharpAluraTresByteBank
{
    class Program
    {
        public static void Main(string[] args)
        {
            // GerenciadorBonificacao gerenciadorBonif = new GerenciadorBonificacao();

            // Funcionario carlos = new Funcionario(2000, "546.879.157-20");
            // carlos.NomeFunc = "Carlos";
            // carlos.AumentarSalario();
            // Console.WriteLine("Novo salário do carlos " + carlos.SalarioFunc);
            // Console.WriteLine("O Total de Funcionários é: " + Funcionario.TotalDeFuncionarios);
            // gerenciadorBonif.Registrar(carlos);

            // Diretor roberta = new Diretor(5000, "454.658.148-3");
            // roberta.NomeFunc = "Roberta";
            // roberta.AumentarSalario();
            // Console.WriteLine("Novo salário de Roberta: " + roberta.SalarioFunc);           
            // Console.WriteLine("O Total de Funcionários é: " + Funcionario.TotalDeFuncionarios);
            // gerenciadorBonif.Registrar(roberta);

            // Gerente pedro = new Gerente(4000, "149.600.547-36");
            // pedro.NomeFunc = "Pedro";
            // pedro.AumentarSalario();
            // Console.WriteLine("O Novo salário do Pedro é: " + pedro.SalarioFunc);
            // Console.WriteLine("O Total de Funcionários é: " + Funcionario.TotalDeFuncionarios);
            // gerenciadorBonif.Registrar(pedro);

            // Designer jasmin = new Designer(3000, "632.458.752-65");
            // jasmin.NomeFunc = "Jasmin";
            // jasmin.AumentarSalario();
            // Console.WriteLine($"O nome salário da {jasmin.NomeFunc} é: {jasmin.SalarioFunc} ");
            // Console.WriteLine("O Total de Funcionários é: " + Funcionario.TotalDeFuncionarios);
            // gerenciadorBonif.Registrar(jasmin);

            // Funcionario robertaTeste = roberta;

            // Console.WriteLine("Bonificação de uma referência de Diretor: " + roberta.GetBonificacao());
            // Console.WriteLine("Bonificação de uma referência de Funcionario: " + robertaTeste.GetBonificacao());
            // Console.WriteLine("Bonificação de uma referência de Gerente: " + pedro.GetBonificacao());
            // Console.WriteLine("Bonificação de uma referência de Designer: " + jasmin.GetBonificacao());


            // Console.WriteLine(carlos.NomeFunc);
            // Console.WriteLine(carlos.GetBonificacao());

            // Console.WriteLine(roberta.NomeFunc);
            // Console.WriteLine(roberta.GetBonificacao());

            // Console.WriteLine(pedro.NomeFunc);
            // Console.WriteLine(pedro.GetBonificacao());

            // Console.WriteLine(jasmin.NomeFunc);
            // Console.WriteLine(jasmin.GetBonificacao());


            // Console.WriteLine("Total de bonificações: "+ gerenciadorBonif.GetTotalBonificacao());
            //CalcularBonificacao();  

            UsarSistema();         

        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.NomeFunc = "Roberta";
            roberta.SenhaFunc = "123";

            Gerente camila = new Gerente("326.985.658-89");
            camila.NomeFunc = "Camila";
            camila.SenhaFunc = "abc";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");


        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("833.222.048-39");
            pedro.NomeFunc = "Pedro";

            Funcionario roberta = new Diretor("159.753.398-04");
            roberta.NomeFunc = "Roberta";

            Funcionario igor = new Auxiliar("981.198.778-53");
            igor.NomeFunc = "Igor";

            Funcionario victor = new Gerente("149.600.547-35");
            victor.NomeFunc = "Victor";

            Funcionario jasmin = new Desenvolvedor("145.633.568-35");
            jasmin.NomeFunc = "Jasmin";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(victor);
            gerenciadorBonificacao.Registrar(jasmin);


            Console.WriteLine("Total de bonificações do mês: " +
            gerenciadorBonificacao.GetTotalBonificacao());                   

        }
    }
}
