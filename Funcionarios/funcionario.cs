using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CSharpAluraTresByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string NomeFunc { get; set; }
        public string CPFFunc { get; private set; }
        public double SalarioFunc { get; protected set; }

        public Funcionario( double salario, string cpf)
        {
          Console.WriteLine("Criando FUNCIONÁRIO");
          CPFFunc = cpf;
          SalarioFunc = salario;
          TotalDeFuncionarios ++;
        }
        public virtual void AumentarSalario()
        {
            // SalarioFunc = SalarioFunc + (SalarioFunc * 0.1);
            // SalarioFunc = SalarioFunc * 1.1;
            SalarioFunc *= 1.1;
        }
        public virtual double GetBonificacao()
        {
          return SalarioFunc * 0.10;
        }
    }
}