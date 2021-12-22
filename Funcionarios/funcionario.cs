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
        public string NomeFunc { get; set; }
        public string CPFFunc { get; set; }
        public double SalarioFunc { get; set; }
        public double GetBonificacao()
        {
          return SalarioFunc * 0.10;
        }
    }
}