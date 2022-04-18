using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_revisada
{
    abstract class ContaBase
    {
        string numeroConta;
        string nomeCorrentista;
        double saldoAtual;

        public ContaBase(string numeroConta, string nomeCorrentista)
        {
            this.numeroConta = numeroConta;
            this.nomeCorrentista = nomeCorrentista;
            this.saldoAtual = 0;
        }

        public string NumeroConta
        {
            get
            {
                return numeroConta;
            }
        }

        public string NomeCorrentista
        {
            get
            {
                return nomeCorrentista;
            }
        }

        public double SaldoAtual
        {
            get
            {
                return saldoAtual;
            }
        }

        public virtual void Sacar(double quantia)
        {
            if (SaldoAtual - (quantia + quantia * 0.37 / 100) >= 0)
            {
                ReduzirSaldo(quantia);
            }
            else
            {
                throw new Exception("Não foi possível realizar o saque");
            }
        }
        public virtual void Transferir(double quantia, ContaBase contaDestino)
        {
            if (SaldoAtual - (quantia + quantia * 0.20 / 100) >= 0)
            {
                ReduzirSaldo(quantia);
                contaDestino.DepositarSaldo(quantia);
            }
            else
            {
                throw new Exception("Não foi possível realizar a transferência");
            }
        }

        protected void ReduzirSaldo(double quantia)
        {
            saldoAtual -= quantia;
        }

        protected void AumentarSaldo(double quantia)
        {
            saldoAtual += quantia;
        }

        public double ConsultarSaldo()
        {
            return saldoAtual;
        }

        public void DepositarSaldo(double quantia)
        {
            AumentarSaldo(quantia);
        }

    }
}
