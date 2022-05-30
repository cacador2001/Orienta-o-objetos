using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04_Filas
{
    class FilaDinamica
    {
        const string EMPTY_QUEUE = "A pilha está vazia";
        Node primeiroFila;
        Node ultimoFila;

        internal Node PrimeiroFila
        {
            get
            {
                return primeiroFila;
            }
            set
            {
                primeiroFila = value;
            }
        }

        internal Node UltimoFila
        {
            get
            {
                return ultimoFila;
            }
            set
            {
                ultimoFila = value;
            }
        }

        public void Enqueue(object elemento)
        {
            Node novoNode = new Node(elemento);
            if (UltimoFila != null)
            {
                UltimoFila.Elo = novoNode;
            }
            UltimoFila = novoNode;
            if (PrimeiroFila == null)
            {
                PrimeiroFila = novoNode;
            }
        }

        public object Peek()
        {
            if (PrimeiroFila == null)
            {
                throw new EmptyQueueException(EMPTY_QUEUE);
            }
            else
            {
                return PrimeiroFila.Dado;
            }
        }

        public void Dequeue()
        {
            if (PrimeiroFila == null)
            {
                throw new EmptyQueueException(EMPTY_QUEUE);
            }
            else
            {
                primeiroFila = PrimeiroFila.Elo;
            }
        }

        public void ShowQueueElements()
        {
            Node nodeAuxiliar = PrimeiroFila;
            while(nodeAuxiliar.Elo != null)
            {
                Console.Write($"{nodeAuxiliar.Dado} \t");
                nodeAuxiliar = PrimeiroFila.Elo;
            }
        }
    }
}
