using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas_Dinamicas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestarPilhaDinamica();
                Stack<object> stack = new Stack<object>();
                stack.Push(25);
                Console.WriteLine(stack.Peek());
                stack.Push("Bob Nelson");
                Console.WriteLine(stack.Peek());
                stack.Push(true);
                Console.WriteLine(stack.Peek());
            }
            catch (EmptyStackException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }

        private static void TestarPilhaDinamica()
        {
            PilhaDinamica minhaPilha = new PilhaDinamica();
            Console.WriteLine($"A pilha tem {minhaPilha.Count()} elementos");
            minhaPilha.Push("ABC");
            Console.WriteLine(minhaPilha.Peek());
            minhaPilha.Push("DEF");
            Console.WriteLine(minhaPilha.Peek());
            minhaPilha.Push("GHI");
            Console.WriteLine(minhaPilha.Peek());
            minhaPilha.Push("JKL");
            Console.WriteLine(minhaPilha.Peek());
            minhaPilha.Pop();
            Console.WriteLine($"A pilha tem {minhaPilha.Count()} elementos");
        }
    }
}
