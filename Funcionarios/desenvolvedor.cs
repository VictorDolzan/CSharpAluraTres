using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CSharpAluraTresByteBank.Funcionarios
{
    class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(3000, cpf)
        {
            
        }
        public override void AumentarSalario()
        {
            SalarioFunc *= 0.15;
        }
        public override double GetBonificacao()
        {
            return SalarioFunc * 0.1;
        }
    }
}