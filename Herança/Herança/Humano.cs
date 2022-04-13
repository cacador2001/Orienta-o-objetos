using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Humano
    {
        protected String primeiroNome;
        protected String ultimoNome;

        public Humano() { }

        public Humano(string primeiroNome, string ultimoNome)
        {
            this.primeiroNome = primeiroNome;
            this.ultimoNome = ultimoNome;
        }

        public string PrimeiroNome
        {
            get
            {
                return primeiroNome;
            }

            set
            {
                primeiroNome = value;
            }
        }

        public string UltimoNome
        {
            get
            {
                return ultimoNome;
            }

            set
            {
                ultimoNome = value;
            }
        }

        public String InformarNomeCompleto()
        {
            return $"{primeiroNome} {ultimoNome}";
        }
    }
}
