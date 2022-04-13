using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04_Polimorfismo
{
    class Minivan : Carro
    {
        string modelo;
        string cor;
        int anoFabricacao;

        public string Modelo1
        {
            get
            {
                return modelo;
            }
        }

        public string Cor1
        {
            get
            {
                return cor;
            }
        }

        public int AnoFabricacao1
        {
            get
            {
                return anoFabricacao;
            }
        }

        public Minivan(string modelo, string cor, int anoFabricacao): base (modelo, cor, anoFabricacao)
        {
            this.modelo = modelo;
            this.cor = cor;
            this.anoFabricacao = anoFabricacao;
        }
    }
}
