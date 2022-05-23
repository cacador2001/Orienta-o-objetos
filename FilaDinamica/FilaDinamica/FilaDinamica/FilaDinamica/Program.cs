using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FilaDinamica minhaFila = new FilaDinamica();
                minhaFila.Enqueue("Bob Nelson");
                Console.WriteLine(minhaFila.Peek());
            }
            catch (EmptyQueueException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
