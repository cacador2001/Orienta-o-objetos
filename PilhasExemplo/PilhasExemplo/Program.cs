using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhasExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PilhaEstatica minhaPilha = new PilhaEstatica(3);
                minhaPilha.Push(10);
                Console.WriteLine($"O topo da pilha é {minhaPilha.Peek()}");
                minhaPilha.Push(11);
                Console.WriteLine($"O topo da pilha é {minhaPilha.Peek()}");
                minhaPilha.Push(17);
                Console.WriteLine($"O topo da pilha é {minhaPilha.Peek()}");
                Console.WriteLine($"Número retirado: {minhaPilha.Pop()}");
                Console.WriteLine($"Imprimindo a Pilha: ");
                minhaPilha.PrintStack();
                Console.ReadLine();
                Console.WriteLine($"O topo da pilha é {minhaPilha.Peek()}");
                Console.WriteLine($"Número retirado: {minhaPilha.Pop()}");
                Console.WriteLine($"O topo da pilha é {minhaPilha.Peek()}");
                minhaPilha.Push(100);
                Console.WriteLine($"O topo da pilha é {minhaPilha.Peek()}");
                Console.WriteLine($"Número retirado: {minhaPilha.Pop()}");
                Console.WriteLine($"O topo da pilha é {minhaPilha.Peek()}");
                Console.WriteLine($"Número retirado: {minhaPilha.Pop()}");
                Console.WriteLine($"O topo da pilha é {minhaPilha.Peek()}");
                Console.WriteLine(minhaPilha.Count());
            }
            catch(FullStackException FSE)
            {
                Console.WriteLine(FSE.Message);
            }
            catch(EmptyStackException ESE)
            {
                Console.WriteLine(ESE.Message);
            }
            Console.ReadLine();
        }
    }
}
