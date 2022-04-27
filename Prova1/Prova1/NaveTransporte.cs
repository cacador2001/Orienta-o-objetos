using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    class NaveTransporte : Nave, IObjetoDestrutivel, IObjetoMovel
    {
        int carga;

        public NaveTransporte(int carga, string nome, int combustivel, int energia, int velocidade, int posicaoX, int posicaoY): base(nome, combustivel, energia, velocidade, posicaoX, posicaoY)
        {
            this.carga = carga;
        }

        public void Movimentar()
        {
            if (carga > 100)
            {
                PosicaoX -= 1;
                PosicaoY -= 1;
                Combustivel -= 30;
            }
            else
            {
                PosicaoX -= 2;
                PosicaoY -= 2;
                Combustivel -= 15;
            }
        }

        public void DanoLeve()
        {
            Energia -= 20;
        }

        public void DanoMedio()
        {
            Energia -= 40;
        }

        public void DanoGrave()
        {
            Energia -= 100;
        }
    }
}
