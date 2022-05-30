using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04_Filas
{
    class PainelAtendimento
    {
        FilaDinamica filaSenhas;
        int ultimaSenhaAtendida;
        List<int> listaSenhasGeradas;

        public PainelAtendimento()
        {
            this.filaSenhas = new FilaDinamica();
            this.ultimaSenhaAtendida = -1;
            this.listaSenhasGeradas = new List<int>();
        }

        public int GerarSenha()
        {
            Random rnd = new Random();
            bool senhaUtilizada = false;
            int senhaGerada;
            do
            {
                senhaGerada = rnd.Next(0, 1000);
                if (listaSenhasGeradas.Contains(senhaGerada))
                {
                    senhaUtilizada = true;
                }
                else
                {
                    listaSenhasGeradas.Add(senhaGerada);
                    senhaUtilizada = false;
                    filaSenhas.Enqueue(senhaGerada);
                }
            }
            while (senhaUtilizada == true) ;
            return senhaGerada;
        }

        public int ChamarSenha()
        {
            return (int)filaSenhas.Peek();
        }

        public void AtenderSenha()
        {
            ultimaSenhaAtendida = (int)filaSenhas.Peek();
            filaSenhas.Dequeue();
        }

        public void MostrarListaEspera()
        {
            filaSenhas.ShowQueueElements();
        }

        public void MostrarUltimaSenhaAtendida()
        {
            Console.WriteLine(ultimaSenhaAtendida);
        }
    }
}
