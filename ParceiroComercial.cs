using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;
using CSharpAluraTresByteBank.Funcionarios;
using CSharpAluraTresByteBank.Sistemas;


namespace CSharpAluraTresByteBank
{
    public class ParceiroComercial : IAutenticavel
    {
        public string SenhaFunc { get; set; }
        public bool Autenticar(string senha)
        {
            return SenhaFunc == senha;
        }
    }
}