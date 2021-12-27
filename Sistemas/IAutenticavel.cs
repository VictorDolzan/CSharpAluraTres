using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;
using CSharpAluraTresByteBank.Funcionarios;


namespace CSharpAluraTresByteBank.Sistemas
{
    public interface IAutenticavel 
    {        
       bool Autenticar(string senha);
    }
}