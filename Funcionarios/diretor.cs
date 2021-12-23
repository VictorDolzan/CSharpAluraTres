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
        public override double GetBonificacao()
        {
          return SalarioFunc;
        } 
    }
}