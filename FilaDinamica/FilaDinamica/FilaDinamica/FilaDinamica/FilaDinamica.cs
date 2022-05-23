using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    class FilaDinamica
    {
        const string EMPTY_QUEUE = "A fila está vazia";
        Node primeiroFila;
        Node ultimoFila;

        public FilaDinamica()
        {
            this.primeiroFila = null;
            this.ultimoFila = null;
        }

        public Node PrimeiroFila
        {
            get
            {
                return primeiroFila;
            }
        }

        public Node UltimoFila
        {
            get
            {
                return ultimoFila;
            }
        }

        public void Enqueue(object elemento)
        {
            Node novoNode = new Node(elemento);
            if (primeiroFila == null)
            {
                primeiroFila = novoNode;
                ultimoFila = novoNode.Elo;
            }
            else
            {
                ultimoFila.Elo = novoNode;
                ultimoFila = novoNode;
            }
        }

        public void Denqueue()
        {
            if (primeiroFila == null)
            {
                throw new EmptyQueueException(EMPTY_QUEUE);
            }
            else
            {
                Node nodeAuxiliar = primeiroFila.Elo;
                primeiroFila = nodeAuxiliar;
            }
        }

        public Object Peek()
        {
            if (primeiroFila == null)
            {
                throw new EmptyQueueException(EMPTY_QUEUE);
            }
            else
            {
                return primeiroFila.Dado;
            }
        }
    }
}
