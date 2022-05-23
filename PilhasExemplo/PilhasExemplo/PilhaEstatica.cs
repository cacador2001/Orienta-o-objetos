using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhasExemplo
{
    class PilhaEstatica
    {
        const String Full_stack = "A pilha já está cheia!";
        const String Empty_stack = "A pilha está vazia!";
        int[] elementos;
        int topo;
        int quantidadeElementos;

        public int[] Elementos
        {
            get
            {
                return elementos;
            }
        }

        public int Topo
        {
            get
            {
                return topo;
            }
        }

        public int QuantidadeElementos
        {
            get
            {
                return quantidadeElementos;
            }
        }

        public PilhaEstatica(int quantidadeElementos)
        {
            this.elementos = new int[quantidadeElementos];
            this.topo = -1;
            this.quantidadeElementos = quantidadeElementos;
        }

        public void Push(int numero)
        {
            if (topo < quantidadeElementos - 1)
            {
                topo++;
                elementos[topo] = numero;
            }
            else
            {
                throw new FullStackException(Full_stack);
            }
        }

        public int Pop()
        {
            if (topo > -1)
            {
                int elemento = elementos[topo];
                topo--;
                return elemento;    
            }
            else
            {
                throw new EmptyStackException(Empty_stack);
            }
        }

        public int Peek()
        {
            if (topo > -1)
            {
                return elementos[topo];
            }
            else
            {
                throw new EmptyStackException(Empty_stack);
            }
        }

        public void PrintStack()
        {
            if (topo > -1)
            {
                for (int i = topo; i >= 0; i--)
                {
                    Console.WriteLine(elementos[i]);
                }
            }
            else
            {
                throw new EmptyStackException(Empty_stack);
            }
        }

        public int Count()
        {
            return topo + 1;
        }
    }
}
