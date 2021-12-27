using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;
using CSharpAluraTresByteBank.Sistemas;

namespace CSharpAluraTresByteBank.Funcionarios
{
    public class Gerente : FuncionarioAutenticavel
    {
        public Gerente(string cpf) : base(4000, cpf)
        {
            
        }
        public override void AumentarSalario()
        {
            SalarioFunc *= 1.05;
        }
        public override double GetBonificacao()
        {
            return SalarioFunc * 0.25;
        }
    }
}