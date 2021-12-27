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
        public string SenhaDiretor { get; set; }
        public Diretor(string cpf) : base(5000, cpf)
        {
        
        }
        public bool Autenticar(string senha)
        {
            return this.SenhaDiretor == senha;           
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