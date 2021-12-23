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
        public Diretor(string cpf) : base(5000, cpf)
        {
          
        }

        public override void AumentarSalario()
        {
            SalarioFunc *= 1.15;
        }
        public override double GetBonificacao()
        {         
          return SalarioFunc * 0.5;
        } 
    }
}