using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04_Filas
{
    class Program
    {
        static void Main(string[] args)
        {
            FilaDinamica minhaFila = new FilaDinamica();
            try
            {
                minhaFila.Enqueue("Nelson");
                minhaFila.Enqueue("Bob");
                Console.WriteLine(minhaFila.Peek());
                minhaFila.Dequeue();
                minhaFila.Dequeue();
                minhaFila.Enqueue("Rocha");
                minhaFila.Dequeue();
                minhaFila.Enqueue("Testolfo");
                Console.WriteLine(minhaFila.Peek());
            }
            catch(EmptyQueueException eq)
            {
                Console.WriteLine(eq.Message);
            }
            Console.ReadLine();
        }
    }
}
