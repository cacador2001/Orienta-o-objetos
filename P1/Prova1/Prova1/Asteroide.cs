using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    class Asteroide
    {
        int energia;
        int velocidade;
        int posicaoX;
        int posicaoY;

        public int Energia
        {
            get
            {
                return energia;
            }

            set
            {
                energia = value;
            }
        }

        public int Velocidade
        {
            get
            {
                return velocidade;
            }

            set
            {
                velocidade = value;
            }
        }

        public int PosicaoX
        {
            get
            {
                return posicaoX;
            }

            set
            {
                posicaoX = value;
            }
        }

        public int PosicaoY
        {
            get
            {
                return posicaoY;
            }

            set
            {
                posicaoY = value;
            }
        }

        public Asteroide(int energia, int velocidade, int posicaoX, int posicaoY)
        {
            this.energia = energia;
            this.velocidade = velocidade;
            this.posicaoX = posicaoX;
            this.posicaoY = posicaoY;
        }
    }
}
