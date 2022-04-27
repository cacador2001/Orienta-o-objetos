using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    class Program
    {
        static void Main(string[] args)
        {
            NaveAtaque bobNelson = new NaveAtaque(10, 50, "Bob Nelson", 100, 100, 40, 5, 0);
            NaveAtaque pirataEspaco1 = new NaveAtaque(10, 20, "Pirata do Espaço 1", 100, 100, 40, 1, 5);
            NaveAtaque pirataEspaco2 = new NaveAtaque(10, 20, "Pirata do Espaço 2", 100, 100, 40, 1, 0);
            NaveAtaque pirataEspaco3 = new NaveAtaque(10, 20, "Pirata do Espaço 3", 100, 100, 40, 1, 10);

            Console.WriteLine($"{bobNelson.Nome} atirou em {pirataEspaco1.Nome}");
            pirataEspaco1.DanoGrave();
            Console.WriteLine($"{pirataEspaco1.Nome} foi destruido");
            bobNelson.Movimentar();
            Console.WriteLine($"{bobNelson.Nome} desviou de um meteoro");
            Console.WriteLine($"{bobNelson.Nome} atirou em {pirataEspaco2.Nome}");
            pirataEspaco2.DanoGrave();
            Console.WriteLine($"{pirataEspaco2.Nome} foi destruido");
            bobNelson.Movimentar();
            Console.WriteLine($"{bobNelson.Nome} desviou de um meteoro");
            Console.WriteLine($"{bobNelson.Nome} atirou em {pirataEspaco3.Nome}");
            pirataEspaco3.DanoGrave();
            Console.WriteLine($"{pirataEspaco3.Nome} foi destruido");
            Console.WriteLine($"{bobNelson.Nome} derrotou todos os inimigos");
            Console.WriteLine("==============================================================");
            Console.ReadLine();
            NaveTransporte nelsonBob = new NaveTransporte(50, "Nelson Bob", 100, 100, 30, 5, 0);
            NaveAtaque piratadoEspaco1 = new NaveAtaque(10, 20, "Pirata do Espaço 1", 100, 100, 40, 1, 5);
            NaveAtaque piratadoEspaco2 = new NaveAtaque(10, 20, "Pirata do Espaço 2", 100, 100, 40, 1, 0);
            Console.WriteLine($"{piratadoEspaco1} atirou em Nelson Bob");
            nelsonBob.DanoLeve();
            Console.WriteLine($"{piratadoEspaco2} atirou em Nelson Bob");
            nelsonBob.DanoMedio();
            Console.WriteLine($"{nelsonBob.Nome} chegou ao destino");
            Console.ReadLine();
        }
    }
}
