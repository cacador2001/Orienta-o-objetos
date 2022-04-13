using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class JogoDigital : Produto
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

        public JogoDigital(string desenvolvedora, string titulo, string console, float preco) :base(preco)
        {
            this.desenvolvedora = desenvolvedora;
            this.titulo = titulo;
            this.console = console;
        }

        public override string InformarDescricao()
        {
            return $"{titulo} feito por {desenvolvedora}";
        }
    }
}
