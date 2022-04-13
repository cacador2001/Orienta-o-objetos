using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Livro : Produto
    {
        string desenvolvedora;
        string titulo;
        string console;

        public string Desenvolvedora
        {
            get
            {
                return desenvolvedora;
            }
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }
        }

        public string Console
        {
            get
            {
                return console;
            }
        }

        public Livro(string desenvolvedora, string titulo, string console, int preco): base(preco)
        {
            this.desenvolvedora = desenvolvedora;
            this.titulo = titulo;
            this.console = console;
        }
    }
}
