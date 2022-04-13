using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Carro
    {
        string cor;
        string modelo;
        int anoFabricacao;
        float velocidadeAtual = 0;
        float velocidadeMaxima;
        bool ligado = false;

        public string Cor
        {
            get
            {
                return cor;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }
        }

        public int AnoFabricacao
        {
            get
            {
                return anoFabricacao;
            }
        }

        public float VelocidadeAtual
        {
            get
            {
                return velocidadeAtual;
            }
        }

        public float VelocidadeMaxima
        {
            get
            {
                return velocidadeMaxima;
            }
        }

        public bool Ligado
        {
            get
            {
                return ligado;
            }
        }

        public Carro(string cor, string modelo, int anoFabricacao, float velocidadeAtual, float velocidadeMaxima, bool ligado)
        {
            this.cor = cor;
            this.modelo = modelo;
            this.anoFabricacao = anoFabricacao;
            this.velocidadeAtual = velocidadeAtual;
            this.velocidadeMaxima = velocidadeMaxima;
            this.ligado = ligado;
        }

        public void Ligar()
        {
            ligado = true;
        }

        public void Desligar()
        {
            ligado = false;
        }

        public void Acelerar()
        {
            int aceleracaoPadrao = 30;

            if (ligado == true)
            {
                velocidadeAtual += aceleracaoPadrao;
                if (velocidadeAtual >= velocidadeMaxima)
                {
                    velocidadeAtual = velocidadeMaxima;
                }
            }
        }

        public void Frear()
        {
            int desaceleracaoPadrao = 50;

            if (ligado == true)
            {
                velocidadeAtual -= desaceleracaoPadrao;
                if (velocidadeAtual < 0)
                {
                    velocidadeAtual = 0;
                }
            }
        }
    }
}
