using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;
using CSharpAluraTresByteBank.Funcionarios;


namespace CSharpAluraTresByteBank.Sistemas
{
    public abstract class Autenticavel : Funcionario
    {
        public string SenhaFunc { get; set; }

        protected Autenticavel(double salario, string cpf) : base(salario, cpf)
        {

        }
        public bool Autenticar(string senha)
        {
            return SenhaFunc == senha;
        }
    }
}