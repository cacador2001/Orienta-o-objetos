using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Estudante : Humano
    {
        private int nota;

        public Estudante(string primeiroNome, string ultimoNome, int nota):base(primeiroNome, ultimoNome)
        {
            this.Nota = nota;
        }

        public int Nota
        {
            get
            {
                return nota;
            }

            set
            {
                nota = value;
            }
        }
    }
}
