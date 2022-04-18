using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02_Interface
{
    class Hexagono : FiguraGeometrica
    {
        const int numeroLadosHexagono = 6;

        public Hexagono(float medida): base(medida)
        {

        }

        public override double CalcularArea()
        {
            //return Medida * Medida * 3 * Math;
        }

        public override double CalcularPerimetro()
        {
            return numeroLadosHexagono * Medida;
        }
    }
}
