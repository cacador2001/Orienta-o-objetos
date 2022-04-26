using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    abstract class Nave
    {
        string nome;
        int combustivel;
        int energia;
        int velocidade;
        int posicaoX;
        int posicaoY;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Combustivel
        {
            get
            {
                return combustivel;
            }

            set
            {
                combustivel = value;
            }
        }

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

        public Nave(string nome, int combustivel, int energia, int velocidade, int posicaoX, int posicaoY)
        {
            this.nome = nome;
            this.combustivel = combustivel;
            this.energia = energia;
            this.velocidade = velocidade;
            this.posicaoX = posicaoX;
            this.posicaoY = posicaoY;
        }
    }
}
