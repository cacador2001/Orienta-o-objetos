using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Clientes
    {
        public string nome;
        public int idade;
        public float peso;
        public float altura;
        public float imc;

        public Clientes(string nome, int idade, float peso, float altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.altura = altura;
        }

        public void CalcularIMC()
        {
            imc = peso / (altura * altura);
            Console.WriteLine($"Seu IMC é {imc}");
            if (imc >= 18.5f && imc <= 24.9f)
            {
                Console.WriteLine("Parabéns -- Você está em seu peso normal");
            }
            else if (imc >= 25 && imc <= 29.9f)
            {
                Console.WriteLine("Você está acima do seu peso (sobrepeso)");
            }
            else if (imc >= 30 && imc <= 34.9f)
            {
                Console.WriteLine("Obesidade grau I");
            }
            else if (imc >= 35f && imc <= 40f)
            {
                Console.WriteLine("Obesidade grau II");
            }
            else if (imc > 40f)
            {
                Console.WriteLine("Obesidade grau III e IV");
            }
        }

        public void Meta()
        {
            if (imc > 24.9)
            {
                double calculoIMC = imc - 24.9f;
                double meta = calculoIMC * (altura * altura);
                Console.WriteLine($"Para atingir a normalidade do seu IMC, você deve perder {meta.ToString("F")} quilos");
            }
        }
    }
}
