using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_revisada
{
    class ContaPoupanca : ContaBase
    {
        public ContaPoupanca(string numeroConta, string nomeCorrentista): base(numeroConta, nomeCorrentista)
        {

        }

        public override void Sacar(double quantia)
        {
            base.Sacar(quantia);
        }

        public override void Transferir(double quantia, ContaBase contaDestino)
        {
            if (SaldoAtual - (quantia + quantia * 0.15 / 100) >= 0)
            {
                ReduzirSaldo(quantia);
                contaDestino.DepositarSaldo(quantia);
            }
            else
            {
                throw new Exception("Não foi possível realizar a transferência");
            }
        }
    }
}
