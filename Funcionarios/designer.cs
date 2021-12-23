using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CSharpAluraTresByteBank.Funcionarios
{
    class Designer : Funcionario
    {
        public Designer(string cpf) : base(3000, cpf)
        {
            
        }
        public override void AumentarSalario()
        {
            SalarioFunc *= 1.11;
        }
        public override double GetBonificacao()
        {
            return SalarioFunc * 0.17;
        }
    }

}