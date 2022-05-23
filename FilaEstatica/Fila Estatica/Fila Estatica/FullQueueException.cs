using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila_Estatica
{
    class FullQueueException: ApplicationException
    {
        public FullQueueException(string message): base(message){ }
    }
}
