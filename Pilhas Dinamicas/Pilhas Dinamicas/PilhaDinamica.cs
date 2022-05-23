using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas_Dinamicas
{
    class PilhaDinamica
    {
        Node topo;
        const string PILHA_VAZIA = "A pilha está vazia";

        public PilhaDinamica()
        {
            this.topo = null;
        }

        public Node Topo1
        {
            get
            {
                return topo;
            }
        }

        public void Push(string dado)
        {
            Node novoNode = new Node(dado);
            novoNode.Elo = topo;
            topo = novoNode;
        }

        public void Pop()
        {
            if (topo != null)
            {
                topo = topo.Elo;
            }
            else
            {
                throw new EmptyStackException(PILHA_VAZIA);
            }
        }

        public string Peek()
        {
            if (topo != null)
            {
                return topo.Dado;
            }
            else
            {
                throw new EmptyStackException(PILHA_VAZIA);
            }
        }

        public int Count()
        {
            int quantidadeElementos = 0;
            Node nodeAuxiliar = topo;
            if (topo == null)
            {
                return quantidadeElementos;
            }
            else
            {
                quantidadeElementos++;
                while (nodeAuxiliar != null)
                {
                    quantidadeElementos++;
                    nodeAuxiliar = nodeAuxiliar.Elo;
                }
                return quantidadeElementos;
            }
        }

        public string[] ToArray()
        {
            string[] elementos = new string[Count()];
            Node nodeAuxiliar = topo;
            for (int i = 0; i < elementos.Length; i++)
            {
                elementos[i] = nodeAuxiliar.Dado;
                nodeAuxiliar = nodeAuxiliar.Elo;
            }
            return elementos;
        }
    }
}
