using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila_Estatica
{
    class FilaEstatica
    {
        const string FULL_QUEUE = "A fila está cheia";
        const string EMPTY_QUEUE = "A fila está vazia";
        int primeiroDaFila;
        int ultimoDaFila;
        int[] elementos;

        public int PrimeiroDaFila
        {
            get
            {
                return primeiroDaFila;
            }
        }

        public int UltimoDaFila
        {
            get
            {
                return ultimoDaFila;
            }
        }

        public int[] Elementos
        {
            get
            {
                return elementos;
            }
        }

        public FilaEstatica(int quantidadeElementos)
        {
            this.primeiroDaFila = 0;
            this.ultimoDaFila = -1;
            this.elementos = new int[quantidadeElementos];
        }

        public void Enqueue(int elemento)
        {
            if (ultimoDaFila < elementos.Length - 1)
            {
                ultimoDaFila++;
                elementos[ultimoDaFila] = elemento;
            }
            else
            {
                throw new FullQueueException(FULL_QUEUE);
            }
        }

        public void Denqueue()
        {
            if (ultimoDaFila > -1)
            {
                primeiroDaFila++;
                if (primeiroDaFila > ultimoDaFila)
                {
                    primeiroDaFila = 0;
                    ultimoDaFila = -1;
                }
            }
            else
            {
                throw new EmptyQueueException(EMPTY_QUEUE);
            }
        }

        public int Peek()
        {
            if (ultimoDaFila == -1)
            {
                throw new EmptyQueueException(EMPTY_QUEUE);
            }
            else
            {
                return elementos[primeiroDaFila];
            }
        }

        public int Count()
        {
            if (primeiroDaFila > ultimoDaFila)
            {
                return 0;
            }
            else
            {
                return (ultimoDaFila - primeiroDaFila) + 1;
            }
        }
    }
}
