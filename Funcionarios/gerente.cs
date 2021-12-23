using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CSharpAluraTresByteBank.Funcionarios
{
    public class Gerente : Funcionario
    {
        public Gerente(double salario, string cpf) : base(salario, cpf)
        {
            Console.WriteLine("Criando GERENTE");
        }
        public override void AumentarSalario()
        {
            SalarioFunc *= 1.13;
        }
        public override double GetBonificacao()
        {
            return SalarioFunc * 0.20;
        }
    }
}