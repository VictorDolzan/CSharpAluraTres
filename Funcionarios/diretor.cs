using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CSharpAluraTresByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf)
        {
          Console.WriteLine("Criando DIRETOR");
        }
        public override double GetBonificacao()
        {         
          return SalarioFunc + base.GetBonificacao();
        } 
    }
}