using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02_Interface
{
    abstract class FiguraGeometrica
    {
        float medida;

        public FiguraGeometrica(float medida)
        {
            this.medida = medida;
        }

        public float Medida
        {
            get
            {
                return medida;
            }
        }

        public virtual void CalcularArea()
        {

        }

        public virtual void CalcularPerimetro()
        {

        }
    }
}
