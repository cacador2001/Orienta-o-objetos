using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhasExemplo
{
    class FullStackException : ApplicationException
    {
        public FullStackException(string message) : base(message) { }
    }
}
