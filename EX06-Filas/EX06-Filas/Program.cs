using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06_Filas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listaAmigosJosefus = { "Nelson", "Bob", "Rocha", "Testolfo", "Tom", "Tim", "Tati", "Jack", "Josephus", "Jon" };
            int quantidadeAvancos = 4;
            Queue<string> filaAmigos = new Queue<string>();
            foreach (string pessoa in listaAmigosJosefus)
            {
                filaAmigos.Enqueue(pessoa);
            }

            while (filaAmigos.Count > 1)
            {
                filaAmigos.Enqueue(filaAmigos.Dequeue());
                filaAmigos.Enqueue(filaAmigos.Dequeue());
                filaAmigos.Enqueue(filaAmigos.Dequeue());
                Console.WriteLine($"{filaAmigos.Peek()} foi o felizardo da vez...");
                filaAmigos.Dequeue();
            }
            Console.WriteLine($"{filaAmigos.Peek()} sobreviveu...");
            Console.ReadLine();
        }
    }
}
