using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04_Polimorfismo
{
    class Carro
    {
        string modelo;
        string cor;
        int anoFabricacao;

        public Carro(string modelo, string cor, int anoFabricacao)
        {
            this.modelo = modelo;
            this.cor = cor;
            this.anoFabricacao = anoFabricacao;
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public string Cor
        {
            get
            {
                return cor;
            }

            set
            {
                cor = value;
            }
        }

        public int AnoFabricacao
        {
            get
            {
                return anoFabricacao;
            }

            set
            {
                anoFabricacao = value;
            }
        }

        public string DescreverCarro()
        {
            return "Descrição básica do carro";
        }

        public string MostrarDetalhes()
        {
            return "mais detalhes";
        }
    }
}
