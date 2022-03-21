using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    class Carro
    {
        public String cor;
        public String modelo;
        public int anoFabricacao;
        public float velocidadeAtual;
        public float velocidadeMaxima;
        public bool ligado;

        public Carro(String _cor, String _modelo, int _anoFabricacao, float _velocidadeMaxima)
        {
            cor = _cor;
            modelo = _modelo;
            anoFabricacao = _anoFabricacao;
            velocidadeMaxima = _velocidadeMaxima;
            velocidadeAtual = 0;
            ligado = false;
        }

        public void Ligar()
        {
            if (ligado == false)
            {
                ligado = true;
                Console.WriteLine("O carro foi ligado");
            }
            else
            {
                Console.WriteLine("O carro já está ligado");
            }
        }

        public void Acelerar()
        {
            if (ligado == true)
            {
                if (velocidadeAtual <= velocidadeMaxima)
                {
                    velocidadeAtual += 30;
                    if (velocidadeAtual > velocidadeMaxima)
                    {
                        velocidadeAtual = velocidadeMaxima;
                        Console.WriteLine("Você não pode acelerar mais que isso");
                    }
                    Console.WriteLine($"A velocidade atual é {velocidadeAtual}");
                }
                else
                {
                }
            }
            else
            {
                Console.WriteLine("O carro está desligado...");
            }
        }

        public void Frear()
        {

        }

        public void Desligar()
        {
            if (ligado == true)
            {
                ligado = false;
                Console.WriteLine("O carro foi desligado");
            }
            else
            {
                Console.WriteLine("O carro já está desligado");
            }
        }
    }
}
