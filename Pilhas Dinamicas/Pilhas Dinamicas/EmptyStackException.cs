using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas_Dinamicas
{
    class EmptyStackException : ApplicationException
    {
        public EmptyStackException(string message): base(message) {}
    }
}
