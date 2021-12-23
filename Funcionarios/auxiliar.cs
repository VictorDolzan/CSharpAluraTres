using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CSharpAluraTresByteBank.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {

        }
        public override void AumentarSalario()
        {
            SalarioFunc *= 1.1;
        }
        public override double GetBonificacao()
        {
            return SalarioFunc * 0.2;
        }
    }
}