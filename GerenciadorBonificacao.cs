using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;
using CSharpAluraTresByteBank.Funcionarios;


namespace CSharpAluraTresByteBank
{
    public class GerenciadorBonificacao
    {   
        private double _totalBonificacao;
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }
        public void Registrar(Diretor diretor)
        {
            _totalBonificacao += diretor.GetBonificacao();
        }
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}