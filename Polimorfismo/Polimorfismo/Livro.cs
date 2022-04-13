using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Livro : Produto
    {
        string desenvolvedora;
        string titulo;

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

        public Livro(string desenvolvedora, string titulo, float preco): base(preco)
        {
            this.desenvolvedora = desenvolvedora;
            this.titulo = titulo;
        }

        public override string InformarDescricao()
        {
            return $"{titulo} escrito por {desenvolvedora}";
        }
    }
}
