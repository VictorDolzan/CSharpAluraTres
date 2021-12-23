using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CSharpAluraTresByteBank.Funcionarios
{
    public class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string NomeFunc { get; set; }
        public string CPFFunc { get; private set; }
        public double SalarioFunc { get; set; }

        public  Funcionario( string cpf)
        {
          Console.WriteLine("Criando FUNCIONÁRIO");
          CPFFunc = cpf;
          TotalDeFuncionarios ++;
        }
        public virtual double GetBonificacao()
        {
          return SalarioFunc * 0.10;
        }
    }
}