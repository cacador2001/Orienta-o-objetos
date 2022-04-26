using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    class NaveAtaque : Nave, IObjetoDestrutivel, IObjetoMovel
    {
        int velocidadeTiro;
        int potenciaTiro;

        public int VelocidadeTiro
        {
            get
            {
                return velocidadeTiro;
            }

            set
            {
                velocidadeTiro = value;
            }
        }

        public int PotenciaTiro
        {
            get
            {
                return potenciaTiro;
            }

            set
            {
                potenciaTiro = value;
            }
        }

        public NaveAtaque(int velocidadeTiro, int potenciaTiro, string nome, int combustivel, int energia, int velocidade, int posicaoX, int posicaoY): base(nome, combustivel, energia, velocidade, posicaoX, posicaoY)
        {
            this.velocidadeTiro = velocidadeTiro;
            this.potenciaTiro = potenciaTiro;
        }

        public Tiro Atirar()
        {
            return new Tiro(potenciaTiro, velocidadeTiro, PosicaoX, PosicaoY);
        }

        public void Movimentar()
        {
            PosicaoX += 2;
            PosicaoY += 2;
            Combustivel -= 15;
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
